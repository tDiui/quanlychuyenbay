using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoCaoCuoiKy
{
    internal class ChonSoLuongVeBUS
    {
        public ChonSoLuongVeDTO chonVeDTO = new ChonSoLuongVeDTO();
        private ChuyenBayDAO chonVeDAO = new ChuyenBayDAO();

        public bool KiemTraSoLuongVe()
        {
            int soLuongCoSan = chonVeDAO.DemSoLuongGheNgoi(chonVeDTO.idChuyenBay, chonVeDTO.loaiVe);
            if(chonVeDTO.veCanMua <= soLuongCoSan)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
