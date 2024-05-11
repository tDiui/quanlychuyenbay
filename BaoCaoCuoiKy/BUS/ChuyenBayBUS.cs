using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoCaoCuoiKy
{
    internal class ChuyenBayBUS
    {
        private ChuyenBayDAO data = new ChuyenBayDAO();
        //Chứa thông tin của 1 học sinh
        public ChuyenBayDTO info;

        /*
        public bool DangNhap()
        {
            DataTable dt = new DataTable();
            dt = data.DangNhap(info.TaiKhoan, info.MatKhau);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        */

        public DataTable getDSChuyenBay()
        {
            return data.getDSChuyenBay();
        }

        public bool insert()
        {
            try
            {
                data.insert(info.IdChuyenBay, info.NoiKhoiHanh, info.NoiHaCanh, info.TGKhoiHanh, info.TGDen, info.GiaVe, info.TongChoNgoi, info.IdChuyenBayKhuHoi, info.KhuHoi);
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
                data.update(info.IdChuyenBay, info.NoiKhoiHanh, info.NoiHaCanh, info.TGKhoiHanh, info.TGDen, info.GiaVe, info.TongChoNgoi, info.IdChuyenBayKhuHoi, info.KhuHoi);
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
                data.delete(info.IdChuyenBay);
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

