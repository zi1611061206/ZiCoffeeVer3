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
    public partial class Staffs : Form
    {
        public string defaultAvatarPath = Application.StartupPath + "\\Resources\\Noavatar.jpg";
        public Image defaultAvatar = Image.FromFile(Application.StartupPath + "\\Resources\\Noavatar.jpg");

        public EmployeesDTO currentAccount;
        BindingSource positionSource = new BindingSource();
        BindingSource employeesSource = new BindingSource();
        BindingSource accountSource = new BindingSource();

        public Staffs()
        {
            InitializeComponent();

            txbSearchPosition.Text = Properties.Resources.searchTextDefault;
            dtgPosition.DataSource = positionSource;
            LoadPosition();
            PositionBinding();

            txbSearchStaff.Text = Properties.Resources.searchTextDefault;
            dtgStaff.DataSource = employeesSource;
            LoadEmployees(0);
            EmployeesBinding();
            txbAvatarPath.Clear();
            LoadPositionList(cbPosition);

            txbSearchAccount.Text = Properties.Resources.searchTextDefault;
            dtgAccount.DataSource = accountSource;
            LoadAccount(0);
            AccountBinding();
            LoadStaffList(cbStaff);
        }

        void LoadPosition()
        {
            positionSource.DataSource = PositionDAO.Instance.GetPosition();
        }

        void LoadEmployees(int positionID)
        {
            if (positionID == 0)
            {
                employeesSource.DataSource = EmployeesDAO.Instance.GetEmployees();
            }
            else
            {
                employeesSource.DataSource = EmployeesDAO.Instance.GetEmployeesByPosition(positionID);
            }
            dtgStaff.Columns["Ảnh"].Visible = false;
        }

        void LoadAccount(int staffID)
        {
            if (staffID == 0)
            {
                accountSource.DataSource = AccountDAO.Instance.GetAccount();
            }
            else
            {
                accountSource.DataSource = AccountDAO.Instance.GetAccountByEmployees(staffID);
            }
        }

        void PositionBinding()
        {
            txbPositionID.DataBindings.Add(new Binding("Text", dtgPosition.DataSource, "Mã", true, DataSourceUpdateMode.Never));
            txbPositionName.DataBindings.Add(new Binding("Text", dtgPosition.DataSource, "Chức vụ", true, DataSourceUpdateMode.Never));
        }

        void EmployeesBinding()
        {
            txbStaffID.DataBindings.Add(new Binding("Text", dtgStaff.DataSource, "Mã", true, DataSourceUpdateMode.Never));
            txbStaffSurname.DataBindings.Add(new Binding("Text", dtgStaff.DataSource, "Họ", true, DataSourceUpdateMode.Never));
            txbStaffMiddleName.DataBindings.Add(new Binding("Text", dtgStaff.DataSource, "Tên đệm", true, DataSourceUpdateMode.Never));
            txbStaffName.DataBindings.Add(new Binding("Text", dtgStaff.DataSource, "Tên", true, DataSourceUpdateMode.Never));
            txbStaffIdCard.DataBindings.Add(new Binding("Text", dtgStaff.DataSource, "CMND", true, DataSourceUpdateMode.Never));
            txbStaffAddress.DataBindings.Add(new Binding("Text", dtgStaff.DataSource, "Địa chỉ", true, DataSourceUpdateMode.Never));
            txbStaffPhone.DataBindings.Add(new Binding("Text", dtgStaff.DataSource, "SĐT", true, DataSourceUpdateMode.Never));
            cbPosition.DataBindings.Add(new Binding("Text", dtgStaff.DataSource, "Tên chức vụ", true, DataSourceUpdateMode.Never));
            picAvatar.DataBindings.Add(new Binding("Image", dtgStaff.DataSource, "Ảnh", true, DataSourceUpdateMode.Never));
            dtpBirth.DataBindings.Add(new Binding("Value", dtgStaff.DataSource, "Ngày sinh", true));
        }

        void AccountBinding()
        {
            txbUsername.DataBindings.Add(new Binding("Text", dtgAccount.DataSource, "Tên đăng nhập", true, DataSourceUpdateMode.Never));
            txbDate.DataBindings.Add(new Binding("Text", dtgAccount.DataSource, "Ngày tạo", true, DataSourceUpdateMode.Never));
        }

        void LoadPositionList(ComboBox cb)
        {
            cb.DataSource = PositionDAO.Instance.GetPositionList();
            cb.DisplayMember = "tenchucvu";
        }

        void LoadStaffList(ComboBox cb)
        {
            cb.DataSource = EmployeesDAO.Instance.GetEmployeesList();
            cb.DisplayMember = "fullInfo";
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

        private void txbPositionID_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txbPositionID.Text))
            {
                LoadEmployees(int.Parse(txbPositionID.Text));
            }
        }

        private void txbStaffID_TextChanged(object sender, EventArgs e)
        {
            txbAvatarPath.Clear();
            if (!String.IsNullOrEmpty(txbStaffID.Text))
            {
                LoadAccount(int.Parse(txbStaffID.Text));
                if (EmployeesDAO.Instance.GetSex(Int32.Parse(txbStaffID.Text)))
                {
                    rdFemale.Checked = true;
                }
                else
                {
                    rdMale.Checked = true;
                }
            }
        }

        private void txbUsername_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txbUsername.Text))
            {
                foreach (var item in cbStaff.Items)
                {
                    if ((item as EmployeesDTO).MaNhanVien == Int32.Parse(txbStaffID.Text))
                    {
                        cbStaff.SelectedItem = item;
                    }
                }
            }
        }

        private void txbSearchPosition_Click(object sender, EventArgs e)
        {
            (sender as TextBox).SelectAll();
        }

        private void txbSearchPosition_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string positionName = txbSearchPosition.Text;
                positionSource.DataSource = PositionDAO.Instance.SearchPosition(positionName);
            }
        }

        private void txbSearchStaff_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string staffName = txbSearchStaff.Text;
                employeesSource.DataSource = EmployeesDAO.Instance.SearchEmployees(staffName);
            }
        }

        private void txbSearchAccount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string username = txbSearchAccount.Text;
                accountSource.DataSource = AccountDAO.Instance.SearchAccount(username);
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

        bool mouseClicked2 = false;

        private void picResize2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseClicked2 = true;
        }

        private void picResize2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseClicked2 = false;
        }

        private void picResize2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseClicked2)
            {
                this.pnlRight.Width = picResize.Left - e.X;
            }
        }

        //

        private void picNew_Click(object sender, EventArgs e)
        {
            txbPositionID.Clear();
            txbPositionName.Clear();
        }

        private void picAdd_Click(object sender, EventArgs e)
        {
            try
            {
                AddPosition();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddPosition()
        {
            string positionName = txbPositionName.Text;
            bool success = false;
            if (PositionDAO.Instance.AddPosition(positionName))
            {
                success = true;
            }

            if (success)
            {
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPosition();
                LoadEmployees(0);
                LoadPositionList(cbPosition);
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
                DeletePosition();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeletePosition()
        {
            if (String.IsNullOrEmpty(txbPositionID.Text))
            {
                MessageBox.Show("Hãy chọn một chức vụ", "Thông báo");
                return;
            }
            int positionID = Int32.Parse(txbPositionID.Text);

            bool success = false;
            if (positionID == 1 || positionID == 2)
            {
                MessageBox.Show("Đây là cơ sở mặc định\nKhông thể xóa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (MessageBox.Show("Thao tác này có thể xóa các nhân viên và tài khoản đang giữ chức vụ tương ứng\nHãy chắc chắn bạn muốn xóa", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                if (PositionDAO.Instance.DeletePosition(positionID))
                {
                    success = true;
                }
            }
            else
            {
                return;
            }

            if (success)
            {
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPosition();
                LoadEmployees(0);
                LoadPositionList(cbPosition);
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
                EditPosition();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditPosition()
        {
            if (String.IsNullOrEmpty(txbPositionID.Text))
            {
                MessageBox.Show("Hãy chọn một chức vụ", "Thông báo");
                return;
            }
            int positionID = Convert.ToInt32(txbPositionID.Text);
            string positionName = txbPositionName.Text;

            bool success = false;
            if (positionID == 1)
            {
                MessageBox.Show("Đây là cấp quản trị\nKhông thể thay đổi", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (PositionDAO.Instance.ChangePosition(positionName, positionID))
            {
                success = true;
            }

            if (success)
            {
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPosition();
                LoadEmployees(positionID);
                LoadPositionList(cbPosition);
            }
            else
            {
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picReload_Click(object sender, EventArgs e)
        {
            LoadPosition();
        }

        //

        private void picNew2_Click(object sender, EventArgs e)
        {
            txbStaffID.Clear();
            txbStaffSurname.Clear();
            txbStaffMiddleName.Clear();
            txbStaffName.Clear();
            rdMale.Checked = true;
            txbStaffIdCard.Clear();
            txbStaffAddress.Clear();
            txbStaffPhone.Clear();

            txbAvatarPath.Text = defaultAvatarPath;
            picAvatar.Image = defaultAvatar;
        }

        private void picAdd2_Click(object sender, EventArgs e)
        {
            try
            {
                AddStaff();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddStaff()
        {
            string surname = txbStaffSurname.Text;
            string middleName = txbStaffMiddleName.Text;
            string name = txbStaffName.Text;
            string idCard = txbStaffIdCard.Text;
            string address = txbStaffAddress.Text;
            string phone = txbStaffPhone.Text;
            DateTime birth = dtpBirth.Value;
            bool sex = rdMale.Checked == true ? false : true;
            int positionID = cbPosition.SelectedItem == null ? 1 : (cbPosition.SelectedItem as PositionDTO).MaChucVu;
            byte[] avatar = String.IsNullOrEmpty(txbAvatarPath.Text) ? ConvertImageToBytes(defaultAvatarPath) : ConvertImageToBytes(txbAvatarPath.Text);

            bool success = false;
            if (EmployeesDAO.Instance.AddEmployeesWithAvatar(surname, middleName, name, sex, idCard, address, phone, birth, positionID, avatar))
            {
                success = true;
            }

            if (success)
            {
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadEmployees(positionID);
                LoadAccount(0);
                LoadStaffList(cbStaff);
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
                DeleteStaff();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteStaff()
        {
            if (String.IsNullOrEmpty(txbStaffID.Text))
            {
                MessageBox.Show("Hãy chọn một nhân viên", "Thông báo");
                return;
            }
            int staffID = int.Parse(txbStaffID.Text);

            bool success = false;
            if (EmployeesDAO.Instance.DeleteEmployees(staffID))
            {
                success = true;
            }

            if (success)
            {
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadEmployees(0);
                LoadAccount(0);
                LoadStaffList(cbStaff);
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
                EditStaff();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditStaff()
        {
            if (String.IsNullOrEmpty(txbStaffID.Text))
            {
                MessageBox.Show("Hãy chọn một nhân viên", "Thông báo");
                return;
            }
            int staffID = int.Parse(txbStaffID.Text);
            string surname = txbStaffSurname.Text;
            string middleName = txbStaffMiddleName.Text;
            string name = txbStaffName.Text;
            bool sex = rdMale.Checked == true ? false : true;
            string idCard = txbStaffIdCard.Text;
            string address = txbStaffAddress.Text;
            string phone = txbStaffPhone.Text;
            DateTime birth = dtpBirth.Value;
            int positionID = (cbPosition.SelectedItem as PositionDTO).MaChucVu;
            byte[] avatar = String.IsNullOrEmpty(txbAvatarPath.Text) ? null : ConvertImageToBytes(txbAvatarPath.Text);

            bool success = false;
            if (avatar == null)
            {
                EmployeesDAO.Instance.ChangeEmployeesNoAvatar(surname, middleName, name, sex, idCard, address, phone, birth, positionID, staffID);
                success = true;
            }
            else
            {
                EmployeesDAO.Instance.ChangeEmployeesWithAvatar(surname, middleName, name, sex, idCard, address, phone, birth, positionID, avatar, staffID);
                success = true;
            }

            if (success)
            {
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadEmployees(positionID);
                LoadAccount(staffID);
                LoadStaffList(cbStaff);
            }
            else
            {
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picReload2_Click(object sender, EventArgs e)
        {
            LoadEmployees(0);
        }

        //

        private void picNewAccount_Click(object sender, EventArgs e)
        {
            try
            {
                CreateAccount();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CreateAccount()
        {
            string username = txbUsername.Text;
            int staffID = cbStaff.SelectedItem == null ? 1 : (cbStaff.SelectedItem as EmployeesDTO).MaNhanVien;

            if (AccountDAO.Instance.CheckExisted(username))
            {
                MessageBox.Show("Tài khoản " + username + " đã tồn tại\nVui lòng chọn tên đăng nhập khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool success = false;
            if (AccountDAO.Instance.AddAccount(username, staffID))
            {
                success = true;
            }

            if (success)
            {
                MessageBox.Show("Thêm thành công!\n\n- Tên đăng nhập: " + username + "\n- Mật khẩu mặc định của bạn là: 1\n\nBạn có thể đăng nhập để đổi lại mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAccount(staffID);
            }
            else
            {
                MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picResetPassword_Click(object sender, EventArgs e)
        {
            try
            {
                ResetPassword();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ResetPassword()
        {
            string username = txbUsername.Text;

            bool success = false;
            if (AccountDAO.Instance.ResetPassword(username))
            {
                success = true;
            }

            if (success)
            {
                MessageBox.Show("Mật khẩu hiện tại là: 1", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Đặt lại mật khẩu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelAvatar_Click(object sender, EventArgs e)
        {
            txbAvatarPath.Text = defaultAvatarPath;
            picAvatar.Image = defaultAvatar;
            picEdit2_Click(this, new EventArgs());
        }

        private void btnChooseAvatar_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string fileName = openFileDialog1.FileName;
            if (String.IsNullOrEmpty(fileName))
                return;
            try
            {
                Image avatar = Image.FromFile(fileName);
                picAvatar.Image = avatar;
                txbAvatarPath.Text = fileName;
                picEdit_Click(this, new EventArgs());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
