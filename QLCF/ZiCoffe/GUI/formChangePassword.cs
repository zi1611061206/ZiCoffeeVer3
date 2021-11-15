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
    public partial class formChangePassword : Form
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
            set { currentAccount = value; }
        }

        public formChangePassword(EmployeesDTO account)
        {
            InitializeComponent();
            this.CurrentAccount = account;
            LoadGlobal();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void LoadGlobal()
        {
            ChangeLanguage(Properties.Settings.Default.language);
            (this as Form).BackColor 
                = pnlTitle.BackColor
                = txbNewPass.BackColor
                = txbOldPass.BackColor
                = txbReEnter.BackColor
                = Properties.Settings.Default.currentThemeColor;
            btnSave.BackColor = Properties.Settings.Default.typeBack3;
            btnSave.ForeColor = Properties.Settings.Default.typeFore3;
            btnCancel.BackColor = Properties.Settings.Default.typeBack1;
            btnCancel.ForeColor = Properties.Settings.Default.typeFore1;

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

        #region Event

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txbNewPass.Text) || !txbNewPass.Text.Equals(txbReEnter.Text) )
            {
                MessageBox.Show("Mật khẩu xác nhận không trùng khớp hoặc thông tin yêu cầu bị bỏ trống. \n\nVui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (AccountDAO.Instance.UpdatePassword(Properties.Settings.Default.usernameStaff, txbOldPass.Text, txbNewPass.Text))
                {
                    MessageBox.Show("Cập nhật mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mật khẩu hiện tại của bạn không đúng. \n\nVui lòng điền đúng mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCancel_MouseHover(object sender, EventArgs e)
        {
            btnCancel.BackColor = Properties.Settings.Default.typeBack3;
            btnCancel.ForeColor = Properties.Settings.Default.typeFore3;
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCancel.BackColor = Properties.Settings.Default.typeBack1;
            btnCancel.ForeColor = Properties.Settings.Default.typeFore1;
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
