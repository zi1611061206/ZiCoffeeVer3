using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
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
    public partial class formPay : Form
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
        public float tax = 10;
        public TableDTO choosingTable = null;
        public int billID = 0;
        public VoucherDTO voucherApplied = null;
        public DiscountDTO discountApplied = null;

        public formPay(TableDTO choosingTable)
        {
            this.choosingTable = choosingTable;
            billID = BillDAO.Instance.GetBillID(this.choosingTable.MaBan);

            localFormat.CurrencySymbol = Properties.Settings.Default.currencySymbol;
            localFormat.CurrencyPositivePattern = 3;
            localFormat.CurrencyDecimalDigits = 0;

            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void formPay_Load(object sender, EventArgs e)
        {
            txbVoucherEnter.Focus();
            LoadGlobal();
            LoadVoucher();
            ShowButtonApply();
            LoadDiscount();
            ShowBill(choosingTable.MaBan);
            Calculate();
        }

        private void LoadVoucher()
        {
            string voucherID = BillDAO.Instance.GetVoucher(billID);
            if(voucherID!="")
            {
                txbVoucherEnter.Text = voucherID;
                txbVoucherEnter.ReadOnly = true;
                txbVoucherContent.BackColor = Color.LightYellow;
                txbVoucherContent.Text = "Voucher đã được áp dụng";
            }
            ShowButtonApply();
        }

        private void LoadDiscount()
        {
            List<DiscountDTO> discountList = DiscountDAO.Instance.GetDiscountAvailableList();
            fpnlDiscountContent.Controls.Clear();
            foreach (DiscountDTO ob in discountList)
            {
                ConfigureDiscount(ob);
            }
        }

        private void ConfigureDiscount(DiscountDTO ob)
        {
            RadioButton rdDiscount = new RadioButton()
            {
                Size = new Size(fpnlDiscountContent.Width - 30, 0),
                MinimumSize = new Size(fpnlDiscountContent.Width - 30, 0),
                AutoSize = true,
                Text = $"{ob.NoiDung} \n {ob.GiaTri}%",
                Checked = false
            };
            rdDiscount.Tag = ob;
            rdDiscount.Click += rdDiscount_Click;
            fpnlDiscountContent.Controls.Add(rdDiscount);
        }

        private void rdDiscount_Click(object sender, EventArgs e)
        {
            ckbDiscount.Checked = true;
            discountApplied = ((sender as RadioButton).Tag as DiscountDTO);
            Calculate();
        }

        private void Calculate()
        {
            float total = 0;
            float.TryParse(txbTotal.Text, NumberStyles.Number | NumberStyles.AllowCurrencySymbol, CultureInfo.CurrentCulture, out total);
            float vat = total * tax / 100;

            txbVAT.Text = vat.ToString("n0", localFormat);
            float totalAfterVAT = total + vat;
            txbTotalAfterVAT.Text = totalAfterVAT.ToString("n0", localFormat);
            //choi tam thoi
            string voucherID = BillDAO.Instance.GetVoucher(billID);
            float voucher = 0;
            if(voucherID!="")
            {
                VoucherDTO voucherInfo = VoucherDAO.Instance.GetVoucher(voucherID);
                switch(voucherInfo.MaLoai)
                {
                    case 2: 
                        voucher = voucherInfo.GiaTri;
                        break;
                    case 3:
                        voucher = totalAfterVAT * voucherInfo.GiaTri / 100;
                        break;
                    default: break;
                }
            }
            txbVoucher.Text = voucher.ToString("n0", localFormat);
            float discount = discountApplied == null ? 0 : totalAfterVAT * discountApplied.GiaTri / 100;
            txbDiscount.Text = discount.ToString("n0", localFormat);

            float totalFinal = totalAfterVAT - voucher - discount;
            txbFinalTotal.Text = totalFinal.ToString("n0", localFormat);

            try
            {
                if (txbCash.Text != null)
                {
                    float cash = (float)Convert.ToDouble(txbCash.Text);
                    float surplus = cash == 0 ? 0 : (cash - totalFinal);
                    txbSurplus.Text = surplus.ToString("n0", localFormat);
                }
            }
            catch
            {
                txbCash.Text = "0";
                txbCash.SelectAll();
            }
        }

        private void ShowBill(int tableID)
        {
            lstViewBill.Items.Clear();
            double total = 0f;
            List<ShowBillDTO> billInfoList = ShowBillDAO.Instance.GetBill(tableID);
            int countLine = 0;
            foreach (ShowBillDTO item in billInfoList)
            {
                ListViewItem listViewItem = new ListViewItem(item.TenDichVu.ToString());
                listViewItem.SubItems.Add(item.SoLuong.ToString());
                listViewItem.SubItems.Add(item.DonGia.ToString("n0", localFormat));
                listViewItem.SubItems.Add(item.ThanhTien.ToString("n0", localFormat));
                lstViewBill.Items.Add(listViewItem);
                total += (float)item.ThanhTien;
                countLine++;
                if (countLine % 2 == 0)
                    listViewItem.BackColor = Color.White;
                else
                    listViewItem.BackColor = Color.LightBlue;
            }
            txbTotal.Text = total.ToString("n0", localFormat);
        }

        private void LoadGlobal()
        {
            ChangeLanguage(Properties.Settings.Default.language);
            txbFinalTotal.BackColor = Color.FromName("Lime");
            txbTotal.BackColor
                = txbVAT.BackColor
                = txbTotalAfterVAT.BackColor
                = txbVoucher.BackColor
                = txbDiscount.BackColor
                = txbSurplus.BackColor
                = Color.FromName("ActiveCaption");
            txbTotal.ForeColor = Color.Black;
            txbVAT.ForeColor = Color.DarkGreen;
            txbTotalAfterVAT.ForeColor = Color.Black;
            txbVoucher.ForeColor = Color.FromArgb(192, 0, 0);
            txbDiscount.ForeColor = Color.FromArgb(192, 0, 0);
            txbFinalTotal.ForeColor = Color.Blue;
            txbSurplus.ForeColor = Color.Black;

            pnlTitle.BackColor = Properties.Settings.Default.titleBackColor;
            lbTitle.ForeColor = Properties.Settings.Default.titleForeColor;
            btnCalculator.BackColor
                = btnCancel.BackColor
                = btnPay.BackColor
                = btnTempPrint.BackColor
                = btnVoucherApply.BackColor
                = Properties.Settings.Default.typeBack2;
            btnCalculator.ForeColor
                = btnCancel.ForeColor
                = btnPay.ForeColor
                = btnTempPrint.ForeColor
                = btnVoucherApply.ForeColor
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

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            try
            {
                Process process = new Process();
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = "/c start calc";
                process.StartInfo.UseShellExecute = false;
                process.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            /* Cách sử dụng cmd trong c#
            // khai bao lop thu vien
            using System.Diagnostics;

            // khoi tao tien trinh
            Process process = new Process();

            // thiet lap thong so tien trinh
            process.StartInfo.FileName = "cmd.exe"; // đường dẫn chương trình
            process.StartInfo.Arguments = "/k {duong dan file cmd/bat hoac lenh cmd}"; // tham so /c (thực hiện lệnh và tắt ctr chạy) /k (giữ lại ctr chạy)
            process.StartInfo.UseShellExecute = false; // tat giao dien
            process.StartInfo.CreateNoWindow = true; // tat tao cua so moi
            process.StartInfo.RedirectStandardOutput = true; // xuat du lieu tieu chuan
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden; // an cua so

            // chay tien trinh
            process.Start();

            // doc du lieu tra lai cua chuong trinh
            // Stream data = process.StandardOutput.BaseStream;
            */
        }

        private void txbVoucherEnter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (String.IsNullOrEmpty(txbVoucherEnter.Text))
                {
                    txbVoucherContent.BackColor = Color.FromName("Control");
                    txbVoucherContent.ForeColor = Color.Red;
                    txbVoucherContent.Text = "Mã không hợp lệ";
                }
                else
                {
                    string voucherID = txbVoucherEnter.Text;
                    VoucherDTO voucher = VoucherDAO.Instance.GetVoucher(voucherID);
                    if (voucher == null)
                    {
                        txbVoucherContent.BackColor = Color.FromName("Control");
                        txbVoucherContent.ForeColor = Color.Red;
                        txbVoucherContent.Text = "Mã không tồn tại";
                    }
                    else
                    {
                        if (voucher.TrangThai==1)
                        {
                            txbVoucherContent.BackColor = Color.FromName("Control");
                            txbVoucherContent.ForeColor = Color.Red;
                            txbVoucherContent.Text = $"Mã này đã được sử dụng";
                        }
                        else if (DateTime.Compare(DateTime.Today, voucher.NgayBatDau.Date) < 0)
                        {
                            txbVoucherContent.BackColor = Color.FromName("Control");
                            txbVoucherContent.ForeColor = Color.Red;
                            txbVoucherContent.Text = $"Voucher không khả dụng lúc này \r\n{ voucher.NgayBatDau} \r\n{ voucher.NgayKetThuc} \r\n{voucher.NoiDung} \r\n{voucher.DieuKienToiThieu}";
                        }
                        else if (DateTime.Compare(DateTime.Today, voucher.NgayKetThuc.Date) > 0)
                        {
                            txbVoucherContent.BackColor = Color.FromName("Control");
                            txbVoucherContent.ForeColor = Color.Red;
                            txbVoucherContent.Text = $"Voucher đã hết hạn \r\n{voucher.NgayBatDau} \r\n{voucher.NgayKetThuc} \r\n{voucher.NoiDung} \r\n{voucher.DieuKienToiThieu}";
                        }
                        else if (voucher.DieuKienToiThieu > (float)Convert.ToDouble(txbTotal.Text))
                        {
                            txbVoucherContent.BackColor = Color.FromName("Control");
                            txbVoucherContent.ForeColor = Color.Red;
                            txbVoucherContent.Text = $"Hóa đơn của bạn chưa đủ điều kiện \r\n{voucher.NgayBatDau} \r\n{voucher.NgayKetThuc} \r\n{voucher.NoiDung} \r\n{voucher.DieuKienToiThieu}";
                        }
                        else
                        {
                            txbVoucherContent.BackColor = Color.FromName("Control");
                            txbVoucherContent.ForeColor = Color.DarkGreen;
                            txbVoucherContent.Text = voucher.NgayBatDau+"\r\n"+voucher.NgayKetThuc+"\r\n"+voucher.NoiDung+ "\r\n" + voucher.DieuKienToiThieu;
                            voucherApplied = voucher;
                            ShowButtonApply();
                        }
                    }
                }
            }
        }

        private void txbVoucherEnter_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txbVoucherEnter.Text))
            {
                txbVoucherContent.Clear();
                voucherApplied = null;
            }
            else
            {
                if(voucherApplied != null)
                {
                    txbVoucherContent.Clear();
                    voucherApplied = txbVoucherEnter.Text != voucherApplied.MaPhieu ? null: voucherApplied;
                }
            }
            ShowButtonApply();
        }

        private void ShowButtonApply()
        {
            if(voucherApplied == null)
            {
                btnVoucherApply.Visible = false;
            }
            else
            {
                btnVoucherApply.Visible = true;
            }
        }

        private void btnVoucherApply_Click(object sender, EventArgs e)
        {
            if(voucherApplied!=null)
            {
                if(VoucherDAO.Instance.ApplyVoucherToBill(voucherApplied.MaPhieu, billID))
                {
                    string message = VoucherDAO.Instance.UpdateVoucherStatus(voucherApplied.MaPhieu)?"Thành công":"Thất bại";
                    MessageBox.Show(this, message, "Thông báo", MessageBoxButtons.OK);
                    Calculate();
                    voucherApplied = null;
                    LoadVoucher();
                }
            }
        }

        private void ckbVAT_CheckStateChanged(object sender, EventArgs e)
        {
            if((sender as CheckBox).Checked)
            {
                tax = 10;
            }
            else
            {
                tax = 0;
            }
            Calculate();
        }

        private void txbCash_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void btnTempPrint_Click(object sender, EventArgs e)
        {
            //Đặt trình in
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();
            printDialog.Document = printDocument;
            printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(Document);
            //Chọn máy in
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                //Tiến hành in
                printDocument.Print();
            }
        }

        private void Document(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Courier New", 12, FontStyle.Regular);
            SolidBrush brush = new SolidBrush(Color.Black);
            float fontheight = Font.GetHeight();
            int startX = 10;
            int startY = 10;
            int offset = 50;

            graphics.DrawString("ZI Coffee Shop", new Font("Courier New", 18, FontStyle.Bold), brush, startX + 60, startY);
            graphics.DrawString("Nhân viên: " + Properties.Settings.Default.usernameStaff, font, brush, startX + 105, startY + offset);
            offset += (int)fontheight;
            graphics.DrawString("Thời gian: " + DateTime.Now.ToString(), font, brush, startX, startY + offset);
            offset += (int)fontheight + 30;
            graphics.DrawString("Tên đồ uống", font, brush, startX, startY + offset);
            graphics.DrawString("SL", font, brush, startX + 225, startY + offset);
            graphics.DrawString("Giá", font, brush, startX + 280, startY + offset);
            offset += (int)fontheight;
            graphics.DrawString("-----------------------------------", font, brush, startX, startY + offset);
            offset += (int)fontheight;
            foreach (ListViewItem item in lstViewBill.Items)
            {
                graphics.DrawString(item.Text, font, brush, startX, startY + offset);
                graphics.DrawString(item.SubItems[1].Text, font, brush, startX + 225, startY + offset);
                graphics.DrawString(item.SubItems[3].Text, font, brush, startX + 280, startY + offset);
                offset += (int)fontheight;
            }

            graphics.DrawString("-----------------------------------", font, brush, startX, startY + offset);
            offset += (int)fontheight + 5;
            
            graphics.DrawString("Thành tiền (VNĐ): ".PadRight(27) + txbTotal.Text, font, brush, startX, startY + offset);
            offset += (int)fontheight + 5;
            string taxStr = "Thuế VAT (" + tax + "%): ";
            graphics.DrawString(taxStr.PadRight(27) + txbVAT.Text, font, brush, startX, startY + offset);
            offset += (int)fontheight + 5;
            graphics.DrawString("Voucher/Coupon (VNĐ): ".PadRight(27) + txbVoucher.Text, font, brush, startX, startY + offset);
            offset += (int)fontheight + 5;
            graphics.DrawString("Khuyến mại (VNĐ): ".PadRight(27) + txbDiscount.Text, font, brush, startX, startY + offset);
            offset += (int)fontheight + 5;
            graphics.DrawString("Tổng (VNĐ): ".PadRight(27) + txbFinalTotal.Text, new Font("Courier New", 12, FontStyle.Bold), brush, startX, startY + offset);
            offset += (int)fontheight + 5;
            graphics.DrawString("Nhận của khách (VNĐ): ".PadRight(27) + txbCash.Text, font, brush, startX, startY + offset);
            offset += (int)fontheight + 5;
            graphics.DrawString("Hoàn lại (VNĐ): ".PadRight(27) + txbSurplus.Text, font, brush, startX, startY + offset);
            offset += (int)fontheight + 30;

            graphics.DrawString(Properties.Settings.Default.companyAddressBill1, font, brush, startX + 20, startY + offset);
            offset += (int)fontheight + 5;
            graphics.DrawString(Properties.Settings.Default.companyAddressBill2, font, brush, startX + 20, startY + offset);
            offset += (int)fontheight + 5;
            graphics.DrawString("ĐT: " + Properties.Settings.Default.companyPhone1, font, brush, startX + 20, startY + offset);
            offset += (int)fontheight + 10;
            graphics.DrawString("Hân hạnh được phục vụ quý khách!", new Font("Courier New", 14, FontStyle.Bold), brush, startX, startY + offset);
            offset += (int)fontheight + 5;
            graphics.DrawImage(Properties.Resources.logoinmain, startX + 130, startY + offset);

            font.Dispose();
            brush.Dispose();
            graphics.Dispose();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thanh toán?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }
            else if (MessageBox.Show("Bạn có muốn in hóa đơn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                btnTempPrint_Click(this, new EventArgs());
            }
            Pay();
            this.Close();
        }

        private void Pay()
        {
            int billID = BillDAO.Instance.GetBillID(choosingTable.MaBan);
            float total = float.Parse(txbTotal.Text);
            float totalAfterVAT = float.Parse(txbTotalAfterVAT.Text);
            float totalFinal = float.Parse(txbFinalTotal.Text);

            if (discountApplied != null)
            {
                int discoutID = discoutID = discountApplied.MaChuongTrinh;
                BillDAO.Instance.UpdateBill(total, tax, totalAfterVAT, discoutID, totalFinal, billID);
            }
            else
            {
                BillDAO.Instance.UpdateBillNoDiscount(total, tax, totalAfterVAT, totalFinal, billID);
            }
        }

        private void txbCash_Click(object sender, EventArgs e)
        {
            (sender as TextBox).SelectAll();
        }

        private void ckbDiscount_CheckStateChanged(object sender, EventArgs e)
        {
            if(!(sender as CheckBox).Checked)
            {
                foreach(Control control in fpnlDiscountContent.Controls)
                {
                    if(control is RadioButton)
                    {
                        (control as RadioButton).Checked = false;
                        discountApplied = null;
                        Calculate();
                    }
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
