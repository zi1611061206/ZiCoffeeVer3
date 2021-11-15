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
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZiCoffe.Items;

namespace ZiCoffe.GUI
{
    public partial class formSetting : Form
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

        public formSetting()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void formSetting_Load(object sender, EventArgs e)
        {
            pnlPicked.Hide();
            LoadGlobal();
            LoadCurrentSetting();
            lklTable_LinkClicked(lklTable, new LinkLabelLinkClickedEventArgs(this.lklTable.Links[0]));
            ShowNumbericUpDown(false, false);
        }

        private void LoadGlobal()
        {
            pnlTitle.BackColor = Properties.Settings.Default.titleBackColor;
            lbTitle.ForeColor = Properties.Settings.Default.titleForeColor;

            btnDefault.BackColor = btnSave.BackColor = btnCancel.BackColor = Properties.Settings.Default.typeBack1;
            btnDefault.ForeColor = btnSave.ForeColor = btnCancel.ForeColor = Properties.Settings.Default.typeFore1;

            pnlTheme1.BackColor = Properties.Settings.Default.theme1;
            pnlTheme2.BackColor = Properties.Settings.Default.theme2;
            pnlTheme3.BackColor = Properties.Settings.Default.theme3;
            pnlTheme4.BackColor = Properties.Settings.Default.theme4;
            pnlTheme5.BackColor = Properties.Settings.Default.theme5;

            (this as Form).BackColor
                = pnlColor.BackColor
                = pnlObject.BackColor
                = pnlSound.BackColor
                = pnlFooter.BackColor
                = Properties.Settings.Default.currentThemeColor;

            switch(Properties.Settings.Default.language)
            {
                case "vi-VN":
                    picEn.Size = new Size(45, 20);
                    picVi.Size = new Size(75, 50);
                    break;
                case "en-US":
                    picEn.Size = new Size(75, 50);
                    picVi.Size = new Size(45, 20);
                    break;
                default: break;
            }
            ChangeLanguage(Properties.Settings.Default.language);

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

        #region [Method]
        private void LoadCurrentSetting()
        {
            pnlTyleBack1.BackColor = Properties.Settings.Default.typeBack1;
            pnlTyleBack2.BackColor = Properties.Settings.Default.typeBack2;
            pnlTyleBack3.BackColor = Properties.Settings.Default.typeBack3;

            pnlTyleFore1.BackColor = Properties.Settings.Default.typeFore1;
            pnlTyleFore2.BackColor = Properties.Settings.Default.typeFore2;
            pnlTyleFore3.BackColor = Properties.Settings.Default.typeFore3;

            btnType1.BackColor = pnlTyleBack1.BackColor;
            btnType2.BackColor = pnlTyleBack2.BackColor;
            btnType3.BackColor = pnlTyleBack3.BackColor;

            btnType1.ForeColor = pnlTyleFore1.BackColor;
            btnType2.ForeColor = pnlTyleFore2.BackColor;
            btnType3.ForeColor = pnlTyleFore3.BackColor;

            ckbSoundGreeting.Checked = Properties.Settings.Default.greeting;
            ckbSoundBye.Checked = Properties.Settings.Default.bye;
            ckbSoundTrack.Checked = Properties.Settings.Default.soundTrack;
            ckbSoundClick.Checked = Properties.Settings.Default.click;
            ckbSoundAppearance.Checked = Properties.Settings.Default.appearance;
            ckbSoundNotification.Checked = Properties.Settings.Default.notification;
            ckbSelectAll.Checked = true;
            foreach(Control control in pnlSound.Controls)
            {
                if(control is CheckBox && !(control as CheckBox).Name.Equals("ckbSelectAll") && (control as CheckBox).Checked==false)
                {
                    ckbSelectAll.Checked = false;
                }
            }

            pnlTitleBack.BackColor = Properties.Settings.Default.titleBackColor;
            pnlTitleFore.BackColor = Properties.Settings.Default.titleForeColor;
            pnlFooterBack.BackColor = Properties.Settings.Default.footerBackColor;
            pnlFooterFore.BackColor = Properties.Settings.Default.footerForeColor;

            pnlTitleExam.BackColor = pnlTitleBack.BackColor;
            lbTitleExam.ForeColor = pnlTitleFore.BackColor;
            pnlFooterExam.BackColor = pnlFooterBack.BackColor;
            lbFooterExam.ForeColor = pnlFooterFore.BackColor;

            int tWidth = Properties.Settings.Default.tableWidth;
            int tHeight = Properties.Settings.Default.tableHeigh;
            int sWidth = Properties.Settings.Default.drinksWidth;
            int sHeight = Properties.Settings.Default.drinksHeigh;

            Color tBackTemp = Properties.Settings.Default.tableBackColorTemp;
            Color tBackFull = Properties.Settings.Default.tableBackColorFull;
            Color tFore = Properties.Settings.Default.tableForeColor;
            Color sBack = Properties.Settings.Default.drinkBackColor;
            Color sForeName = Properties.Settings.Default.drinkForeColorName;
            Color sForePrice = Properties.Settings.Default.drinkForeColorPrice;

            nudTableWidth.Value = tWidth;
            nudTableHeight.Value = tHeight;
            nudServiceWidth.Value = sWidth;
            nudServiceHeight.Value = sHeight;

            pnlTableBackTemp.BackColor = tBackTemp;
            pnlTableBackFull.BackColor = tBackFull;
            pnlTableFore.BackColor = tFore;
            pnlServiceBack.BackColor = sBack;
            pnlServiceForeName.BackColor = sForeName;
            pnlServicePrice.BackColor = sForePrice;

            LoadTableExam(tWidth, tHeight, tBackTemp, tBackFull, tFore);
            LoadServiceExam(sWidth, sHeight, sBack, sForeName, sForePrice);
        }

        private void ShowNumbericUpDown(bool tableShow, bool serviceShow)
        {
            if (tableShow)
            {
                nudTableWidth.Show();
                nudTableHeight.Show();
                nudServiceWidth.Hide();
                nudServiceHeight.Hide();
            }
            else if (serviceShow)
            {
                nudTableWidth.Hide();
                nudTableHeight.Hide();
                nudServiceWidth.Show();
                nudServiceHeight.Show();
            }
            else
            {
                nudTableWidth.Hide();
                nudTableHeight.Hide();
                nudServiceWidth.Hide();
                nudServiceHeight.Hide();
            }
        }

        public bool useStatus = false;

        private void LoadTableExam(int width, int height, Color backColorTemp, Color backColorFull, Color foreColor)
        {
            pnlTableExam.Controls.Clear();
            ButtonItems btnTable = new ButtonItems()
            {
                Width = width,
                Height = height
            };
            btnTable.Text = "Bàn 0" + Environment.NewLine + (useStatus == false ? "Trống" : "Có Người");
            switch (useStatus)
            {
                case false:
                    btnTable.BackColor = backColorTemp;
                    break;
                default:
                    btnTable.BackColor = backColorFull;
                    break;
            }
            btnTable.ForeColor = foreColor;
            btnTable.FlatStyle = FlatStyle.Flat;
            btnTable.TabStop = false;
            btnTable.Click += btnTable_Click;
            pnlTableExam.Controls.Add(btnTable);
        }

        private void LoadServiceExam(int width, int height, Color backColor, Color foreColorName, Color foreColorPrice)
        {
            pnlServiceExam.Controls.Clear();
            PanelItems pnlDrinks = new PanelItems()
            {
                Width = width,
                Height = height,
                BackColor = backColor
            };
            Label lbName = new Label()
            {
                ForeColor = foreColorName,
                Font = new Font("Arial", 12.0f, FontStyle.Bold),
                Dock = DockStyle.Bottom,
                MaximumSize = new System.Drawing.Size(pnlDrinks.Width, 0),
                AutoSize = true,
                Text = "Tên dịch vụ",
                Padding = new Padding(0, 3, 0, 3)
            };
            Label lbPrice = new Label()
            {
                ForeColor = foreColorPrice,
                Font = new Font("Arial", 10.0f, FontStyle.Italic),
                Dock = DockStyle.Bottom,
                Text = "0 VND",
                Padding = new Padding(0, 3, 0, 3)
            };
            Panel pnlInfo = new Panel()
            {
                Dock = DockStyle.Bottom,
                Height = lbName.Height + lbPrice.Height,
                AutoSize = true
            };
            PictureBoxItems picImage = new PictureBoxItems()
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White
            };

            picImage.Click += picImage_Click;

            pnlDrinks.Controls.Add(picImage);
            pnlInfo.Controls.Add(lbName);
            pnlInfo.Controls.Add(lbPrice);
            pnlDrinks.Controls.Add(pnlInfo);

            pnlDrinks.TabStop = false;

            pnlServiceExam.Controls.Add(pnlDrinks);
        }
        #endregion

