using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZiCoffe.DAO;
using ZiCoffe.DTO;

namespace ZiCoffe.PartrialGUI
{
    public partial class Import : Form
    {
        public Import()
        {
            InitializeComponent();
        }

        private void Import_Load(object sender, EventArgs e)
        {
            LoadGlobal();
            LoadImport();
            pnlInput.Visible = false;
            LoadSupplierList(cbSupplier);
            LoadMaterialList(cbMaterial);
            btnPushUp.Visible = false;
            btnCancel.Visible = false;
        }

        private void LoadGlobal()
        {
            btnAdd.BackColor
                = btnCancel.BackColor
                = btnDelete.BackColor
                = btnPushUp.BackColor
                = btnRequest.BackColor
                = Properties.Settings.Default.typeBack2;
            btnAdd.ForeColor
                = btnCancel.ForeColor
                = btnDelete.ForeColor
                = btnPushUp.ForeColor
                = btnRequest.ForeColor
                = Properties.Settings.Default.typeFore2;
        }

        #region Method
        private void LoadImport()
        {
            dtgImport.DataSource = ImportDAO.Instance.GetImportCard();
        }

        private void LoadImportInfo(int importID)
        {
            dtgImportInfo.DataSource = ImportDAO.Instance.GetImportInfo(importID);
        }

        void LoadSupplierList(ComboBox cb)
        {
            cb.DataSource = SupplierDAO.Instance.GetSupplierList();
            cb.DisplayMember = "tennhacungcap";
        }

        void LoadMaterialList(ComboBox cb)
        {
            cb.DataSource = MaterialDAO.Instance.GetMaterialList();
            cb.DisplayMember = "tennguyenlieu";
        }
        #endregion

        #region Event
        private void dtgImport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            DataGridViewRow dataLine = dtgImport.Rows[e.RowIndex];
            int importID = int.Parse(dataLine.Cells[0].Value + "");
            LoadImportInfo(importID);
            txbID.Text = importID + "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlInput.Visible = true;
            lbID.Visible = false;
            txbID.Visible = false;
            panel2.Visible = false;
            grbImportInfo.Visible = false;
            picDelete.Visible = false;
            picAdd.Visible = true;
            lstTempImport.Items.Clear();
            lbSupplier.Visible = true;
            cbSupplier.Visible = true;
            btnPushUp.Visible = true;
            btnCancel.Visible = true;
        }

        private void picAdd_Click(object sender, EventArgs e)
        {
            if (cbSupplier.Text.Equals("") || cbSupplier.Text.Equals(null))
            {
                MessageBox.Show("Hãy chọn nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                grbImportInfo.Visible = true;
                nudPrice.Value = 0;
                nudAmount.Value = 0;
                btnRequest.Enabled = false;
                int importID = ImportDAO.Instance.GetMaxImportID() + 1;
                txbID.Text = importID.ToString();
                lbID.Visible = true;
                txbID.Visible = true;
                panel2.Visible = true;
                dtgImport.ClearSelection();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            pnlInput.Visible = true;
            lbID.Visible = true;
            txbID.Visible = true;
            panel2.Visible = true;
            grbImportInfo.Visible = false;
            picDelete.Visible = true;
            picAdd.Visible = false;
            lstTempImport.Items.Clear();
            lbSupplier.Visible = false;
            cbSupplier.Visible = false;
        }

        private void nudAmount_ValueChanged(object sender, EventArgs e)
        {
            if (nudAmount.Value == 0 || cbMaterial.Text.Equals("") || cbMaterial.Text.Equals(null))
            {
                btnRequest.Enabled = false;
            }
            else
            {
                btnRequest.Enabled = true;
            }
        }

        private void picDelete_Click(object sender, EventArgs e)
        {
            if (txbID.Text.Equals(null) || txbID.Text.Equals(""))
            {
                MessageBox.Show("Hãy chọn phiếu nhập cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa phiếu nhập này chứ", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.No)
                {
                    ImportDAO.Instance.DeleteImportInfo(int.Parse(txbID.Text));
                    ImportDAO.Instance.DeleteImport(int.Parse(txbID.Text));
                    LoadImport();
                }
            }
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lstTempImport.Items)
            {
                if (int.Parse(item.SubItems[4].Text) == (cbMaterial.SelectedItem as MaterialDTO).MaNguyenLieu)
                {
                    int amount = int.Parse(item.SubItems[2].Text);
                    amount += int.Parse(nudAmount.Value.ToString());
                    item.SubItems[2].Text = amount + "";
                    return;
                }
            }
            ListViewItem tempLine = new ListViewItem(txbID.Text);
            tempLine.SubItems.Add((cbMaterial.SelectedItem as MaterialDTO).TenNguyenLieu);
            tempLine.SubItems.Add(nudAmount.Value + "");
            tempLine.SubItems.Add(nudPrice.Value + "");
            tempLine.SubItems.Add((cbMaterial.SelectedItem as MaterialDTO).MaNguyenLieu + "");
            lstTempImport.Items.Add(tempLine);
        }

        private void btnPushUp_Click(object sender, EventArgs e)
        {
            if (lstTempImport.Items.Count == 0)
            {
                MessageBox.Show("Không có gì trong phiếu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            try
            {
                //Thêm phiếu nhập
                ImportDAO.Instance.AddImport((cbSupplier.SelectedItem as SupplierDTO).MaNhaCungCap);
                //Thêm chi tiết phiếu nhập
                foreach (ListViewItem item in lstTempImport.Items)
                {
                    ImportDAO.Instance.AddImportInfo(int.Parse(item.Text), int.Parse(item.SubItems[4].Text), int.Parse(item.SubItems[2].Text), float.Parse(item.SubItems[3].Text));
                }
                LoadImport();
                LoadImportInfo(int.Parse(txbID.Text));
                int lastRow = dtgImport.Rows.Count - 1;
                dtgImport.ClearSelection();
                dtgImport.Rows[lastRow].Selected = true;
                lstTempImport.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dtgImport_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Delete")
            {
                picDelete_Click(this, new EventArgs());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lstTempImport.Items.Clear();
            pnlInput.Visible = false;
            btnCancel.Visible = false;
            btnPushUp.Visible = false;
        }
        #endregion
    }
}
