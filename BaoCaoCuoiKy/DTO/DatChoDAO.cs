using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoCaoCuoiKy
{
    internal class DatChoDAO
    {
        DataProvider data = new DataProvider();
        public void insert(int idKhachHang, string loaiGhe, int idMaGheChuyenBay)
        {
            string query = $"INSERT INTO DatCho Values ({idKhachHang}, '{loaiGhe}', {idMaGheChuyenBay})";
            data.executeNonQuery(query);
        }

        public int getIdDatCho() 
        {
            string Support_query = $"Select IdDatCho from DatCho ORDER BY IdDatCho DESC";
            int idDatCho = (int)data.executeScalar(Support_query);
            return idDatCho;
        }
    }
}
