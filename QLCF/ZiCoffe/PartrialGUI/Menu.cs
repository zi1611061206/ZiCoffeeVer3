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
using ZiCoffe.DAO;
using ZiCoffe.DTO;

namespace ZiCoffe.PartrialGUI
{
    public partial class Menu : Form
    {
        public Image defaultImage = Image.FromFile(Application.StartupPath + "\\Resources\\no_image.png");
        public string defaultImagePath = Application.StartupPath + "\\Resources\\no_image.png";

        BindingSource categorySource = new BindingSource();
        BindingSource menuSource = new BindingSource();

        public Menu()
        {
            InitializeComponent();

            txbSearchCategory.Text = Properties.Resources.searchTextDefault;
            dtgCategory.DataSource = categorySource;
            LoadCategory();
            CategoryBinding();

            txbSearchDrinks.Text = Properties.Resources.searchTextDefault;
            dtgMenu.DataSource = menuSource;
            LoadMenu(0);
            MenuBinding();
            LoadCategoryList(cbDrinksCategory);
            txbDrinksPath.Clear();
        }

        void LoadCategory()
        {
            categorySource.DataSource = CategoryDAO.Instance.GetCategory();
        }

        void CategoryBinding()
        {
            txbCategoryID.DataBindings.Add(new Binding("Text", dtgCategory.DataSource, "Mã danh mục", true, DataSourceUpdateMode.Never));
            txbCategoryName.DataBindings.Add(new Binding("Text", dtgCategory.DataSource, "Tên danh mục", true, DataSourceUpdateMode.Never));
        }

        void LoadMenu(int categoryID)
        {
            if (categoryID == 0)
            {
                menuSource.DataSource = MenuDAO.Instance.GetMenu();
            }
            else
            {
                menuSource.DataSource = MenuDAO.Instance.GetMenuByCategory(categoryID);
            }
            dtgMenu.Columns["Hình ảnh"].Visible = false;
        }

        void MenuBinding()
        {
            txbDrinksID.DataBindings.Add(new Binding("Text", dtgMenu.DataSource, "Mã", true, DataSourceUpdateMode.Never));
            txbDrinkName.DataBindings.Add(new Binding("Text", dtgMenu.DataSource, "Tên đồ uống", true, DataSourceUpdateMode.Never));
            cbDrinksCategory.DataBindings.Add(new Binding("Text", dtgMenu.DataSource, "Tên danh mục", true, DataSourceUpdateMode.Never));
            nudDrinksPrice.DataBindings.Add(new Binding("Value", dtgMenu.DataSource, "Giá bán", true, DataSourceUpdateMode.Never));
            txbDescription.DataBindings.Add(new Binding("Text", dtgMenu.DataSource, "Mô tả", true, DataSourceUpdateMode.Never));
            picDrink.DataBindings.Add(new Binding("Image", dtgMenu.DataSource, "Hình ảnh", true, DataSourceUpdateMode.Never));
        }

        void LoadCategoryList(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetCategoryList();
            cb.DisplayMember = "tendanhmuc";
        }

        byte[] ConvertImageToBytes(string imagePath)
        {
            if (String.IsNullOrEmpty(imagePath))
            {
                return null;
            }
            else
            {
                FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
                byte[] binaryArray = new byte[fs.Length];
                fs.Read(binaryArray, 0, Convert.ToInt32(fs.Length));
                fs.Close();
                return binaryArray;
            }
        }

        //

