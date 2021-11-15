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

namespace ZiCoffe.PartrialGUI
{
    public partial class Supplier : Form
    {
        BindingSource supplierSource = new BindingSource();

        public Supplier()
        {
            InitializeComponent();

            txbSearchSupplier.Text = Properties.Resources.searchTextDefault;
            dtgSupplier.DataSource = supplierSource;
            LoadSupplier();
            SupplierBinding();
        }

        void LoadSupplier()
        {
            supplierSource.DataSource = SupplierDAO.Instance.GetSupplier();
        }

        void SupplierBinding()
        {
            txbSupplierID.DataBindings.Add(new Binding("Text", dtgSupplier.DataSource, "Mã", true, DataSourceUpdateMode.Never));
            txbSupplierName.DataBindings.Add(new Binding("Text", dtgSupplier.DataSource, "Tên nhà cung cấp", true, DataSourceUpdateMode.Never));
            txbSupplierAddress.DataBindings.Add(new Binding("Text", dtgSupplier.DataSource, "Địa chỉ", true, DataSourceUpdateMode.Never));
            txbSupplierPhone.DataBindings.Add(new Binding("Text", dtgSupplier.DataSource, "SĐT", true, DataSourceUpdateMode.Never));
            txbSupplierEmail.DataBindings.Add(new Binding("Text", dtgSupplier.DataSource, "Email", true, DataSourceUpdateMode.Never));
        }

        #region [E] Supplier
        private void txbSearchSupplier_Click(object sender, EventArgs e)
        {
            if(txbSearchSupplier.Text== "(Nhập kí tự cần tìm kiếm)")
            {
                txbSearchSupplier.Clear();
            }
        }

        private void picSearch_Click(object sender, EventArgs e)
        {
            string supplierName = txbSearchSupplier.Text;
            supplierSource.DataSource = SupplierDAO.Instance.SearchSupplier(supplierName);
        }

        private void picNew_Click(object sender, EventArgs e)
        {
            txbSupplierID.Clear();
            txbSupplierName.Clear();
            txbSupplierAddress.Clear();
            txbSupplierPhone.Clear();
            txbSupplierEmail.Clear();
        }

        private void picAdd_Click(object sender, EventArgs e)
        {
            string supplierName = txbSupplierName.Text;
            string address = txbSupplierAddress.Text;
            string phone = txbSupplierPhone.Text;
            string email = txbSupplierEmail.Text;

            try
            {
                if (SupplierDAO.Instance.AddSupplier(supplierName, address, phone, email))
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSupplier();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void picDelete_Click(object sender, EventArgs e)
        {
            int supplierID = Convert.ToInt32(txbSupplierID.Text);
            try
            {
                ImportDAO.Instance.DeleteImport2(supplierID);
                if (SupplierDAO.Instance.DeleteSupplier(supplierID))
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSupplier();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void picEdit_Click(object sender, EventArgs e)
        {
            string supplierName = txbSupplierName.Text;
            string address = txbSupplierAddress.Text;
            string phone = txbSupplierPhone.Text;
            string email = txbSupplierEmail.Text;
            int supplierID = Convert.ToInt32(txbSupplierID.Text);

            try
            {
                if (SupplierDAO.Instance.ChangeSupplier(supplierName, address, phone, email, supplierID))
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSupplier();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void picReload_Click(object sender, EventArgs e)
        {
            LoadSupplier();
        }

        private void txbSearchSupplier_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                picSearch_Click(this, new EventArgs());
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
