using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZiCoffe.GUI
{
    public partial class formInitialize : Form
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

        public Stream streamOpen = null;

        public formInitialize()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void formInitialize_Load(object sender, EventArgs e)
        {
            (this as Form).BackColor 
                = pnlGif.BackColor
                = pnlProcsess.BackColor
                = lbInitialize.BackColor
                = Properties.Settings.Default.currentThemeColor;

            if (Properties.Settings.Default.appearance)
            {
                streamOpen = Properties.Resources.intro;
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
        }

        private void timerProgress_Tick(object sender, EventArgs e)
        {
            this.prgInitialize.Increment(1);
            if (prgInitialize.Value == 100)
            {
                timerProgress.Stop();
                this.Close();
            }
        }
    }
}
