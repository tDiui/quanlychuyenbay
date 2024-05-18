using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoCaoCuoiKy
{
    internal class GiaoDichBUS
    {
        GiaoDichDAO giaoDichDAO = new GiaoDichDAO();
        public void insert(int idDatCho, int idKhachHang, string soTaiKhoan, string matKhau)
        {
            giaoDichDAO.insert(idDatCho, idKhachHang, soTaiKhoan, matKhau);
        }
    }
}
