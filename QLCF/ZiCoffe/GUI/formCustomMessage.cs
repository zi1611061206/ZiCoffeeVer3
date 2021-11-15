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

namespace ZiCoffe.GUI
{
    public partial class formCustomMessage : Form 
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

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public Stream streamOpen = null;
        public Stream streamClick = null;

        public formCustomMessage()
        {
            InitializeComponent();
            LoadGlobal();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void LoadGlobal()
        {
            ChangeLanguage(Properties.Settings.Default.language);
            (this as Form).BackColor = pnlDescription.BackColor = pnlFooter.BackColor = Properties.Settings.Default.currentThemeColor;
            pnlTitle.BackColor = Properties.Settings.Default.titleBackColor;
            btnOK.BackColor = Properties.Settings.Default.typeBack1;
            btnOK.ForeColor = Properties.Settings.Default.typeFore1;

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

        public Image Picture
        {
            get { return picImage.Image; }
            set { picImage.Image = value; }
        }

        public string Description
        {
            get { return lbDescription.Text; }
            set { lbDescription.Text = value; }
        }

        private void btnOK_MouseHover(object sender, EventArgs e)
        {
            btnOK.BackColor = Properties.Settings.Default.typeBack3;
            btnOK.ForeColor = Properties.Settings.Default.typeFore3;
        }

        private void btnOK_MouseLeave(object sender, EventArgs e)
        {
            btnOK.BackColor = Properties.Settings.Default.typeBack1;
            btnOK.ForeColor = Properties.Settings.Default.typeFore1;
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

        private void ChangeLanguage(string cultureName)
        {
            CultureInfo culture = CultureInfo.CreateSpecificCulture(cultureName);
            ResourceManager rm = new ResourceManager("ZiCoffe.Lang.ResourceLang", typeof(formMain).Assembly);
        }

        private void pnlTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
