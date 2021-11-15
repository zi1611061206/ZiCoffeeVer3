using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Media;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZiCoffe.DAO;
using ZiCoffe.DTO;

namespace ZiCoffe.GUI
{
    public partial class formProfile : Form
    {
        public Stream streamOpen = null;
        public Stream streamClick = null;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private EmployeesDTO currentAccount;

        public EmployeesDTO CurrentAccount
        {
            get { return currentAccount; }
            set { currentAccount = value; ChangeAccount(currentAccount); }
        }

        public formProfile(EmployeesDTO account)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            LoadGlobal();
            this.CurrentAccount = account;
        }

        private void LoadGlobal()
        {
            ChangeLanguage(Properties.Settings.Default.language);
            (this as Form).BackColor 
                = txbAddress.BackColor
                = txbIDCard.BackColor
                = txbName.BackColor
                = txbPhone.BackColor
                = txbPosition.BackColor
                = txbUsername.BackColor
                = txbSex.BackColor
                = txbBirth.BackColor
                = Properties.Settings.Default.currentThemeColor;
            btnChangePassword.BackColor = Properties.Settings.Default.typeBack3;
            btnChangePassword.ForeColor = Properties.Settings.Default.typeFore3;
            btnExit.BackColor = Properties.Settings.Default.typeBack1;
            btnExit.ForeColor = Properties.Settings.Default.typeFore1;

            if (Properties.Settings.Default.appearance)
            {
                streamOpen = Properties.Resources.open;
            }
            else
            {
                streamOpen = null;
            }

            if (streamOpen != null)
            {
                SoundPlayer sound = new SoundPlayer();
                sound.Stream = streamOpen;
                sound.Play();
            }

            if (Properties.Settings.Default.click)
            {
                streamClick = Properties.Resources.clickOK;
            }
            else
            {
                streamClick = null;
            }
        }

        BindingSource employeesSource = new BindingSource();

        #region Method
        void ChangeAccount(EmployeesDTO account)
        {
            txbUsername.Text = Properties.Settings.Default.usernameStaff;
            txbName.Text = $"{CurrentAccount.Ho} {CurrentAccount.TenDem} {CurrentAccount.Ten}";
            string positionName = PositionDAO.Instance.GetPositionName(currentAccount.MaChucVu);
            txbPosition.Text = positionName;
            txbIDCard.Text = CurrentAccount.ChungMinhNhanDan;
            txbAddress.Text = CurrentAccount.DiaChi;
            txbPhone.Text = CurrentAccount.SoDienThoai;
            string sex = "Nam";
            if((int)currentAccount.GioiTinh == 1)
            {
                sex = "Nữ";
            }
            txbSex.Text = sex;
            txbBirth.Text = currentAccount.NgaySinh.ToLongDateString();
            int staffID = currentAccount.MaNhanVien;
            employeesSource.DataSource = EmployeesDAO.Instance.GetEmployeesById(staffID);
            picAvatar.DataBindings.Add(new Binding("Image", employeesSource, "Ảnh", true, DataSourceUpdateMode.Never));
        }
        #endregion

        #region event

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            formChangePassword f = new formChangePassword(currentAccount);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void allButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && streamClick != null)
            {
                SoundPlayer sound = new SoundPlayer();
                streamClick.Position = 0;
                sound.Stream = null;
                sound.Stream = streamClick;
                sound.Play();
            }
        }

        #endregion

        #region Event Effect
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            pic.Width += 3;
            pic.Height += 3;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            pic.Width -= 3;
            pic.Height -= 3;
        }

        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            btnExit.BackColor = Properties.Settings.Default.typeBack3;
            btnExit.ForeColor = Properties.Settings.Default.typeFore3;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackColor = Properties.Settings.Default.typeBack1;
            btnExit.ForeColor = Properties.Settings.Default.typeFore1;
        }

        private void pnlTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private void ChangeLanguage(string cultureName)
        {
            CultureInfo culture = CultureInfo.CreateSpecificCulture(cultureName);
            ResourceManager rm = new ResourceManager("ZiCoffe.Lang.ResourceLang", typeof(formMain).Assembly);
        }
    }
}
