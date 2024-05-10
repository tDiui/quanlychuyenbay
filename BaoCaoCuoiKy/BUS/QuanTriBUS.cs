using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoCaoCuoiKy
{
    internal class QuanTriBUS
    {
        //Để truy xuất xuống CSDL
        private QuanTriDAO data = new QuanTriDAO();
        //Chứa thông tin của 1 học sinh
        public QuanTriDTO info;

        public bool DangNhap()
        {
            DataTable dt = new DataTable();
            dt = data.DangNhap(info.TaiKhoan, info.MatKhau);
            if(dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable getDSQuanTri()
        {
            return data.getDSQuanTri();
        }

        public bool insert()
        {
            try
            {
                data.insert(info.MaNV, info.TenNV, info.TaiKhoan, info.MatKhau);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm dữ liệu" + ex.Message);
                return false;
            }
        }
        public bool update()
        {
            try
            {
                data.update(info.MaNV, info.TenNV, info.TaiKhoan, info.MatKhau);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi updata dữ liệu" + ex.Message);
                return false;
            }
        }
        public bool delete()
        {
            try
            {
                data.delete(info.MaNV);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Xóa dữ liệu" + ex.Message);
                return false;
            }
        }
    }
}
