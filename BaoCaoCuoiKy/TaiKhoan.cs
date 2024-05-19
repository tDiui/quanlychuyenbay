using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoCaoCuoiKy
{
    internal class TaiKhoan
    {
        private String tenTK;
        private String MK;

        public TaiKhoan()
        {

        }
        public TaiKhoan(String tenTK, String MK)
        {
            this.tenTK = tenTK;
            this.MK = MK;
        }
        public String getTenTK() { return tenTK; }
        public String getMK() { return MK; }
        public void setTenTK(String tenTK) {  this.tenTK = tenTK; }
        public void setMK(String MK) {  this.MK = MK; } 

    }
}