        #region [Event]

        #region [E.Color]
        private void pnlTyleBack1_Click(object sender, EventArgs e)
        {
            Panel pnl = sender as Panel;
            if (cldPicker.ShowDialog() == DialogResult.OK)
            {
                pnl.BackColor = cldPicker.Color;
            }
        }

        private void pnlTyleBack1_BackColorChanged(object sender, EventArgs e)
        {
            btnType1.BackColor = pnlTyleBack1.BackColor;
        }

        private void pnlTyleFore1_BackColorChanged(object sender, EventArgs e)
        {
            btnType1.ForeColor = pnlTyleFore1.BackColor;
        }

        private void pnlTyleBack2_BackColorChanged(object sender, EventArgs e)
        {
            btnType2.BackColor = pnlTyleBack2.BackColor;
        }

        private void pnlTyleFore2_BackColorChanged(object sender, EventArgs e)
        {
            btnType2.ForeColor = pnlTyleFore2.BackColor;
        }

        private void pnlTyleBack3_BackColorChanged(object sender, EventArgs e)
        {
            btnType3.BackColor = pnlTyleBack3.BackColor;
        }

        private void pnlTyleFore3_BackColorChanged(object sender, EventArgs e)
        {
            btnType3.ForeColor = pnlTyleFore3.BackColor;
        }

