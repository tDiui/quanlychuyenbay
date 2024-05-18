using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoCaoCuoiKy
{
    internal class GheNgoiDAO
    {
        DataProvider data = new DataProvider();
        public DataTable getDSGheNgoi(string LoaiGheChon, int IdChuyenBay)
        {
            string query = $"select * from GheNgoi WHERE TinhTrangDat = '0' AND LoaiGhe = '{LoaiGheChon}' AND IdChuyenBay = {IdChuyenBay}";
            return data.executeQuery(query);
        }
    }
}
