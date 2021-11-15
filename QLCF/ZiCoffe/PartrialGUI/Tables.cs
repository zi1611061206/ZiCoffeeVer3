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
using ZiCoffe.Items;

namespace ZiCoffe.PartrialGUI
{
    public partial class Tables : Form
    {
        BindingSource areaSource = new BindingSource();

        public Tables()
        {
            InitializeComponent();

            txbSearchArea.Text = Properties.Resources.searchTextDefault;
            dtgArea.DataSource = areaSource;
            LoadArea();
            AreaBinding();

            txbSearchTable.Text = Properties.Resources.searchTextDefault;
            LoadTable(0);
            LoadAreaList(cbArea);
            picDelete2.ContextMenuStrip = cmsDeleteTable;
        }

        private void LoadArea()
        {
            areaSource.DataSource = AreaDAO.Instance.GetArea();
        }

        private void AreaBinding()
        {
            txbAreaID.DataBindings.Add(new Binding("Text", dtgArea.DataSource, "Mã khu vực", true, DataSourceUpdateMode.Never));
            txbAreaName.DataBindings.Add(new Binding("Text", dtgArea.DataSource, "Tên khu vực", true, DataSourceUpdateMode.Never));
        }

        private void LoadAreaList(ComboBox cb)
        {
            cb.DataSource = AreaDAO.Instance.GetAreaList();
            cb.DisplayMember = "tenkhuvuc";
        }

        private void LoadTable(int areaID)
        {
            fpnlMap.Controls.Clear();
            List<TableDTO> tableList = null;
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
                ConfigureTable(ob, fpnlMap);
            }
        }

        private void LoadTableByName(string tableName)
        {
            fpnlMap.Controls.Clear();
            List<TableDTO> tableList = null;

            tableList = TableDAO.Instance.SearchTableByName(tableName);

            foreach (TableDTO ob in tableList)
            {
                ConfigureTable(ob, fpnlMap);
            }
        }

        private void ConfigureTable(TableDTO item, FlowLayoutPanel currentLayout)
        {
            ButtonItems btnTable = new ButtonItems()
            {
                Width = Properties.Settings.Default.tableWidth,
                Height = Properties.Settings.Default.tableHeigh
            };
            btnTable.Text = item.TenBan
                + Environment.NewLine + (item.TrangThaiSuDung == 0 ? "Trống" : "Có Người")
                + Environment.NewLine + "KV - " + item.MaKhuVuc;
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
            currentLayout.Controls.Add(btnTable);
        }

        //

        private void btnTable_MouseDown(object sender, MouseEventArgs e)
        {
            TableDTO btn = (sender as Button).Tag as TableDTO;
            txbTableID.Text = btn.MaBan.ToString();
            txbTableName.Text = btn.TenBan;

            foreach (var item in cbArea.Items)
            {
                if ((item as AreaDTO).MaKhuVuc == btn.MaKhuVuc)
                {
                    cbArea.SelectedItem = item;
                }
            }

            if (btn.TrangThaiSuDung == 0)
            {
                rdTemp.Checked = true;
            }
            else
            {
                rdUsing.Checked = true;
            }
        }

        private void txbSearchArea_Click(object sender, EventArgs e)
        {
            (sender as TextBox).SelectAll();
        }