        private void pnlTitleBack_BackColorChanged(object sender, EventArgs e)
        {
            pnlTitleExam.BackColor = pnlTitleBack.BackColor;
        }

        private void pnlTitleFore_BackColorChanged(object sender, EventArgs e)
        {
            lbTitleExam.ForeColor = pnlTitleFore.BackColor;
        }

        private void pnlFooterBack_BackColorChanged(object sender, EventArgs e)
        {
            pnlFooterExam.BackColor = pnlFooterBack.BackColor;
        }

        private void pnlFooterFore_BackColorChanged(object sender, EventArgs e)
        {
            lbFooterExam.ForeColor = pnlFooterFore.BackColor;
        }

        private void pnlTheme_Click(object sender, EventArgs e)
        {
            pnlPicked.Show();
            pnlColor.BackColor = pnlObject.BackColor = pnlSound.BackColor = pnlFooter.BackColor = (sender as Panel).BackColor;
            pnlPicked.Location = (sender as Panel).Location;
        }
        #endregion

        #region [E.Object]
        private void btnTable_Click(object sender, EventArgs e)
        {
            ShowNumbericUpDown(true, false);
        }

        private void picImage_Click(object sender, EventArgs e)
        {
            ShowNumbericUpDown(false, true);
        }

        private void pnlTableBackTemp_Click(object sender, EventArgs e)
        {
            switch ((sender as Panel).Name)
            {
                case "pnlTableBackTemp":
                    useStatus = false;
                    break;
                case "pnlTableBackFull":
                    useStatus = true;
                    break;
                default: break;
            }
            Panel pnl = sender as Panel;
            if (cldPicker.ShowDialog() == DialogResult.OK)
            {
                pnl.BackColor = cldPicker.Color;
            }
        }

        private void pnlServiceBack_Click(object sender, EventArgs e)
        {
            Panel pnl = sender as Panel;
            if (cldPicker.ShowDialog() == DialogResult.OK)
            {
                pnl.BackColor = cldPicker.Color;
            }
        }

