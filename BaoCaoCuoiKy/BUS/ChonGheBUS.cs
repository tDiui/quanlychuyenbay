using BaoCaoCuoiKy;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoCaoCuoiKy
{
    internal class ChonGheBUS
    {
        public GheNgoiDTO chonGheDTO = new GheNgoiDTO();
        public GheNgoiDAO chonGheDAO = new GheNgoiDAO(); 
        public DataTable getDSGheNgoi() //lay danh sach ghe ngoi con trong
        {
            return chonGheDAO.getDSGheNgoi(chonGheDTO.loaiGhe, chonGheDTO.idMaChuyenBay);
        }

    }
}
