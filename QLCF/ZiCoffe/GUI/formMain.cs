using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZiCoffe.DAO;
using ZiCoffe.DTO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Globalization;
using System.Resources;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Collections;
using System.Data.SqlClient;
using System.Net;
using Quobject.SocketIoClientDotNet.Client;
using ZiCoffe.Items;
using System.Media;
using System.IO;

namespace ZiCoffe.GUI
{
    public partial class formMain : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public int x = 12;
        public int y = 204;
        public int x1 = 186;
        public int y1 = 213;
        public int count1 = 0;
        public int count2 = 0;
        public int beforeFullTable = 0;
        public int currentTabPageIndex = 0;

        public NumberFormatInfo localFormat = (NumberFormatInfo)NumberFormatInfo.CurrentInfo.Clone();
        public string soundTrackPath = null;
        public Stream streamOpen = null;
        public Stream streamClick = null;

        private EmployeesDTO currentAccount;

        public EmployeesDTO CurrentAccount
        {
            get { return currentAccount; }
            set { currentAccount = value; ChangeAccount(currentAccount.MaChucVu); }
        }

        public formMain(EmployeesDTO accountName)
        {
            if (Properties.Settings.Default.allowLoad)
            {
                Thread runInit = new Thread(new ThreadStart(runFormInitialize));
                runInit.Start();
                Thread.Sleep(7000);
            }
            
            localFormat.CurrencySymbol = Properties.Settings.Default.currencySymbol;
            localFormat.CurrencyPositivePattern = 3;
            localFormat.CurrencyDecimalDigits = 0;

            InitializeComponent();
            if (Properties.Settings.Default.greeting)
            {
                Welcome();
            }
            this.CurrentAccount = accountName;

            beforeFullTable = TableDAO.Instance.CountFullTable();
            timerLoadTable.Start();
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            LoadGlobal();
            ReLoad("first_Load", 0);

            pnlOptions.Hide();
            pnlAccountDropdown.Hide();
            pnlShortcutDropdown.Hide();
            pnlSelected.Hide();
            
            picMin.Visible = false;
            picMax.Visible = true;
        }

        private void LoadGlobal()
        {
            ChangeLanguage(Properties.Settings.Default.language);
            pnlToolbar.BackColor 
                = pnlTableControls.BackColor
                = pnlShortcutDropdown.BackColor
                = pnlAccountDropdown.BackColor
                = Properties.Settings.Default.currentThemeColor;
            pnlDropdown1.BackColor
                = pnlDropdown2.BackColor
                = Properties.Settings.Default.currentThemeColor;
            btnManagerment.BackColor 
                = btnAccount.BackColor
                = btnShortcutKey.BackColor 
                = Properties.Settings.Default.currentThemeColor;
            btnViewProfile.BackColor 
                = btnLogOut.BackColor
                = Properties.Settings.Default.currentThemeColor;
            btnSubAdd.BackColor 
                = btnSubPay.BackColor 
                = Properties.Settings.Default.currentThemeColor;

            lbTitle.Text = Properties.Resources.programNameDefault;
            lbVersion.Text = Properties.Resources.versionDefault;
            lbCompany.Text = Properties.Resources.copyrightDefault;

            pnlTitle.BackColor = Properties.Settings.Default.titleBackColor;
            lbTitle.ForeColor = Properties.Settings.Default.titleForeColor;
            pnlFooter.BackColor = Properties.Settings.Default.footerBackColor;

            lbCountTable.ForeColor 
                = lbCountTempTable.ForeColor 
                = lbCountFullTable.ForeColor 
                = lbPercent.ForeColor
                = lbVersion.ForeColor 
                = lbCompany.ForeColor 
                = Properties.Settings.Default.footerForeColor;

            btnAdd.BackColor 
                = btnPay.BackColor 
                = Properties.Settings.Default.typeBack2;
            btnAdd.ForeColor 
                = btnPay.ForeColor
                = Properties.Settings.Default.typeFore2;

            btnReload.BackColor
                = btnMoveTable.BackColor
                = btnGatherTable.BackColor
                = Properties.Settings.Default.typeBack1;
            btnReload.ForeColor
                = btnMoveTable.ForeColor
                = btnGatherTable.ForeColor
                = Properties.Settings.Default.typeFore1;

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

            if(Properties.Settings.Default.click)
            {
                streamClick = Properties.Resources.clickOK;
            }
            else
            {
                streamClick = null;
            }

            if (Properties.Settings.Default.soundTrack)
            {
                soundTrackPath = @"D:\\ZiCoffeeVer3\QLCF\\ZiCoffe\\Resources\\AnhTaBoEmRoiSoundtrack.wav";
            }
            else
            {
                soundTrackPath = null;
            }

            if (soundTrackPath != null)
            {
                wmpSoundTrack.Ctlcontrols.pause();
                wmpSoundTrack.URL = soundTrackPath;
                wmpSoundTrack.settings.setMode("loop", true);
                wmpSoundTrack.Ctlcontrols.play();
            }
            else
            {
                wmpSoundTrack.Ctlcontrols.stop();
            }
        }

