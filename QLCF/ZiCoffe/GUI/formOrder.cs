using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using ZiCoffe.DAO;
using ZiCoffe.DTO;
using ZiCoffe.Items;
using ZiCoffe.UserControls;
using System.Runtime.InteropServices;
using System.Media;
using System.Globalization;

namespace ZiCoffe.GUI
{
    public partial class formOrder : Form
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

        public NumberFormatInfo localFormat = (NumberFormatInfo)NumberFormatInfo.CurrentInfo.Clone();
        public TableDTO choosingTable = null;
        public EmployeesDTO currentAccount = null;
        public int currentTabPageIndex = 0;
        public const int marginToolTip = 10;

        public formOrder(TableDTO choosingTable, EmployeesDTO currentAccount)
        {
            localFormat.CurrencySymbol = Properties.Settings.Default.currencySymbol;
            localFormat.CurrencyPositivePattern = 3;
            localFormat.CurrencyDecimalDigits = 0;

            InitializeComponent();
            this.choosingTable = choosingTable;
            this.currentAccount = currentAccount;
            pnlCart.Width = 0;
        }

        private void formOrder_Load(object sender, EventArgs e)
        {
            LoadGlobal();
            txbSearchMenu.Text = Properties.Resources.searchTextDefault;
            LoadMenuOrder();
            lbCartAmount.Text = 0 + "";
        }

