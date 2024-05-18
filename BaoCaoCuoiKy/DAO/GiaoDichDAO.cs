using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoCaoCuoiKy
{
    internal class GiaoDichDAO
    {
        DataProvider data = new DataProvider();
        public void insert(int idDatCho, int idKhachHang, string soTaiKhoan, string matKhau)
        {
            string GiaoDichQuery = $"insert into GiaoDich values ({idDatCho}, GETDATE(), {idKhachHang}, '{soTaiKhoan}', '{matKhau}')";
            data.executeNonQuery(GiaoDichQuery);
        }
    }
}
