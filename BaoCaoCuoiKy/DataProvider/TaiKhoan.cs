using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoCaoCuoiKy.DataProviders
{
    internal class TaiKhoan
    {
        private string tenTK;
        private string MK;

        public TaiKhoan()
        {

        }
        public TaiKhoan(string tenTK, string MK)
        {
            this.tenTK = tenTK;
            this.MK = MK;
        }
        public string getTenTK() { return tenTK; }
        public string getMK() { return MK; }
        public void setTenTK(string tenTK) { this.tenTK = tenTK; }
        public void setMK(string MK) { this.MK = MK; }

    }
}

