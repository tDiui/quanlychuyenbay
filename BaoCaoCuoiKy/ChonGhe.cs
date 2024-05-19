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
    public partial class ChonGhe : Form
    {
        //string connectionString = "Data Source=DESKTOP-JTO2V7H;Initial Catalog=qlSanBay;Integrated Security=True;MultipleActiveResultSets=True;";
        GheNgoiDTO chonGheDTO = new GheNgoiDTO();
        ChonGheBUS chonGheBUS = new ChonGheBUS();
        DatChoBUS datChoBUS = new DatChoBUS();
        GiaoDichBUS giaoDichBUS = new GiaoDichBUS();
        DataTable dt = new DataTable();
        string connectionString = "";
        public ChonGhe()
        {
            InitializeComponent();
        }

        public void GetMaChuyenBay(int IdChuyenBay, string LoaiGhe, int SoLuongVe)
        {
            chonGheDTO.idMaChuyenBay = IdChuyenBay;
            chonGheDTO.soLuongVe = SoLuongVe;
            chonGheDTO.loaiGhe = LoaiGhe;
            chonGheBUS.chonGheDTO = chonGheDTO;
        }

        public void getData()
        {
            chonGheDTO.idKhachHang = int.Parse(IdKHBox.Text);
            chonGheDTO.soTaiKhoan = STKBox.Text;
            chonGheDTO.matKhau = MatKhauBox.Text;
        }

        private void ChonGhe_Load(object sender, EventArgs e)
        {

            dt = chonGheBUS.getDSGheNgoi();
            dataGridView1.DataSource = dt;
           
        }

        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(IdKHBox.Text == "" || STKBox.Text == "" || MatKhauBox.Text == "")
                {
                    MessageBox.Show("Vui lập điền thông tin khách hàng!!!");
                    return;
                }
                getData(); //lấy dữ liệu stk và mk của khách hàng

                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                   
                    //láy idGheChuyenBay của bảng DatGhe
                    chonGheDTO.idMaGheChuyenBay = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                    dt.Rows.Clear();
                    chonGheDTO.idKhachHang = int.Parse(IdKHBox.Text);
                    //insert vào bảng DatCho
                    datChoBUS.insert(chonGheDTO.idKhachHang, chonGheDTO.loaiGhe, chonGheDTO.idMaGheChuyenBay);    
                    //lay id moi nhat trong DatCho
                    int IdDatCho = datChoBUS.getIdDatCho();
                    //insert vao bang GiaoDich
                    giaoDichBUS.insert(IdDatCho, chonGheDTO.idKhachHang, chonGheDTO.soTaiKhoan, chonGheDTO.matKhau);

                    ChonGhe_Load(sender, e);
                    chonGheDTO.soLuongVe--;
                    if(chonGheDTO.soLuongVe <= 0)
                    {
                        MessageBox.Show("Đặt vé thành công");
                        this.Close();
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