        private void LoadGlobal()
        {
            ChangeLanguage(Properties.Settings.Default.language);
            pnlTitle.BackColor = Properties.Settings.Default.titleBackColor;
            lbTitle.ForeColor = Properties.Settings.Default.titleForeColor;

            btnCartConfirm.BackColor 
                = btnCancel.BackColor
                = Properties.Settings.Default.typeBack2;
            btnCartConfirm.ForeColor
                = btnCancel.ForeColor
                = Properties.Settings.Default.typeFore2;

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

        private Image ConvertByteArrayToImage(byte[] hinhAnh)
        {
            using (MemoryStream memstr = new MemoryStream(hinhAnh))
            {
                Image img = Image.FromStream(memstr);
                return img;
            }
        }

        private void LoadMenuOrder()
        {
            TabPage tpAll = new TabPage();
            tpAll.Text = "Tất cả";
            tpAll.Tag = 0;
            tcMenu.TabPages.Add(tpAll);
            LoadDrinksCurrentTab(tpAll);

            List<CategoryDTO> categoryList = CategoryDAO.Instance.GetCategoryList();
            foreach (CategoryDTO ob in categoryList)
            {
                TabPage tpCategory = new TabPage();
                tpCategory.Text = ob.TenDanhMuc;
                tpCategory.Tag = ob.MaDanhMuc;
                tcMenu.TabPages.Add(tpCategory);
                LoadDrinksCurrentTab(tpCategory);
            }

            tcMenu.SelectTab(currentTabPageIndex);
            tcMenu.Selecting += tcMenu_Selecting;
        }

        private void LoadDrinksCurrentTab(TabPage curentTabPage)
        {
            FlowLayoutPanel flpnMenu = new FlowLayoutPanel();
            flpnMenu.AutoScroll = true;
            flpnMenu.Dock = DockStyle.Fill;
            flpnMenu.BackColor = Color.White;
            flpnMenu.Controls.Clear();
            curentTabPage.Controls.Add(flpnMenu);

            List<DrinksDTO> menuList = null;
            int categoryID = Int32.Parse(curentTabPage.Tag.ToString());
            if (categoryID == 0)
            {
                menuList = MenuDAO.Instance.GetAllDrinks();
            }
            else
            {
                if(categoryID == -1)
                {
                    if (!String.IsNullOrEmpty(txbSearchMenu.Text.ToString()))
                    {
                        string drinksName = txbSearchMenu.Text;
                        menuList = MenuDAO.Instance.SearchDrinks(drinksName);
                    }
                }
                else
                {
                    menuList = MenuDAO.Instance.GetDrinkListByCategory(categoryID);
                }
            }

            if(menuList != null)
            {
                foreach (DrinksDTO ob in menuList)
                {
                    ConfigureDrinksItem(ob, flpnMenu);
                }
            }
            
        }

        private void ConfigureDrinksItem(DrinksDTO item, FlowLayoutPanel currentLayout)
        {
            PanelItems pnlDrinks = new PanelItems()
            {
                Width = Properties.Settings.Default.drinksWidth,
                Height = Properties.Settings.Default.drinksHeigh,
                BackColor = Properties.Settings.Default.drinkBackColor
            };
            Label lbName = new Label()
            {
                ForeColor = Properties.Settings.Default.drinkForeColorName,
                Font = new Font("Arial", 12.0f, FontStyle.Bold),
                Dock = DockStyle.Bottom,
                MaximumSize = new System.Drawing.Size(pnlDrinks.Width, 0),
                AutoSize = true,
                Cursor = Cursors.Hand,
                Text = item.TenDichVu,
                Padding = new Padding(0, 3, 0, 3)
            };
            Label lbPrice = new Label()
            {
                ForeColor = Properties.Settings.Default.drinkForeColorPrice,
                Font = new Font("Arial", 10.0f, FontStyle.Italic),
                Dock = DockStyle.Bottom,
                Text = item.DonGia.ToString("c0", localFormat),
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
                BackColor = Color.White,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Cursor = Cursors.Hand,
                Image = ConvertByteArrayToImage(item.HinhAnh)
            };

            string status = item.TinhTrangSuDung == 0 ? "Hết" : "Còn";
            string info = $"Mã dịch vụ: {item.MaDichVu}" +
                $"\nMã danh mục: {item.MaDanhMuc}" +
                $"\nTên dịch vụ: {item.TenDichVu}" +
                $"\nĐơn giá: {item.DonGia.ToString("c0", localFormat)}" +
                $"\nMô tả: {item.MoTa}" +
                $"\nTinh trạng: {status}";
            ttDescription.SetToolTip(picImage, info);
            
            pnlDrinks.Controls.Add(picImage);
            pnlInfo.Controls.Add(lbName);
            pnlInfo.Controls.Add(lbPrice);
            pnlDrinks.Controls.Add(pnlInfo);

            pnlDrinks.TabStop = false;
            pnlDrinks.Tag = picImage.Tag = lbName.Tag = lbPrice.Tag = pnlInfo.Tag = item;

            switch (item.TinhTrangSuDung)
            {
                case 0:
                    pnlDrinks.BackColor = Color.Gray;
                    break;
                case 1:
                    pnlDrinks.BackColor = Properties.Settings.Default.drinkBackColor;
                    break;
                default: break;
            }

            picImage.MouseDown += picImage_MouseDown;
            lbName.Click += lbName_Click;

            currentLayout.Controls.Add(pnlDrinks);
        }

        private void AddDrink(DrinksDTO ob)
        {
            if (lstViewCart.Items.Count > 0)
            {
                foreach (ListViewItem currentItem in lstViewCart.Items)
                {
                    if (currentItem.SubItems[4].Text.Equals(ob.MaDichVu + ""))
                    {
                        int amount = Int32.Parse(currentItem.SubItems[1].Text);
                        double price = Convert.ToDouble(currentItem.SubItems[2].Text);
                        double cash = Convert.ToDouble(currentItem.SubItems[3].Text);
                        amount++;
                        cash = price * amount;
                        currentItem.SubItems[1].Text = amount + "";
                        currentItem.SubItems[3].Text = cash.ToString("n0", localFormat);
                        return;
                    }
                }
                ListViewItem newItem = new ListViewItem(ob.TenDichVu.ToString());
                newItem.SubItems.Add(1 + "");
                newItem.SubItems.Add(ob.DonGia.ToString("n0", localFormat));
                newItem.SubItems.Add(ob.DonGia.ToString("n0", localFormat));
                newItem.SubItems.Add(ob.MaDichVu.ToString());
                lstViewCart.Items.Add(newItem);
            }
            else
            {
                ListViewItem newItem = new ListViewItem(ob.TenDichVu.ToString());
                newItem.SubItems.Add(1 + "");
                newItem.SubItems.Add(ob.DonGia.ToString("n0", localFormat));
                newItem.SubItems.Add(ob.DonGia.ToString("n0", localFormat));
                newItem.SubItems.Add(ob.MaDichVu.ToString());
                lstViewCart.Items.Add(newItem);
            }
        }

        private void SubDrink(DrinksDTO ob)
        {
            if (lstViewCart.Items.Count > 0)
            {
                foreach (ListViewItem currentItem in lstViewCart.Items)
                {
                    if (currentItem.SubItems[4].Text.Equals(ob.MaDichVu + ""))
                    {
                        int amount = Int32.Parse(currentItem.SubItems[1].Text);
                        double price = Convert.ToDouble(currentItem.SubItems[2].Text);
                        double cash = Convert.ToDouble(currentItem.SubItems[3].Text);
                        amount--;
                        if(amount!=0)
                        {
                            cash = price * amount;
                            currentItem.SubItems[1].Text = amount + "";
                            currentItem.SubItems[3].Text = cash.ToString("n0", localFormat);
                        }
                        else
                        {
                            lstViewCart.Items.Remove(currentItem);
                        }
                        return;
                    }
                }
            }
        }

        private void LoadTotalBill()
        {
            int cartAmount = 0;
            double total = 0.0f;
            foreach (ListViewItem currentItem in lstViewCart.Items)
            {
                int amount = Int32.Parse(currentItem.SubItems[1].Text);
                double cash = Convert.ToDouble(currentItem.SubItems[3].Text);
                cartAmount += amount;
                total += cash;
            }
            lbCartAmount.Text = cartAmount + "";
            txbTotal.Text = total.ToString("c0", localFormat);
        }

        private void picImage_MouseDown(object sender, MouseEventArgs e)
        {

            PictureBox pic = sender as PictureBox;
            DrinksDTO ob = pic.Tag as DrinksDTO;

            if (streamClick != null)
            {
                SoundPlayer sound = new SoundPlayer();
                streamClick.Position = 0;
                sound.Stream = null;
                sound.Stream = streamClick;
                sound.Play();
            }
            if (ob.TinhTrangSuDung == 0)
                return;
            switch(e.Button)
            {
                case MouseButtons.Left:
                    AddDrink(ob);
                    LoadTotalBill();
                    break;
                case MouseButtons.Right:
                    SubDrink(ob);
                    LoadTotalBill();
                    break;
                default: break;
            }
        }

        private void lbName_Click(object sender, EventArgs e)
        {
            Label lb = sender as Label;
            DrinksDTO ob = lb.Tag as DrinksDTO;
            string status = ob.TinhTrangSuDung == 0 ? "Hết" : "Còn";
            string info = $"Mã dịch vụ: {ob.MaDichVu}" +
                $"\nMã danh mục: {ob.MaDanhMuc}" +
                $"\nTên dịch vụ: {ob.TenDichVu}" +
                $"\nĐơn giá: {ob.DonGia.ToString("c0", localFormat)}" +
                $"\nMô tả: {ob.MoTa}" +
                $"\nTinh trạng: {status}";
            MessageBoxItems.ShowMyMessage(ConvertByteArrayToImage(ob.HinhAnh), info);
        }

        private void tipButtons_Popup(object sender, PopupEventArgs e)
        {
            int image_wid = 2 * marginToolTip + Properties.Resources.information.Width;
            int image_hgt = 2 * marginToolTip + Properties.Resources.information.Height;

            int wid = e.ToolTipSize.Width + 2 * marginToolTip + image_wid;
            int hgt = e.ToolTipSize.Height;
            if (hgt < image_hgt) hgt = image_hgt;

            e.ToolTipSize = new Size(wid, hgt);
        }

        private void tipButtons_Draw(object sender, DrawToolTipEventArgs e)
        {
            // Draw the background and border.
            e.DrawBackground();
            e.DrawBorder();

            // Draw the image.
            e.Graphics.DrawImage(Properties.Resources.information, marginToolTip, marginToolTip);

            // Draw the text.
            using (StringFormat sf = new StringFormat())
            {
                sf.Alignment = StringAlignment.Near;
                sf.LineAlignment = StringAlignment.Center;

                int image_wid = 2 * marginToolTip + Properties.Resources.information.Width;

                Rectangle rect = new Rectangle(image_wid, 0, e.Bounds.Width - image_wid, e.Bounds.Height);
                e.Graphics.DrawString(e.ToolTipText, e.Font, Brushes.Green, rect, sf);
            }
        }

        private void tcMenu_Selecting(object sender, EventArgs e)
        {
            TabPage tpCategory = (sender as TabControl).SelectedTab;
            currentTabPageIndex = (sender as TabControl).TabPages.IndexOf(tpCategory);
            LoadDrinksCurrentTab(tpCategory);
        }

        private void picCart_Click(object sender, EventArgs e)
        {
            if(pnlCart.Width == 0)
            {
                pnlCart.Width = 430;
            }
            else
            {
                pnlCart.Width = 0;
            }
        }

        private void txbSearchMenu_TextChanged(object sender, EventArgs e)
        {
            TabPage resultTab = null;
            bool existTabPage = false;
            foreach (TabPage tab in tcMenu.TabPages)
            {
                if (tab.Text.Equals("Kết quả"))
                {
                    existTabPage = true;
                    resultTab = tab;
                }
            }

            if (existTabPage)
            {
                resultTab.Controls.Clear();
                currentTabPageIndex = tcMenu.TabPages.IndexOf(resultTab);
                tcMenu.SelectTab(resultTab);
                LoadDrinksCurrentTab(resultTab);
            }
            else
            {
                TabPage tpSearchResult = new TabPage();
                tpSearchResult.Text = "Kết quả";
                tpSearchResult.Tag = -1;

                tcMenu.TabPages.Add(tpSearchResult);
                currentTabPageIndex = tcMenu.TabPages.IndexOf(tpSearchResult);
                tcMenu.SelectTab(tpSearchResult);
                LoadDrinksCurrentTab(tpSearchResult);
            }
            txbSearchMenu.Focus();
        }

        private void txbSearchMenu_Click(object sender, EventArgs e)
        {
            if (txbSearchMenu.Text == "(Nhập kí tự cần tìm kiếm)")
            {
                txbSearchMenu.Clear();
            }
        }

        private void lbCartAmount_Click(object sender, EventArgs e)
        {
            picCart_Click(this, new EventArgs());
        }

        private void btnCartConfirm_Click(object sender, EventArgs e)
        {
            int billID = BillDAO.Instance.GetBillID(choosingTable.MaBan);

            if (billID == -1)
            {
                BillDAO.Instance.InsertBill();
                billID = BillDAO.Instance.GetMaxBillID();
                BillDAO.Instance.InsertOrderCard(choosingTable.MaBan, billID, Properties.Settings.Default.usernameStaff);
                foreach (ListViewItem listViewItem in lstViewCart.Items)
                {
                    BillInfoDAO.Instance.InsertBillInfo(billID, Int32.Parse(listViewItem.SubItems[4].Text), Int32.Parse(listViewItem.SubItems[1].Text));
                }
            }
            else
            {
                foreach (ListViewItem listViewItem in lstViewCart.Items)
                {
                    BillInfoDAO.Instance.InsertBillInfo(billID, Int32.Parse(listViewItem.SubItems[4].Text), Int32.Parse(listViewItem.SubItems[1].Text));
                }
            }
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

        private void ChangeLanguage(string cultureName)
        {
            CultureInfo culture = CultureInfo.CreateSpecificCulture(cultureName);
            ResourceManager rm = new ResourceManager("ZiCoffe.Lang.ResourceLang", typeof(formMain).Assembly);
        }

        private void lbTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
