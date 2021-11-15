using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZiCoffe.DAO;
using ZiCoffe.DTO;

namespace ZiCoffe.GUI
{
    public partial class formFirstUse : Form
    {
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

        public formFirstUse()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            LoadPosition(cbPosition);
        }

        private void formFirstUse_Load(object sender, EventArgs e)
        {
            LoadGlobal();
            lbTitle.Text = Properties.Resources.firstUserDefault;
            pnlErrorMessage.Visible = false;
        }

        private void LoadGlobal()
        {
            btnAgree.BackColor = Properties.Settings.Default.typeBack3;
            btnAgree.ForeColor = Properties.Settings.Default.typeFore3;
            btnDisagree.BackColor = Properties.Settings.Default.typeBack1;
            btnDisagree.ForeColor = Properties.Settings.Default.typeFore1;
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        #region Method
        void LoadPosition(ComboBox cb)
        {
            cb.DataSource = PositionDAO.Instance.GetPositionList();
            cb.DisplayMember = "tenchucvu";
        }
        #endregion

        #region Event
        private void btnAgree_Click(object sender, EventArgs e)
        {
            string username = txbUsername.Text;
            string name = txbName.Text;
            int positionID = (cbPosition.SelectedItem as PositionDTO).MaChucVu;
            string idNum = txbIDNum.Text;
            string address = txbAddress.Text;
            string phone = txbPhone.Text;
            try
            {
                //EmployeesDAO.Instance.AddEmployees(name, idNum, address, phone, false);
                int employeesID = EmployeesDAO.Instance.GetMaxEmployeesID();
                //AccountDAO.Instance.AddAccount(username, positionID, employeesID);
                //if (MessageBox.Show("Tên đăng nhập: " + username + "\nMật khẩu: 1 \nĐĂNG NHẬP NGAY!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.No)
                //{
                //    formLogin f = new formLogin();
                //    this.Hide();
                //    f.ShowDialog();
                //}
                //else
                //{
                //    this.Close();
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDisagree_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Event Effect
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            pic.Width -= 3;
            pic.Height -= 3;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnDisagree_MouseHover(object sender, EventArgs e)
        {
            btnDisagree.BackColor = Color.FromArgb(78, 184, 206);
            btnDisagree.ForeColor = Color.FromArgb(34, 36, 49);
        }

        private void btnDisagree_MouseLeave(object sender, EventArgs e)
        {
            btnAgree.BackColor = Color.FromArgb(78, 184, 206);
            btnAgree.ForeColor = Color.FromArgb(34, 36, 49);
        }

        private void pnlTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
    }
}
