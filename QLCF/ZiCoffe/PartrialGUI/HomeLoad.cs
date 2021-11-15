using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace ZiCoffe.PartrialGUI
{
    public partial class HomeLoad : Form
    {
        public HomeLoad()
        {
            InitializeComponent();
            timer1.Start();
            GetIP();
        }

        private void HomeLoad_Load(object sender, EventArgs e)
        {
            lbHours.Text= DateTime.Now.ToString("hh");
            lbMinutes.Text = DateTime.Now.ToString("mm");
            lbSeconds.Text = DateTime.Now.ToString("ss");
            lbDay.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
        }

        private void GetIP()
        {
            IPHostEntry host;
            string localIP = "Unknown";
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach(IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    localIP = ip.ToString();
                    lbLocation.Text = localIP;
                }
                    
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            HomeLoad_Load(this, new EventArgs());
        }
    }
}