        #region Method

        #region [Other]

        private void ChangeAccount(int positionID)
        {
            if (positionID == 1)
            {
                btnManagerment.Enabled = true;
                btnManagerment.BackColor = Properties.Settings.Default.typeBack1;
            }
            else
            {
                btnManagerment.Enabled = false;
                btnManagerment.BackColor = Properties.Settings.Default.typeBackOff;
                btnManagerment.Cursor = Cursors.No;
            }
            btnManagerment.Text += " (" + Properties.Settings.Default.usernameStaff + ")";
        }

        private void ConfigureTable(TableDTO item, FlowLayoutPanel currentLayout)
        {
            ButtonItems btnTable = new ButtonItems()
            {
                Width = Properties.Settings.Default.tableWidth,
                Height = Properties.Settings.Default.tableHeigh
            };
            btnTable.Text = item.TenBan + Environment.NewLine + (item.TrangThaiSuDung == 0 ? "Trống" : "Có Người");
            toolTipForButton.SetToolTip(btnTable, item.TenBan + " hiện đang " + (item.TrangThaiSuDung == 0 ? "trống" : "có người"));
            switch (item.TrangThaiSuDung)
            {
                case 0:
                    btnTable.BackColor = Properties.Settings.Default.tableBackColorTemp;
                    break;
                case 1:
                    btnTable.BackColor = Properties.Settings.Default.tableBackColorFull;
                    break;
                default: break;
            }
            btnTable.ForeColor = Properties.Settings.Default.tableForeColor;
            btnTable.FlatStyle = FlatStyle.Flat;
            btnTable.TabStop = false;
            btnTable.Tag = item;

            btnTable.MouseDown += btnTable_MouseDown;
            btnTable.ContextMenuStrip = cmsOptionsTable;
            currentLayout.Controls.Add(btnTable);
        }

        private void ShowBill(int tableID)
        {
            lstViewBill.Items.Clear();
            List<ShowBillDTO> billInfoList = ShowBillDAO.Instance.GetBill(tableID);
            int countLine = 0;
            foreach (ShowBillDTO item in billInfoList)
            {
                ListViewItem listViewItem = new ListViewItem(item.TenDichVu.ToString());
                listViewItem.SubItems.Add(item.SoLuong.ToString());
                listViewItem.SubItems.Add(item.DonGia.ToString("n0", localFormat));
                listViewItem.SubItems.Add(item.ThanhTien.ToString("n0", localFormat));
                lstViewBill.Items.Add(listViewItem);
                countLine++;
                if (countLine % 2 == 0)
                    listViewItem.BackColor = Color.White;
                else
                    listViewItem.BackColor = Color.LightBlue;
            }
        }

