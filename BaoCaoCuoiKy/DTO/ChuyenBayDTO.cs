using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoCaoCuoiKy
{
    internal class ChuyenBayDTO
    {
        public int IdChuyenBay { get; set; }
        public string NoiKhoiHanh { get; set; }
        public string NoiHaCanh { get; set; }
        public DateTime TGKhoiHanh { get; set; }
        public DateTime TGDen { get; set; }
        public float GiaVe { get; set; }
        public int TongChoNgoi { get; set; }
        public int IdChuyenBayKhuHoi { get; set; }
        public bool KhuHoi { get; set; }
    }
}
