using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaoCaoCuoiKy
{
    public partial class ChonSoLuongVe : Form
    {
        ChonSoLuongVeBUS chonVeBUS = new ChonSoLuongVeBUS();
        ChonSoLuongVeDTO chonVeDTO = new ChonSoLuongVeDTO();
        public ChonSoLuongVe()
        {
            
        }

        public void getData()
        {
            chonVeDTO.veCanMua = int.Parse(SoLuongVeBox.Text);
            chonVeDTO.loaiVe = LoaiVeBox.Text;
            chonVeBUS.chonVeDTO = chonVeDTO;
        }

        public ChonSoLuongVe(string IdChuyenBay)
        {
            chonVeDTO.idChuyenBay = int.Parse(IdChuyenBay);
            InitializeComponent();
        }

        private void BatDauChonGheBtn_Click(object sender, EventArgs e)
        {
            getData(); //dua data vao BUS
 
            
            if(chonVeBUS.KiemTraSoLuongVe())
            {
                ChonGhe chonGhe = new ChonGhe();
                chonGhe.GetMaChuyenBay(chonVeDTO.idChuyenBay, chonVeDTO.loaiVe, chonVeDTO.veCanMua);
                chonGhe.Show();
                this.Hide();
                chonGhe.Closed += DongForm;
            }
            else 
            {
                MessageBox.Show("Số lượng vé không đủ vui lòng nhập lại");
                SoLuongVeBox.Clear();
                return;
            }

        }
        private void DongForm(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