        private void txbCategoryID_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txbCategoryID.Text))
            {
                LoadMenu(Int32.Parse(txbCategoryID.Text));
            }
        }

        private void txbDrinksID_TextChanged(object sender, EventArgs e)
        {
            txbDrinksPath.Clear();
            if (!String.IsNullOrEmpty(txbDrinksID.Text))
            {
                if (MenuDAO.Instance.GetStatus(Int32.Parse(txbDrinksID.Text)))
                {
                    rdAvailable.Checked = true;
                }
                else
                {
                    rdOver.Checked = true;
                }
            }
        }

        private void txbSearchCategory_Click(object sender, EventArgs e)
        {
            (sender as TextBox).SelectAll();
        }

        private void txbSearchCategory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string categoryName = txbSearchCategory.Text;
                categorySource.DataSource = CategoryDAO.Instance.SearchCategory(categoryName);
            }
        }

        private void txbSearchMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string drinksName = txbSearchDrinks.Text;
                menuSource.DataSource = MenuDAO.Instance.SearchMenu(drinksName);
            }
        }

        bool mouseClicked = false;

        private void picResize_MouseDown(object sender, MouseEventArgs e)
        {
            mouseClicked = true;
        }

        private void picResize_MouseUp(object sender, MouseEventArgs e)
        {
            mouseClicked = false;
        }

        private void picResize_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseClicked)
            {
                this.pnlLeft.Width = picResize.Right + e.X;
            }
        }

        //

        private void picNew_Click(object sender, EventArgs e)
        {
            txbCategoryID.Clear();
            txbCategoryName.Clear();
        }

        private void picAdd_Click(object sender, EventArgs e)
        {
            try
            {
                AddCategory();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddCategory()
        {
            string categoryName = txbCategoryName.Text;

            bool success = false;
            if (CategoryDAO.Instance.AddCategory(categoryName))
            {
                success = true;
            }

            if (success)
            {
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCategory();
                LoadMenu(0);
                LoadCategoryList(cbDrinksCategory);
            }
            else
            {
                MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteCategory();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteCategory()
        {
            if (String.IsNullOrEmpty(txbCategoryID.Text))
            {
                MessageBox.Show("Hãy chọn một danh mục", "Thông báo");
                return;
            }
            int categoryID = Convert.ToInt32(txbCategoryID.Text);

            bool success = false;
            if (CategoryDAO.Instance.DeleteCategory(categoryID))
            {
                success = true;
            }

            if (success)
            {
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCategory();
                LoadMenu(0);
                LoadCategoryList(cbDrinksCategory);
            }
            else
            {
                MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picEdit_Click(object sender, EventArgs e)
        {
            try
            {
                EditCategory();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditCategory()
        {
            if (String.IsNullOrEmpty(txbCategoryID.Text))
            {
                MessageBox.Show("Hãy chọn một danh mục", "Thông báo");
                return;
            }
            string categoryName = txbCategoryName.Text;
            int categoryID = Convert.ToInt32(txbCategoryID.Text);

            bool success = false;
            if (CategoryDAO.Instance.ChangeCategory(categoryName, categoryID))
            {
                success = true;
            }

            if (success)
            {
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCategory();
                LoadMenu(categoryID);
                LoadCategoryList(cbDrinksCategory);
            }
            else
            {
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picReload_Click(object sender, EventArgs e)
        {
            LoadCategory();
        }

        //

        private void picNew2_Click(object sender, EventArgs e)
        {
            txbDrinksID.Clear();
            txbDrinkName.Clear();
            nudDrinksPrice.Value = 0;
            txbDescription.Clear();
            rdAvailable.Checked = true;

            txbDrinksPath.Text = defaultImagePath;
            picDrink.Image = defaultImage;
        }

        private void picAdd2_Click(object sender, EventArgs e)
        {
            try
            {
                AddDrinks();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddDrinks()
        {
            string drinksName = txbDrinkName.Text;
            float price = (float)nudDrinksPrice.Value;
            string description = txbDescription.Text;
            bool status = rdOver.Checked == true ? false : true;
            int categoryID = cbDrinksCategory.SelectedItem == null ? 1 : (cbDrinksCategory.SelectedItem as CategoryDTO).MaDanhMuc;
            byte[] image = String.IsNullOrEmpty(txbDrinksPath.Text) ? ConvertImageToBytes(defaultImagePath) : ConvertImageToBytes(txbDrinksPath.Text);

            bool success = false;
            if (MenuDAO.Instance.AddDrinks(drinksName, categoryID, price, image, description, status))
            {
                success = true;
            }

            if (success)
            {
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMenu(categoryID);
            }
            else
            {
                MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picDelete2_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteDrinks();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteDrinks()
        {
            if (String.IsNullOrEmpty(txbDrinksID.Text))
            {
                MessageBox.Show("Hãy chọn một dịch vụ", "Thông báo");
                return;
            }
            int drinksID = Convert.ToInt32(txbDrinksID.Text);
            int categoryID = (cbDrinksCategory.SelectedItem as CategoryDTO).MaDanhMuc;

            bool success = false;
            if (MenuDAO.Instance.DeleteDrinks(drinksID))
            {
                success = true;
            }

            if (success)
            {
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMenu(categoryID);
            }
            else
            {
                MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picEdit2_Click(object sender, EventArgs e)
        {
            try
            {
                EditDrinks();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditDrinks()
        {
            if (String.IsNullOrEmpty(txbDrinksID.Text))
            {
                MessageBox.Show("Hãy chọn một dịch vụ", "Thông báo");
                return;
            }
            string drinksName = txbDrinkName.Text;
            float price = (float)nudDrinksPrice.Value;
            string description = txbDescription.Text;
            bool status = rdOver.Checked == true ? false : true;
            int categoryID = (cbDrinksCategory.SelectedItem as CategoryDTO).MaDanhMuc;
            byte[] image = String.IsNullOrEmpty(txbDrinksPath.Text) ? null : ConvertImageToBytes(txbDrinksPath.Text);
            int drinksID = Convert.ToInt32(txbDrinksID.Text);

            bool success = false;
            if (image == null)
            {
                MenuDAO.Instance.ChangeDrinks2(drinksName, categoryID, price, drinksID, description, status);
                success = true;
            }
            else
            {
                MenuDAO.Instance.ChangeDrinks(drinksName, categoryID, price, image, drinksID, description, status);
                success = true;
            }

            if (success)
            {
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMenu(categoryID);
            }
            else
            {
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picReload2_Click(object sender, EventArgs e)
        {
            LoadMenu(0);
        }

        private void btnChooseDrinksImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string fileName = openFileDialog1.FileName;
            if (string.IsNullOrEmpty(fileName))
                return;
            try
            {
                Image drinksPicture = Image.FromFile(fileName);
                picDrink.Image = drinksPicture;
                txbDrinksPath.Text = fileName;
                if (txbDrinksID.Text != "")
                {
                    picEdit2_Click(this, new EventArgs());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelDrinksImage_Click(object sender, EventArgs e)
        {
            txbDrinksPath.Text = defaultImagePath;
            picDrink.Image = defaultImage;
            picEdit2_Click(this, new EventArgs());
        }
    }
}