        private bool IsSelectTable(TableDTO selectedTable)
        {
            if (selectedTable == null)
            {
                MessageBox.Show("Vui lòng chọn bàn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void ReLoad(string loadString, int areaID)
        {
            switch (loadString)
            {
                case "134":
                    LoadMap();
                    LoadTempTableList();
                    LoadFullTableList();
                    break;
                default:
                    LoadMap();
                    LoadTempTableList();
                    LoadFullTableList();
                    LoadFooter();
                    break;
            }
        }
        
        private void MoveTable(TableDTO selectedTable)
        {
            int billID = BillDAO.Instance.GetBillID(selectedTable.MaBan);

            if (billID != -1)
            {
                TableDTO newTable = cbTempTable.SelectedItem as TableDTO;
                int newTableID = newTable.MaBan;
                if (BillDAO.Instance.UpdateMoveTable(newTableID, billID))
                {
                    string tableNameLeave = selectedTable.TenBan;
                    int areaNameLeave = selectedTable.MaKhuVuc;
                    string tableNameCome = newTable.TenBan;
                    int areaNameCome = newTable.MaKhuVuc;
                    
                    ReLoad("134", areaNameCome);
                    ShowBill(newTableID);

                    MessageBox.Show("Chuyển (" + tableNameLeave + " Khu vực " + areaNameLeave + ") đến (" + tableNameCome + " khu vực " + areaNameCome + ") thành công", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Chuyển Bàn thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int CountTable()
        {
            return TableDAO.Instance.CountTableTotal();
        }

        private int CountUsingTable()
        {
            return TableDAO.Instance.CountFullTable();
        }

        private int CountTempTable()
        {
            return CountTable() - CountUsingTable();
        }

        private double Percent()
        {
            return (double)CountUsingTable() / (double)CountTable() * 100;
        }

        private void ChangeLanguage(string cultureName)
        {
            CultureInfo culture = CultureInfo.CreateSpecificCulture(cultureName);
            ResourceManager rm = new ResourceManager("ZiCoffe.Lang.ResourceLang", typeof(formMain).Assembly);

            btnManagerment.Text = "    " + rm.GetString("manager", culture);
            btnAccount.Text = "    " + rm.GetString("account", culture);
            btnShortcutKey.Text = "    " + rm.GetString("shortcutkey", culture);
            btnViewProfile.Text = "    " + rm.GetString("view", culture);
            btnLogOut.Text = "    " + rm.GetString("exit", culture);
            btnAdd.Text = rm.GetString("add", culture);
            btnPay.Text = rm.GetString("pay", culture);
            btnSubAdd.Text = rm.GetString("add", culture);
            btnSubPay.Text = rm.GetString("pay", culture);
            btnMoveTable.Text = rm.GetString("movetable", culture);
            btnGatherTable.Text = rm.GetString("gathertable", culture);
            lbCountTable.Text = rm.GetString("totaltable", culture) + ": " + CountTable();
            lbCountFullTable.Text = rm.GetString("use", culture) + ": " + CountUsingTable();
            lbCountTempTable.Text = rm.GetString("temp", culture) + ": " + CountTempTable();
            lbPercent.Text = string.Format(rm.GetString("percent", culture) + ": {0} %", Percent());
        }

        public void Welcome()
        {
            string vocative = "";
            if(Properties.Settings.Default.sexStaff == 0)
            {
                if(Properties.Settings.Default.positionStaff == 1)
                {
                    vocative = "Hi Sir!";
                }
                else
                {
                    vocative = "Hello Mr. " + Properties.Settings.Default.usernameStaff + "!";
                }
            }
            else
            {
                if (Properties.Settings.Default.positionStaff == 1)
                {
                    vocative = "Hi Madam!";
                }
                else
                {
                    vocative = "Hello Ms. " + Properties.Settings.Default.usernameStaff + "!";
                }
            }

            SpeechSynthesizer speaker = new SpeechSynthesizer();
            speaker.Volume = Properties.Settings.Default.speakerVolumn;
            speaker.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Child);
            speaker.Rate = Properties.Settings.Default.speakerRate;
            speaker.Speak(vocative + Properties.Settings.Default.welcome);
        }

        private void runFormInitialize()
        {
            Application.Run(new formInitialize());
        }

        #endregion

        #region [Load]

        private void LoadMap()
        {
            TabControl tabControl = new TabControl();
            tabControl.Dock = DockStyle.Fill;
            tabControl.SizeMode = TabSizeMode.Fixed;

            TabPage tpAll = new TabPage();
            tpAll.Text = "Tất cả bàn";
            tpAll.Tag = 0;
            tabControl.TabPages.Add(tpAll);
            LoadTableCurrentTab(tpAll);

            List<AreaDTO> areaList = AreaDAO.Instance.GetAreaList();
            foreach (AreaDTO ob in areaList)
            {
                TabPage tpArea = new TabPage();
                tpArea.Text = "Khu vực " + ob.TenKhuVuc;
                tpArea.Tag = ob.MaKhuVuc;
                tabControl.TabPages.Add(tpArea);
                LoadTableCurrentTab(tpArea);
            }

            tabControl.SelectTab(currentTabPageIndex);
            tabControl.Selecting += tcArea_Selecting;

            pnlMap.Controls.Clear();
            pnlMap.Controls.Add(tabControl);
        }

        private void LoadTableCurrentTab(TabPage curentTabPage)
        {
            FlowLayoutPanel flpnTable = new FlowLayoutPanel();
            flpnTable.AutoScroll = true;
            flpnTable.Dock = DockStyle.Fill;
            flpnTable.Controls.Clear();
            curentTabPage.Controls.Add(flpnTable);

            List<TableDTO> tableList = null;
            int areaID = Int32.Parse(curentTabPage.Tag.ToString());
            if (areaID == 0)
            {
                tableList = TableDAO.Instance.GetTableList();
            }
            else
            {
                tableList = TableDAO.Instance.GetTableListByArea(areaID);
            }
            
            foreach (TableDTO ob in tableList)
            {
                ConfigureTable(ob, flpnTable);
            }
        }

        private void LoadTempTableList()
        {
            List<TableDTO> tempTableList = TableDAO.Instance.GetTempTableList();
            cbTempTable.DataSource = tempTableList;
            cbTempTable.DisplayMember = "fullName";
        }

        private void LoadFullTableList()
        {
            List<TableDTO> fullTableList = TableDAO.Instance.GetFullTableList();
            cbFullTable.DataSource = fullTableList;
            cbFullTable.DisplayMember = "fullName";
        }

        private void LoadFooter()
        {
            lbCountTable.Text = "Tổng bàn: " + CountTable();
            lbCountFullTable.Text = "Đang sử dụng: " + CountUsingTable();
            lbCountTempTable.Text = "Trống: " + CountTempTable();
            lbPercent.Text = string.Format("Tỷ lệ: {0} %", Percent());
        }

        #endregion

        #endregion

        #region Event

        #region [Controller]

        private void tcArea_Selecting(object sender, EventArgs e)
        {
            TabPage tpArea = (sender as TabControl).SelectedTab;
            currentTabPageIndex = (sender as TabControl).TabPages.IndexOf(tpArea);
            LoadTableCurrentTab(tpArea);
        }

        private void btnTable_MouseDown(object sender, MouseEventArgs e)
        {
            TableDTO tableObject = ((sender as Button).Tag as TableDTO);
            int tableID = tableObject.MaBan;
            string tableName = TableDAO.Instance.GetTableName(tableID);
            string areaName = AreaDAO.Instance.GetAreaName(tableID);
            lbTableSelected.Text = "Bàn được chọn: " + tableName + " - khu vực " + areaName;
            lbTableSelected.Tag = tableObject;
            lbTableSelected.ForeColor = Color.Green;
            lstViewBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);

            if(e.Button == MouseButtons.Left)
            {
                if (streamClick != null)
                {
                    SoundPlayer sound = new SoundPlayer();
                    streamClick.Position = 0;
                    sound.Stream = null;
                    sound.Stream = streamClick;
                    sound.Play();
                }
                if (tableObject.TrangThaiSuDung != 0)
                {
                    picMax_Click(this, new EventArgs());
                }    
            }
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lbTableSelected.Tag != null)
            {
                orderToolStripMenuItem_Click(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Chưa có bàn nào được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (lbTableSelected.Tag != null)
            {
                thanhToánToolStripMenuItem_Click(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Chưa có bàn nào được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnMoveTable_Click(object sender, EventArgs e)
        {
            TableDTO selectedTable = lstViewBill.Tag as TableDTO;
            try
            {
                if (IsSelectTable(selectedTable))
                {
                    MoveTable(selectedTable);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGatherTable_Click(object sender, EventArgs e)
        {
            TableDTO selectedTable = lstViewBill.Tag as TableDTO;

            int sourceBillID = BillDAO.Instance.GetBillID(selectedTable.MaBan);
            if (sourceBillID == -1)
            {
                MessageBox.Show("Bàn được chọn trống", "Thông báo");
                return;
            }
            int destinationBillID = BillDAO.Instance.GetBillID((cbFullTable.SelectedItem as TableDTO).MaBan);

            List<GatherDTO> billInfoList = BillInfoDAO.Instance.GetBillInfo(sourceBillID);
            foreach (GatherDTO item in billInfoList)
            {
                BillInfoDAO.Instance.InsertBillInfo(destinationBillID, item.MaDichVu, item.SoLuong);
            }
            BillInfoDAO.Instance.DeleteBillInfo(sourceBillID);
            BillDAO.Instance.DeleteOrderCard(sourceBillID);
            BillDAO.Instance.DeleteBill(sourceBillID);

            string tableNameLeave = selectedTable.TenBan;
            int areaNameLeave = selectedTable.MaKhuVuc;
            string tableNameCome = (cbFullTable.SelectedItem as TableDTO).TenBan;
            int areaNameCome = (cbFullTable.SelectedItem as TableDTO).MaKhuVuc;
            MessageBox.Show("Gộp (" + tableNameLeave + " Khu vực: " + areaNameLeave + ") vào (" + tableNameCome + " khu vực: " + areaNameCome + ") thành công", "Thông báo");
            ReLoad("garther_Load", areaNameCome);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadMap();
        }

        private void picSetting_Click(object sender, EventArgs e)
        {
            formSetting f = new formSetting();
            f.ShowDialog();
            LoadGlobal();
            LoadMap();
        }

        #endregion

        #region [ShortcutKey]
        private void formMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode.ToString() == "V")
                btnViewProfile_Click(this, new EventArgs());
            if (e.Control && e.KeyCode.ToString() == "D")
                btnAdd_Click(this, new EventArgs());
            if (e.Control && e.KeyCode.ToString() == "Z")
                btnPay_Click(this, new EventArgs());
        }

        private void btnSubAdd_Click(object sender, EventArgs e)
        {
            btnAdd_Click(this, new EventArgs());
        }

        private void btnSubPay_Click(object sender, EventArgs e)
        {
            btnPay_Click(this, new EventArgs());
        }
        #endregion

        #region [Toolbar]
        private void btnManagerment_Click(object sender, EventArgs e)
        {
            pnlShortcutDropdown.Hide();
            pnlAccountDropdown.Hide();
            btnShortcutKey.Location = new Point(x, y);
            pnlDropdown2.Location = new Point(x1, y1);
            count1 = 0;
            count2 = 0;
            formAdmin2 f = new formAdmin2();
            f.currentAccount = currentAccount;
            if (this.WindowState == FormWindowState.Maximized)
            {
                f.WindowState = FormWindowState.Maximized;
            }
            this.Visible = false;
            f.ShowDialog();
            this.Show();
        }

        private void btnViewProfile_Click(object sender, EventArgs e)
        {
            formProfile f = new formProfile(currentAccount);
            f.ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region [Update]

        private void f_Updatestatus_after_deletemenu(object sender, EventArgs e)
        {
            if (lstViewBill.Tag != null)
                ShowBill((lstViewBill.Tag as TableDTO).MaBan);
            LoadMap();
        }

        private void f_Updatestatus_after_changemenu(object sender, EventArgs e)
        {
            if (lstViewBill.Tag != null)
                ShowBill((lstViewBill.Tag as TableDTO).MaBan);
        }

        private void f_Updatestatus_after_addmenu(object sender, EventArgs e)
        {
            if (lstViewBill.Tag != null)
                ShowBill((lstViewBill.Tag as TableDTO).MaBan);
        }

        private void f_Updatestatus_after_deletecategory(object sender, EventArgs e)
        {
            if (lstViewBill.Tag != null)
                ShowBill((lstViewBill.Tag as TableDTO).MaBan);
            LoadMap();
        }

        private void f_Updatestatus_after_chagecategory(object sender, EventArgs e)
        {
            if (lstViewBill.Tag != null)
                ShowBill((lstViewBill.Tag as TableDTO).MaBan);
        }

        private void f_Updatestatus_after_addcategory(object sender, EventArgs e)
        {
            if (lstViewBill.Tag != null)
                ShowBill((lstViewBill.Tag as TableDTO).MaBan);
        }

        #endregion

        #region [Effect]

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            wmpSoundTrack.Ctlcontrols.stop();
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

        private void btnAccount_Click(object sender, EventArgs e)
        {
            pnlShortcutDropdown.Hide();
            count2 = 0;

            if (count1 == 0)
            {
                pnlShortcutDropdown.Hide();
                pnlAccountDropdown.Show();
                btnShortcutKey.Location = new Point(x, pnlAccountDropdown.Location.Y + pnlAccountDropdown.Height + 5);
                pnlDropdown2.Location = new Point(x1, pnlAccountDropdown.Location.Y + pnlAccountDropdown.Height + 10);
                count1 = 1;
            }
            else
            {
                pnlAccountDropdown.Hide();
                btnShortcutKey.Location = new Point(x, y);
                pnlDropdown2.Location = new Point(x1, y1);
                count1 = 0;
            }
        }

        private void btnShortcutKey_Click(object sender, EventArgs e)
        {
            pnlAccountDropdown.Hide();
            btnShortcutKey.Location = new Point(x, y);
            pnlDropdown2.Location = new Point(x1, y1);
            count1 = 0;

            if (count2 == 0)
            {
                pnlAccountDropdown.Hide();
                btnShortcutKey.Location = new Point(x, y);
                pnlDropdown2.Location = new Point(x1, y1);
                pnlShortcutDropdown.Show();
                count2 = 1;
            }
            else
            {
                pnlShortcutDropdown.Hide();
                count2 = 0;
            }
        }

        private void btnManagerment_MouseHover(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            pnlSelected.Location = new Point(0, btn.Location.Y);
            pnlSelected.Show();

            btn.ForeColor = Color.FromArgb(0, 168, 255);
            string fileName = btn.Tag.ToString();
        }

        private void btnManagerment_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            pnlSelected.Hide();
            btn.ForeColor = Color.White;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pictureBox4.Visible = false;
            pictureBox2.Visible = true;
        }

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void formMain_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                formMain_Load(this, new EventArgs());
                ShowBill(0);
            }
        }

        private void picMin_Click(object sender, EventArgs e)
        {
            pnlOptions.Hide();
            picMax.Visible = true;
            picMin.Visible = false;
        }

        private void picMax_Click(object sender, EventArgs e)
        {
            pnlOptions.Show();
            picMax.Visible = false;
            picMin.Visible = true;
        }

        #endregion

        #region [Timer]

        private void timerLoadTable_Tick(object sender, EventArgs e)
        {
            int currentFullTable = TableDAO.Instance.CountFullTable();
            if (currentFullTable != beforeFullTable)
            {
                LoadMap();
                LoadFooter();
                LoadTempTableList();
                LoadFullTableList();
                ShowBill((lbTableSelected.Tag as TableDTO).MaBan);
                beforeFullTable = currentFullTable;
            }
        }

        #endregion

        #region [ToolStrip]

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableDTO tableSelected = (lbTableSelected.Tag as TableDTO);
            Form f = new formOrder(tableSelected, currentAccount);
            f.ShowDialog();
            this.Show();
        }

        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableDTO tableSelected = (lbTableSelected.Tag as TableDTO);
            if (tableSelected.TrangThaiSuDung != 0)
            {
                Form f = new formPay(tableSelected);
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Bàn được chọn trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void chuyểnBànToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gộpBànToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #endregion
    }
}
