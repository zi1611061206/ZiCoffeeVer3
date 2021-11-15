using Quobject.SocketIoClientDotNet.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Media;
using System.Net.Sockets;
using System.Resources;
using System.Runtime.InteropServices;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZiCoffe.DAO;
using ZiCoffe.DTO;
using Socket = Quobject.SocketIoClientDotNet.Client.Socket;

namespace ZiCoffe.GUI
{
    public partial class formLogin : Form
    {
        //Bo cong các góc của form
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
        //Giữ và di chuyển form trên màn hình
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public Stream streamInit = null; //Đầu vào cho âm thanh khởi tạo form
        public Stream streamClick = null; //Đầu vào cho âm thanh click

        public formLogin()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20)); //Áp dụng bo góc cho form
            LoadGlobal();
        }

        private void LoadGlobal()
        {
            ChangeLanguage(Properties.Settings.Default.language);
            (this as Form).BackColor = txbUsername.BackColor = txbPassword.BackColor = Properties.Settings.Default.currentThemeColor;
            btnLogin.BackColor = Properties.Settings.Default.typeBack3;
            btnLogin.ForeColor = Properties.Settings.Default.typeFore3;
            btnExit.BackColor = Properties.Settings.Default.typeBack1;
            btnExit.ForeColor = Properties.Settings.Default.typeFore1;

            if (Properties.Settings.Default.appearance)
            {
                streamInit = Properties.Resources.open;
            }
            else
            {
                streamInit = null;
            }

            if (Properties.Settings.Default.click)
            {
                streamClick = Properties.Resources.clickOK;
            }
            else
            {
                streamClick = null;
            }

            if (streamInit != null)
            {
                SoundPlayer sound = new SoundPlayer();
                sound.Stream = streamInit;
                sound.Play();
            }
        }

        #region Hàm xử lí thoát

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                if (Properties.Settings.Default.bye)
                {
                    Bye();
                }
                Application.Exit();
            }
            else
                return;
        }

        public bool Bye()
        {
            SpeechSynthesizer speaker = new SpeechSynthesizer();
            speaker.Volume = Properties.Settings.Default.speakerVolumn;
            speaker.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Child);
            speaker.Rate = Properties.Settings.Default.speakerRate;
            string str = Properties.Settings.Default.goodbye;
            speaker.Speak(str);
            return true;
        }

        #endregion

        #region Hàm xử lí đăng nhập

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txbUsername.Text.ToString();
            string password = txbPassword.Text.ToString();

            if (!String.IsNullOrEmpty(username) || !String.IsNullOrEmpty(password))
            {
                if (Login(username, password))
                {
                    int positionID = LoginDAO.Instance.GetPositionID(username);
                    switch (positionID)
                    {
                        case 1:
                        case 2:
                            AccessCashier(username);
                            break;
                        default: break;
                    }
                }
                else
                {
                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu","Cảnh báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        bool Login(string username, string password)
        {
            return LoginDAO.Instance.Login(username, password);
        }

        void AccessCashier(string username)
        {
            EmployeesDTO employees = LoginDAO.Instance.GetEmployees(username);

            Properties.Settings.Default.addressStaff = employees.DiaChi;
            Properties.Settings.Default.phoneStaff = employees.SoDienThoai;
            Properties.Settings.Default.sexStaff = employees.GioiTinh;
            Properties.Settings.Default.birthStaff = employees.NgaySinh;
            Properties.Settings.Default.idCardStaff = employees.ChungMinhNhanDan;
            Properties.Settings.Default.positionStaff = employees.MaChucVu;
            Properties.Settings.Default.nameStaff = $"{employees.Ho} {employees.TenDem} {employees.Ten}";

            Properties.Settings.Default.usernameStaff = username;

            formMain f = new formMain(employees);
            this.Hide();
            f.ShowDialog();
            LoadGlobal();
            this.Show();
        }

        #endregion

        #region Event Effect
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

        private void txbUsername_Click(object sender, EventArgs e)
        {
            if(txbUsername.Text=="Tên đăng nhập")
            {
                txbUsername.Clear();
            }
            picUsername.Image = Properties.Resources.login;
            txbUsername.ForeColor = Color.FromArgb(78, 184, 206);
            pnlLine1.BackColor=Color.FromArgb(78, 184, 206);

            picPassword.Image = Properties.Resources.password1;
            txbPassword.ForeColor = Color.White;
            pnlLine2.BackColor = Color.White;
        }

        private void txbPassword_Click(object sender, EventArgs e)
        {
            txbPassword.Clear();
            picUsername.Image = Properties.Resources.login1;
            txbUsername.ForeColor = Color.White;
            pnlLine1.BackColor = Color.White;

            picPassword.Image = Properties.Resources.password;
            txbPassword.ForeColor = Color.FromArgb(78, 184, 206);
            pnlLine2.BackColor = Color.FromArgb(78, 184, 206);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            btnExit_Click(this, new EventArgs());
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
            //Áp dụng di chuyển form cho pnlTitle
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
