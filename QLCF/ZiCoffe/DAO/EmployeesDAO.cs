using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZiCoffe.DTO;

namespace ZiCoffe.DAO
{
    public class EmployeesDAO
    {
        #region package_EmployeesDAO
        private static EmployeesDAO instance;

        public static EmployeesDAO Instance
        {
            get { if (instance == null) instance = new EmployeesDAO(); return EmployeesDAO.instance; }
            private set { EmployeesDAO.instance = value; }
        }

        private EmployeesDAO() { }
        #endregion

        public DataTable GetEmployees()
        {
            string query = "exec LoadListEmployees";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public List<EmployeesDTO> GetEmployeesList()
        {
            List<EmployeesDTO> employeesList = new List<EmployeesDTO>();
            string query = "select * from nhanvien";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                EmployeesDTO dataLine = new EmployeesDTO(item);
                employeesList.Add(dataLine);
            }
            return employeesList;
        }

        public DataTable GetEmployeesByPosition(int maChucVu)
        {
            string query = "exec LoadListEmployeesByPosition @machucvu ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { maChucVu });
        }

        public DataTable GetEmployeesById(int maNhanVien)
        {
            string query = "select ANHDAIDIEN as [Ảnh] from dbo.NHANVIEN where MaNhanVien = "+maNhanVien;
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public List<EmployeesDTO> GetEmployeesListForComboBox()
        {
            List<EmployeesDTO> employeesList = new List<EmployeesDTO>();
            string query = "select * from dbo.nhanvien";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                EmployeesDTO dataLine = new EmployeesDTO(item);
                employeesList.Add(dataLine);
            }
            return employeesList;
        }

        public int GetMaxEmployeesID()
        {
            string query = "select max(manhanvien) from nhanvien";
            return (int)DataProvider.Instance.ExecuteScalar(query);
        }

        public DataTable SearchEmployees(string ten)
        {
            string query = string.Format("exec SearchEmployees N'{0}'", ten);
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool AddEmployeesWithAvatar(string ho, string tenDem, string ten, bool gioiTinh, string cmnd, string diaChi, string sdt, DateTime ngaySinh, int maChucVu, byte[] anhDaiDien)
        {
            string query = "insert into dbo.nhanvien (ho, tendem, ten, gioitinh, chungminhnhandan, diachi, sodienthoai, ngaysinh, machucvu, anhdaidien) values ( @ho , @tendem , @ten , @gioitinh , @cmnd , @diachi , @sdt , @ngaysinh , @machucvu , @anhdaidien )";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { ho, tenDem, ten, gioiTinh, cmnd, diaChi, sdt, ngaySinh, maChucVu, anhDaiDien });
            return result > 0;
        }

        public bool DeleteEmployees(int maNhanVien)
        {
            AccountDAO.Instance.DeleteAccountByStaff(maNhanVien);
            string query = "delete dbo.nhanvien where manhanvien= @manhanvien";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maNhanVien });
            return result > 0;
        }

        public bool DeleteEmployeesByPosition(int maChucVu)
        {
            string query = "delete dbo.nhanvien where machucvu= @machucvu ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maChucVu });
            return result > 0;
        }

        public bool ChangeEmployeesNoAvatar(string ho, string tenDem, string ten, bool gioiTinh, string cmnd, string diaChi, string sdt, DateTime ngaySinh, int maChucVu, int maNhanVien)
        {
            string query = "update dbo.nhanvien set ho = @ho , tendem = @tendem , ten = @ten , gioitinh = @gioitinh , chungminhnhandan = @cmnd , diachi = @diachi , sodienthoai = @sdt , ngaysinh = @ngaysinh , machucvu = @machucvu where manhanvien = @manhanvien ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { ho, tenDem, ten, gioiTinh, cmnd, diaChi,sdt, ngaySinh, maChucVu, maNhanVien });
            return result > 0;
        }

        public bool ChangeEmployeesWithAvatar(string ho, string tenDem, string ten, bool gioiTinh, string cmnd, string diaChi, string sdt, DateTime ngaySinh, int maChucVu, byte[] anhDaiDien, int maNhanVien)
        {
            string query = "update dbo.nhanvien set ho = @ho , tendem = @tendem , ten = @ten , gioitinh = @gioitinh , chungminhnhandan = @cmnd , diachi = @diachi , sodienthoai = @sdt , ngaysinh = @ngaysinh , machucvu = @machucvu , anhdaidien = @anhdaidien where manhanvien = @manhanvien ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { ho, tenDem, ten, gioiTinh, cmnd, diaChi, sdt, ngaySinh, maChucVu, anhDaiDien, maNhanVien });
            return result > 0;
        }

        public bool GetSex(int maNhanVien)
        {
            string query = "select gioitinh from nhanvien where manhanvien = @manhanvien ";
            Object ob = DataProvider.Instance.ExecuteScalar(query, new object[] { maNhanVien });
            return (bool)ob;
        }
    }
}
