using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoCaoCuoiKy
{
    internal class DatChuyenBayBUS
    {
        public DatChuyenBayDTO DTO = new DatChuyenBayDTO();
        public ChuyenBayDAO cbDAO = new ChuyenBayDAO();

        public DataTable getDSDiemDi()
        {
            return cbDAO.getDSDiemDi();
        }

        public DataTable getDSDiemDen()
        {
            return cbDAO.getDSDiemDen();
        }

        public DataTable getDSChuyenBayCanTim()
        {
            if(DTO.KhuHoi == true)
            {
                return cbDAO.getDSChuyenBayCanTim(DTO.DienDi, DTO.DiemDen, DTO.ThoiGianDi, DTO.ThoiGianDen, DTO.KhuHoi);
            }
            else
            {
                return cbDAO.getDSChuyenBayCanTim(DTO.DienDi, DTO.DiemDen, DTO.ThoiGianDi, DTO.KhuHoi);
            }
        }
    }
}