        private void txbSearchArea_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string areaName = txbSearchArea.Text;
                areaSource.DataSource = AreaDAO.Instance.SearchArea(areaName);
            }
        }

        private void txbSearchTable_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadTableByName(txbSearchTable.Text);
            }
        }

        private void txbAreaID_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txbAreaID.Text))
            {
                LoadTable(Int32.Parse(txbAreaID.Text));

                txbTableID.Clear();
                txbTableName.Clear();
                rdTemp.Checked = rdUsing.Checked = false;
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
            txbAreaID.Clear();
            txbAreaName.Clear();
        }

        private void picAdd_Click(object sender, EventArgs e)
        {
            try
            {
                AddArea();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddArea()
        {
            string areaName = txbAreaName.Text;

            bool success = false;
            if (AreaDAO.Instance.AddArea(areaName))
            {
                success = true;
            }

            if (success)
            {
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadArea();
                LoadTable(0);
                LoadAreaList(cbArea);
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
                DeleteArea();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteArea()
        {
            if (String.IsNullOrEmpty(txbAreaID.Text))
            {
                MessageBox.Show("Hãy chọn một khu vực", "Thông báo");
                return;
            }
            int areaID = Int32.Parse(txbAreaID.Text);

            bool success = false;
            if (AreaDAO.Instance.DeleteArea(areaID))
            {
                success = true;
            }

            if (success)
            {
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadArea();
                LoadTable(0);
                LoadAreaList(cbArea);
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
                EditArea();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditArea()
        {
            if (String.IsNullOrEmpty(txbAreaID.Text))
            {
                MessageBox.Show("Hãy chọn một khu vực", "Thông báo");
                return;
            }
            int areaID = Convert.ToInt32(txbAreaID.Text);
            string areaName = txbAreaName.Text;

            bool success = false;
            if (AreaDAO.Instance.EditArea(areaID, areaName))
            {
                success = true;
            }

            if (success)
            {
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadArea();
                LoadTable(areaID);
                LoadAreaList(cbArea);
            }
            else
            {
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picReload_Click(object sender, EventArgs e)
        {
            LoadArea();
        }

        //

        private void picNew2_Click(object sender, EventArgs e)
        {
            txbTableID.Clear();
            txbTableName.Clear();
            rdTemp.Checked = true;
        }

        private void picAdd2_Click(object sender, EventArgs e)
        {
            try
            {
                AddTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddTable()
        {
            int areaID = (cbArea.SelectedItem as AreaDTO).MaKhuVuc;
            string areaName = txbAreaName.Text;

            bool success = false;
            if (TableDAO.Instance.AddTable(txbTableName.Text, areaID))
            {
                success = true;
            }

            if (success)
            {
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTable(areaID);
            }
            else
            {
                MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picDelete2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                try
                {
                    DeleteTable();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DeleteTable()
        {
            if (String.IsNullOrEmpty(txbTableID.Text))
            {
                MessageBox.Show("Hãy chọn một bàn", "Thông báo");
                return;
            }
            int areaID = (cbArea.SelectedItem as AreaDTO).MaKhuVuc;
            int tableID = int.Parse(txbTableID.Text);

            bool success = false;
            if (TableDAO.Instance.DeleteTable(tableID))
            {
                success = true;
            }

            if (success)
            {
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTable(areaID);
            }
            else
            {
                MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void xóaBànĐượcChọnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteTable();
        }

        private void xóaToànBộBànTrongKhuVựcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int areaID = (cbArea.SelectedItem as AreaDTO).MaKhuVuc;
            try
            {
                TableDAO.Instance.DeleteAllTableInArea(areaID);
                LoadTable(areaID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void xóaTấtCảBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int areaID = (cbArea.SelectedItem as AreaDTO).MaKhuVuc;
            try
            {
                TableDAO.Instance.DeleteAllTable();
                LoadTable(areaID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void picEdit2_Click(object sender, EventArgs e)
        {
            try
            {
                EditTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditTable()
        {
            if (String.IsNullOrEmpty(txbTableID.Text))
            {
                MessageBox.Show("Hãy chọn một bàn", "Thông báo");
                return;
            }
            int tableID = int.Parse(txbTableID.Text);
            int areaID = (cbArea.SelectedItem as AreaDTO).MaKhuVuc;
            string tableName = txbTableName.Text;

            bool success = false;
            if(TableDAO.Instance.EditTable(tableID, areaID, tableName))
            {
                success = true;
            }

            if (success)
            {
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTable(areaID);
            }
            else
            {
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picReload2_Click(object sender, EventArgs e)
        {
            LoadTable(0);
        }
    }
}
