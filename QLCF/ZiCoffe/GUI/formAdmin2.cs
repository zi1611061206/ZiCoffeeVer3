using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ZiCoffe.DTO;
using System.IO;
using System.Media;
using System.Globalization;
using System.Resources;

namespace ZiCoffe.GUI
{
    public partial class formAdmin2 : Form
    {
        public string soundTrackPath = null;
        public Stream streamOpen = null;
        public Stream streamClick = null;

        public EmployeesDTO currentAccount;

        public formAdmin2()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void formAdmin2_Load(object sender, EventArgs e)
        {
            pnlToolbar.Width = 53;
            LoadGlobal();
            LoadContent(new PartrialGUI.HomeLoad());
            if(this.WindowState==FormWindowState.Maximized)
            {
                pictureBox2.Visible = false;
                pictureBox4.Visible = true;
            }
            else
            {
                pictureBox2.Visible = true;
                pictureBox4.Visible = false;
            }
        }

        private void LoadGlobal()
        {
            ChangeLanguage(Properties.Settings.Default.language);
            pnlToolbar.BackColor 
                = lbAdmin.BackColor
                = btnContact.BackColor
                = btnDrinks.BackColor
                = btnImport.BackColor
                = btnMaterial.BackColor
                = btnOnline.BackColor
                = btnPreparation.BackColor
                = btnRevenue.BackColor
                = btnStaff.BackColor
                = btnSupplier.BackColor
                = btnTable.BackColor
                = Properties.Settings.Default.currentThemeColor;

            lbTitle.Text = Properties.Resources.programNameDefault;
            lbCompany.Text = Properties.Resources.copyrightDefault;
            lbVersion.Text = Properties.Resources.versionDefault;

            pnlTitle.BackColor = Properties.Settings.Default.titleBackColor;
            pnlFooter.BackColor = Properties.Settings.Default.footerBackColor;

            lbTitle.ForeColor = Properties.Settings.Default.titleForeColor;
            lbVersion.ForeColor = lbCompany.ForeColor = Properties.Settings.Default.footerForeColor;

            if (Properties.Settings.Default.appearance)
            {
                streamOpen = Properties.Resources.open;
            }
            else
            {
                streamOpen = null;
            }

            if (Properties.Settings.Default.click)
            {
                streamClick = Properties.Resources.clickOK;
            }
            else
            {
                streamClick = null;
            }

            if (streamOpen != null)
            {
                SoundPlayer sound = new SoundPlayer();
                sound.Stream = streamOpen;
                sound.Play();
            }
        }

        #region Method
        private void LoadContent(object partrialForm)
        {
            Form partrial = partrialForm as Form;
            partrial.TopLevel = false;
            partrial.Dock = DockStyle.Fill;

            if (this.pnlControlers.Controls.Count > 0)
                this.pnlControlers.Controls.Clear();
            
            this.pnlControlers.Controls.Add(partrial);
            partrial.Show();
        }
        #endregion

        #region Event

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            LoadContent(new PartrialGUI.Revenue());
        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {
            LoadContent(new PartrialGUI.Menu());
        }

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            LoadContent(new PartrialGUI.Material());
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            LoadContent(new PartrialGUI.Supplier());
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            LoadContent(new PartrialGUI.Staffs());
        }

        private void btnOnline_Click(object sender, EventArgs e)
        {
            LoadContent(new PartrialGUI.Online());
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            LoadContent(new PartrialGUI.Contact());
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            LoadContent(new PartrialGUI.Tables());
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            LoadContent(new PartrialGUI.Import());
        }

        private void btnPreparation_Click(object sender, EventArgs e)
        {
            LoadContent(new PartrialGUI.DrinkRecipe());
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pictureBox2.Visible = false;
            pictureBox4.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picMenuBar_Click(object sender, EventArgs e)
        {
            if (pnlToolbar.Width == 205)
                pnlToolbar.Width = 53;
            else
                pnlToolbar.Width = 205;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pictureBox2.Visible = true;
            pictureBox4.Visible = false;
        }

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
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
