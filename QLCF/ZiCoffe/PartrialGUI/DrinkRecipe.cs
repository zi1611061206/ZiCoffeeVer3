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
    public partial class DrinkRecipe : Form
    {
        public DrinkRecipe()
        {
            InitializeComponent();
        }

        private void DrinkRecipe_Load(object sender, EventArgs e)
        {
            LoadGlobal();
            pnlInput.Visible = false;
            pnlStep2.Visible = false;
            LoadRecipeList();
            LoadServiceIntoCb(cbMenu);
            LoadMaterialIntoCb(cbMaterial);
            LoadRecipeListFilterIntoCb(cbRecipe);
        }

        private void LoadGlobal()
        {
            btnAdd.BackColor
                = btnCancel.BackColor
                = btnPushUp.BackColor
                = btnRequest.BackColor
                = Properties.Settings.Default.typeBack2;
            btnAdd.ForeColor
                = btnCancel.ForeColor
                = btnPushUp.ForeColor
                = btnRequest.ForeColor
                = Properties.Settings.Default.typeFore2;
        }

        #region Method
        private void LoadRecipeList()
        {
            lstRecipe.Items.Clear();
            List<RecipeDTO> recipeList = RecipeDAO.Instance.GetRecipeList();
            int countLine = 0;
            foreach (RecipeDTO item in recipeList)
            {
                ListViewItem recipe = new ListViewItem(item.TenDichVu.ToString());
                recipe.SubItems.Add(item.TenNguyenLieu.ToString());
                recipe.SubItems.Add(item.SoLuongPha.ToString());
                recipe.SubItems.Add(item.SoLuongTon.ToString());
                lstRecipe.Items.Add(recipe);
                countLine++;
                if (countLine % 2 == 0)
                    recipe.BackColor = Color.White;
                else
                    recipe.BackColor = Color.LightBlue;
            }
        }

        private void LoadRecipeFilter(int drinksID)
        {
            lstRecipe.Items.Clear();
            List<RecipeDTO> recipeList = RecipeDAO.Instance.GetRecipeFilter(drinksID);
            foreach (RecipeDTO item in recipeList)
            {
                ListViewItem recipe = new ListViewItem(item.TenDichVu.ToString());
                recipe.SubItems.Add(item.TenNguyenLieu.ToString());
                recipe.SubItems.Add(item.SoLuongPha.ToString());
                recipe.SubItems.Add(item.SoLuongTon.ToString());
                lstRecipe.Items.Add(recipe);
            }
        }

        private void LoadMaterialIntoCb(ComboBox cb)
        {
            cb.DataSource = MaterialDAO.Instance.GetMaterialList();
            cb.DisplayMember = "tennguyenlieu";
        }

        private void LoadServiceIntoCb(ComboBox cb)
        {
            cb.DataSource = MenuDAO.Instance.GetServiceList();
            cb.DisplayMember = "tendichvu";
        }

        private void LoadRecipeListFilterIntoCb(ComboBox cb)
        {
            cb.DataSource = MenuDAO.Instance.GetServiceList();
            cb.DisplayMember = "tendichvu";
        }
        #endregion

        #region Event
        private void pnlInput_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlInput.Visible == false)
            {
                btnCancel.Visible = btnPushUp.Visible = false;
            }
            else
            {
                btnCancel.Visible = btnPushUp.Visible = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlInput.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lstTempRecipe.Items.Clear();
            pnlInput.Visible = false;
            pnlStep2.Visible = false;
        }

        private void cbMenu_SelectionChangeCommitted(object sender, EventArgs e)
        {
            pnlStep2.Visible = true;
        }

        private void picFilter_Click(object sender, EventArgs e)
        {
            int drinksID = (cbRecipe.SelectedItem as DrinksDTO).MaDichVu;
            LoadRecipeFilter(drinksID);
        }

        private void picReload_Click(object sender, EventArgs e)
        {
            LoadRecipeList();
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lstTempRecipe.Items)
            {
                if (int.Parse(item.SubItems[4].Text) == (cbMaterial.SelectedItem as MaterialDTO).MaNguyenLieu && int.Parse(item.SubItems[3].Text) == (cbMenu.SelectedItem as DrinksDTO).MaDichVu)
                {
                    float amount = float.Parse(item.SubItems[2].Text);
                    amount += float.Parse(nudAmount.Value.ToString());
                    item.SubItems[2].Text = amount + "";
                    return;
                }
            }

            string drinksName = (cbMenu.SelectedItem as DrinksDTO).TenDichVu;
            string materialName = (cbMaterial.SelectedItem as MaterialDTO).TenNguyenLieu;
            string amountRequest = nudAmount.Value + "";

            ListViewItem request = new ListViewItem(drinksName);
            request.SubItems.Add(materialName);
            request.SubItems.Add(amountRequest);
            request.SubItems.Add((cbMenu.SelectedItem as DrinksDTO).MaDichVu + "");
            request.SubItems.Add((cbMaterial.SelectedItem as MaterialDTO).MaNguyenLieu + "");
            lstTempRecipe.Items.Add(request);
        }

        private void btnPushUp_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstTempRecipe.Items.Count == 0)
                {
                    MessageBox.Show("Công thức rỗng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                foreach (ListViewItem item in lstTempRecipe.Items)
                {
                    int drinksID = int.Parse(item.SubItems[3].Text);
                    int materialID = int.Parse(item.SubItems[4].Text);
                    float amount = float.Parse(item.SubItems[2].Text);

                    RecipeDAO.Instance.AddRecipe(drinksID, materialID, amount);
                }
                LoadRecipeList();
                lstTempRecipe.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Trùng lặp dữ liệu\n" + ex.Message);
            }
        }
        #endregion
    }
}