        private void pnlTableBack_BackColorChanged(object sender, EventArgs e)
        {
            LoadTableExam((int)nudTableWidth.Value, (int)nudTableHeight.Value, pnlTableBackTemp.BackColor, pnlTableBackFull.BackColor, pnlTableFore.BackColor);
        }

        private void pnlServiceBack_BackColorChanged(object sender, EventArgs e)
        {
            LoadServiceExam((int)nudServiceWidth.Value, (int)nudServiceHeight.Value, pnlServiceBack.BackColor, pnlServiceForeName.BackColor, pnlServicePrice.BackColor);
        }

        private void lklTable_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if ((sender as LinkLabel).Name == "lklTable")
            {
                pnlTableExam.Show();
                pnlServiceExam.Hide();

                pnlTableOption.Show();
                pnlServiceOption.Hide();
            }
            else
            {
                pnlTableExam.Hide();
                pnlServiceExam.Show();

                pnlTableOption.Hide();
                pnlServiceOption.Show();
            }

        }
        #endregion

        #region [E.Sound]

        public SoundPlayer player = new SoundPlayer();
        public SpeechSynthesizer speaker = new SpeechSynthesizer();

        private void allCheckbox_MouseHover(object sender, EventArgs e)
        {
            speaker.Volume = Properties.Settings.Default.speakerVolumn;
            speaker.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Child);
            speaker.Rate = Properties.Settings.Default.speakerRate;
            switch ((sender as CheckBox).Name)
            {
                case "ckbSoundClick":
                    PlaySound(Properties.Resources.clickOK);
                    break;
                case "ckbSoundTrack":
                    break;
                case "ckbSoundAppearance":
                    PlaySound(Properties.Resources.open);
                    break;
                case "ckbSoundNotification":

                    break;
                case "ckbSoundGreeting":
                    speaker.Speak("Welcome to Coffee Shop Managerment. How are you ,today?");
                    break;
                case "ckbSoundBye":
                    speaker.Speak("Good bye. See you later");
                    break;
                default: break;
            }
        }

        private void allCheckbox_MouseLeave(object sender, EventArgs e)
        {
            player.Stop();
            player.Stream.Dispose();
            speaker.Pause();
            speaker.Dispose();
        }

        private void PlaySound(UnmanagedMemoryStream soundStream)
        {
            player.Stream = soundStream;
            player.Play();
        }

        #endregion

        #region [E.Controls]
        private void btnDefault_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Thao tác này sẽ đưa toàn bộ cài đặt về cài đặt gốc, bạn chắc chắn chứ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.No)
            {
                Properties.Settings.Default.typeBack1 = Color.FromArgb(34, 36, 49);
                Properties.Settings.Default.typeBack2 = Color.FromArgb(0, 168, 255);
                Properties.Settings.Default.typeBack3 = Color.FromArgb(78, 184, 206);
                Properties.Settings.Default.typeFore1 = Color.FromArgb(78, 184, 206);
                Properties.Settings.Default.typeFore2 = Color.White;
                Properties.Settings.Default.typeFore3 = Color.FromArgb(34, 36, 49);

                Properties.Settings.Default.greeting = true;
                Properties.Settings.Default.bye = true;
                Properties.Settings.Default.soundTrack = true;
                Properties.Settings.Default.click = true;
                Properties.Settings.Default.appearance = true;
                Properties.Settings.Default.notification = true;

                Properties.Settings.Default.tableWidth = 133;
                Properties.Settings.Default.tableHeigh = 133;
                Properties.Settings.Default.drinksWidth = 163;
                Properties.Settings.Default.drinksHeigh = 210;

                Properties.Settings.Default.titleBackColor = Color.FromArgb(0, 122, 204);
                Properties.Settings.Default.titleForeColor = Color.White;
                Properties.Settings.Default.footerBackColor = Color.FromArgb(0, 122, 204);
                Properties.Settings.Default.footerForeColor = Color.White;

                Properties.Settings.Default.tableBackColorTemp = Color.FromArgb(0, 168, 255);
                Properties.Settings.Default.tableBackColorFull = Color.Orange;
                Properties.Settings.Default.tableForeColor = Color.Black;

                Properties.Settings.Default.drinkBackColor = Color.Yellow;
                Properties.Settings.Default.drinkForeColorName = Color.Green;
                Properties.Settings.Default.drinkForeColorPrice = Color.Red;

                Properties.Settings.Default.currentThemeColor = pnlTheme1.BackColor;

                Properties.Settings.Default.language = "vi-VN";

                Properties.Settings.Default.Save();
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn lưu cài đặt này chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.No)
            {
                Properties.Settings.Default.typeBack1 = pnlTyleBack1.BackColor;
                Properties.Settings.Default.typeBack2 = pnlTyleBack2.BackColor;
                Properties.Settings.Default.typeBack3 = pnlTyleBack3.BackColor;
                Properties.Settings.Default.typeFore1 = pnlTyleFore1.BackColor;
                Properties.Settings.Default.typeFore2 = pnlTyleFore2.BackColor;
                Properties.Settings.Default.typeFore3 = pnlTyleFore3.BackColor;

                Properties.Settings.Default.greeting = ckbSoundGreeting.Checked;
                Properties.Settings.Default.bye = ckbSoundBye.Checked;
                Properties.Settings.Default.soundTrack = ckbSoundTrack.Checked;
                Properties.Settings.Default.click = ckbSoundClick.Checked;
                Properties.Settings.Default.appearance = ckbSoundAppearance.Checked;
                Properties.Settings.Default.notification = ckbSoundNotification.Checked;

                Properties.Settings.Default.tableWidth = (int)nudTableWidth.Value;
                Properties.Settings.Default.tableHeigh = (int)nudTableHeight.Value;
                Properties.Settings.Default.drinksWidth = (int)nudServiceWidth.Value;
                Properties.Settings.Default.drinksHeigh = (int)nudServiceHeight.Value;

                Properties.Settings.Default.titleBackColor = pnlTitleBack.BackColor;
                Properties.Settings.Default.titleForeColor = pnlTitleFore.BackColor;
                Properties.Settings.Default.footerBackColor = pnlFooterBack.BackColor;
                Properties.Settings.Default.footerForeColor = pnlFooterFore.BackColor;

                Properties.Settings.Default.tableBackColorTemp = pnlTableBackTemp.BackColor;
                Properties.Settings.Default.tableBackColorFull = pnlTableBackFull.BackColor;
                Properties.Settings.Default.tableForeColor = pnlTableFore.BackColor;

                Properties.Settings.Default.drinkBackColor = pnlServiceBack.BackColor;
                Properties.Settings.Default.drinkForeColorName = pnlServiceForeName.BackColor;
                Properties.Settings.Default.drinkForeColorPrice = pnlServicePrice.BackColor;

                Properties.Settings.Default.currentThemeColor = pnlFooter.BackColor;

                if(picVi.Height > picEn.Height)
                {
                    Properties.Settings.Default.language = "vi-VN";
                }
                else
                {
                    Properties.Settings.Default.language = "en-US";
                }

                Properties.Settings.Default.Save();
                this.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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

        private void ckbSelectAll_Click(object sender, EventArgs e)
        {
            bool checkAll = true;
            if (!(sender as CheckBox).Checked)
            {
                checkAll = false;
            }
            foreach (Control control in pnlSound.Controls)
            {
                if (control is CheckBox)
                {
                    (control as CheckBox).Checked = checkAll;
                }
            }
        }
        #endregion

        #region [E.Effect]
        private void btn_MouseHover(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Properties.Settings.Default.typeBack3;
            (sender as Button).ForeColor = Properties.Settings.Default.typeFore3;
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Properties.Settings.Default.typeBack1;
            (sender as Button).ForeColor = Properties.Settings.Default.typeFore1;
        }
        #endregion

        #endregion

        private void picVi_Click(object sender, EventArgs e)
        {
            switch((sender as PictureBox).Name)
            {
                case "picVi":
                    ChangeLanguage("vi-VN");
                    picEn.Size = new Size(45, 20);
                    picVi.Size = new Size(75, 50);
                    break;
                case "picEn":
                    ChangeLanguage("en-US");
                    picEn.Size = new Size(75, 50);
                    picVi.Size = new Size(45, 20);
                    break;
                default: break;
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
