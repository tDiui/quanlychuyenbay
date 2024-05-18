using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoCaoCuoiKy
{
    internal class DatChoBUS
    {
        DataProvider data = new DataProvider();
        DatChoDAO datChoDAO = new DatChoDAO();
        public void insert(int idKhachHang, string loaiGhe, int idMaGheChuyenBay)
        {
            datChoDAO.insert(idKhachHang, loaiGhe,  idMaGheChuyenBay);
        }

        public int getIdDatCho()
        {
            return datChoDAO.getIdDatCho();
        }
    }
}
