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
    public partial class QuanTriForm : Form
    {
        static string connection_string = @"Data Source=DESKTOP-JOQJAEU;Initial Catalog=qlSanBay;Integrated Security=True;";
        SqlConnection conn = new SqlConnection(connection_string);
        ChuyenBayDTO chuyenBayDTO = new ChuyenBayDTO();
        ChuyenBayBUS chuyenBayBUS = new ChuyenBayBUS();
        DatChuyenBayBUS dcbBUS = new DatChuyenBayBUS();

        public QuanTriForm()
        {
            InitializeComponent();
        }

        public void getData()
        {
            
            chuyenBayDTO.IdChuyenBay = int.Parse(idChuyenBayBox.Text);
            chuyenBayDTO.NoiKhoiHanh = noiKhoiHanhCb.Text;
            chuyenBayDTO.NoiHaCanh = noiHaCanhCb.Text;
            chuyenBayDTO.GiaVe = int.Parse(giaVeBox.Text);
            chuyenBayBUS.info = chuyenBayDTO;
        }

        public void DinhDangLuoi()
        {
            Grid1.Columns[0].HeaderText = "Id Chuyen bay";
            Grid1.Columns[0].Width = 130;
            Grid1.Columns[1].HeaderText = "Noi Khoi Hanh";
            Grid1.Columns[1].Width = 100;
            Grid1.Columns[2].HeaderText = "Noi Ha Canh";
            Grid1.Columns[2].Width = 100;
            Grid1.Columns[3].HeaderText = "Thoi Gian Khoi Hanh";
            Grid1.Columns[3].Width = 160;
            Grid1.Columns[4].HeaderText = "Thoi Gian Den";
            Grid1.Columns[4].Width = 160;
            Grid1.Columns[5].HeaderText = "Gia Ve";
            Grid1.Columns[5].Width = 200;
            Grid1.Columns[6].HeaderText = "Tong Cho Ngoi";
            Grid1.Columns[6].Width = 170;
            Grid1.Columns[7].HeaderText = "Id Chuyen Bay Khu Hoi";
            Grid1.Columns[7].Width = 130;
            Grid1.Columns[8].HeaderText = "Khu Hoi";
            Grid1.Columns[8].Width = 90;
        }

        private void QuanTriForm_Load(object sender, EventArgs e)
        {

            DataTable dt = chuyenBayBUS.getDSChuyenBay();
            Grid1.DataSource = dt;
            DinhDangLuoi();
            DataTable DiemDi = dcbBUS.getDSDiemDi();
            DiemDi.Rows.Add("None");
            DataTable DiemDen = dcbBUS.getDSDiemDen();
            DiemDen.Rows.Add("None");
            noiKhoiHanhCb.ValueMember = "NoiKhoiHanh";
            noiHaCanhCb.ValueMember = "NoiHaCanh";
            noiKhoiHanhCb.DataSource = DiemDi;
            noiHaCanhCb.DataSource = DiemDen;
            noiKhoiHanhCb.SelectedIndex = 2;
            noiHaCanhCb.SelectedIndex = 2;
            giaVeBox.Text = null;
            idChuyenBayBox.Text = null;
            Grid1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void locDanhSachChuyenBay()
        {
            DataTable dt = chuyenBayBUS.getDsChuyenBayTheoFilter();
            Grid1.DataSource = dt;
            DinhDangLuoi();
            DataTable DiemDi = dcbBUS.getDSDiemDi();
            DiemDi.Rows.Add("None");
            DataTable DiemDen = dcbBUS.getDSDiemDen();
            DiemDen.Rows.Add("None");
            noiKhoiHanhCb.ValueMember = "NoiKhoiHanh";
            noiHaCanhCb.ValueMember = "NoiHaCanh";
            noiKhoiHanhCb.DataSource = DiemDi;
            noiHaCanhCb.DataSource = DiemDen;
            noiKhoiHanhCb.SelectedIndex = 2;
            noiHaCanhCb.SelectedIndex = 2;
            giaVeBox.Text = null;
            idChuyenBayBox.Text = null;
        } 

            private void Grid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //bo che do loc
        private void button2_Click(object sender, EventArgs e)
        {
            QuanTriForm_Load(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                getData();
                locDanhSachChuyenBay();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex + "Vui lòng nhập đầy đủ thông tin để lọc");
            }
        }
    }
}
