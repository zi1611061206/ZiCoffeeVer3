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
    public partial class Material : Form
    {
        BindingSource materialSource = new BindingSource();

        public Material()
        {
            InitializeComponent();

            txbSearchMaterial.Text = Properties.Resources.searchTextDefault;
            dtgMaterial.DataSource = materialSource;
            LoadMaterial();
            MaterialBinding();
        }

        void LoadMaterial()
        {
            materialSource.DataSource = MaterialDAO.Instance.GetMaterial();
        }

        void MaterialBinding()
        {
            txbMaterialID.DataBindings.Add(new Binding("Text", dtgMaterial.DataSource, "Mã nguyên liệu", true, DataSourceUpdateMode.Never));
            txbMaterialName.DataBindings.Add(new Binding("Text", dtgMaterial.DataSource, "Tên nguyên liệu", true, DataSourceUpdateMode.Never));
            txbMaterialUnit.DataBindings.Add(new Binding("Text", dtgMaterial.DataSource, "Đơn vị", true, DataSourceUpdateMode.Never));
            nudMaterialAmount.DataBindings.Add(new Binding("Value", dtgMaterial.DataSource, "Số lượng", true, DataSourceUpdateMode.Never));
        }

        #region [E] Material
        private void txbSearchMaterial_Click(object sender, EventArgs e)
        {
            if (txbSearchMaterial.Text == "(Nhập kí tự cần tìm kiếm)")
            {
                txbSearchMaterial.Clear();
            }
        }

        private void picSearch_Click(object sender, EventArgs e)
        {
            string materialName = txbSearchMaterial.Text;
            materialSource.DataSource = MaterialDAO.Instance.SearchMaterial(materialName);
        }

        private void picNew_Click(object sender, EventArgs e)
        {
            txbMaterialID.Clear();
            txbMaterialName.Clear();
            txbMaterialUnit.Clear();
            nudMaterialAmount.Value = 0;
        }

        private void picAdd_Click(object sender, EventArgs e)
        {
            string materialName = txbMaterialName.Text;
            string unit = txbMaterialUnit.Text;
            int amount = (int)nudMaterialAmount.Value;

            try
            {
                if (MaterialDAO.Instance.AddMaterial(materialName, amount, unit))
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadMaterial();
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
            int materialID = Convert.ToInt32(txbMaterialID.Text);

            try
            {
                ImportDAO.Instance.DeleteImportInfo2(materialID);
                RecipeDAO.Instance.DeleteRecipe(materialID);
                if (MaterialDAO.Instance.DeleteMaterial(materialID))
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadMaterial();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void picEdit_Click(object sender, EventArgs e)
        {
            string materialName = txbMaterialName.Text;
            string unit = txbMaterialUnit.Text;
            int amount = (int)nudMaterialAmount.Value;
            int materialID = Convert.ToInt32(txbMaterialID.Text);

            try
            {
                if (MaterialDAO.Instance.ChangeMaterial(materialName, amount, unit, materialID))
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadMaterial();
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
            LoadMaterial();
        }

        private void txbSearchMaterial_KeyPress(object sender, KeyPressEventArgs e)
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
