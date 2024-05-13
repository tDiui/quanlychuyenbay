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
        static string connection_string = @"Data Source=DESKTOP-JTO2V7H;Initial Catalog=qlSanBay;Integrated Security=True";
        SqlConnection conn = new SqlConnection(connection_string);
        ChuyenBayDTO chuyenBayDTO = new ChuyenBayDTO();
        ChuyenBayBUS chuyenBayBUS = new ChuyenBayBUS();

        public QuanTriForm()
        {
            InitializeComponent();
            conn.Open();
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
        }

        /*
         private void ResetBtn_Click(object sender, EventArgs e)
        {
            IdChuyenBayBox.Clear();
            NoiCatCanhBox.Clear();
            NoiHaCanhBox.Clear();
            TGKhoiHanhBox.Clear();
            TGDenNoiBox.Clear();
            GiaVeBox.Clear();
            TongChoNgoiBox.Clear();
            IdChuyenBayKhuHoiBox.Clear();
            LaChuyenBayKhuHoiBox.Clear();
        }

        private void ClockTextBox()
        {
            //IdChuyenBayBox.ReadOnly = true;
            NoiCatCanhBox.ReadOnly = true;
            NoiHaCanhBox.ReadOnly = true;
            TGKhoiHanhBox.ReadOnly = true;
            TGDenNoiBox.ReadOnly = true;
            GiaVeBox.ReadOnly = true;
            TongChoNgoiBox.ReadOnly = true;
            IdChuyenBayKhuHoiBox.ReadOnly = true;
            LaChuyenBayKhuHoiBox.ReadOnly = true;
        }


        private void ThemChuyenBayBtn_Click(object sender, EventArgs e)
        {

            ThemChuyenBayPanel.Show();
            TimChuyenBay.Show();
            ThemChuyenBayLb.Show();
            XoaChuyenBayLb.Hide();
            TimChuyenBayLb.Hide();
        }

        private void XoaChuyenBayBtn_Click(object sender, EventArgs e)
        {
            TimChuyenBay.Show();
            ThemChuyenBayLb.Hide();
            TimChuyenBayLb.Hide();
            XoaChuyenBayLb.Show();
            ClockTextBox();

        }

        private void TimChuyenBayBtn_Click(object sender, EventArgs e)
        {
            TimChuyenBay.Show();
            ThemChuyenBayLb.Hide();
            XoaChuyenBayLb.Hide();
            TimChuyenBayLb.Show();
            ClockTextBox();
        }


        private void TimChuyenBay_Click(object sender, EventArgs e)
        {
            if (TimChuyenBayLb.Visible.ToString() == "True" || XoaChuyenBayLb.Visible.ToString() == "True" || ThemChuyenBayLb.Visible.ToString() == "True")
            {
                getData();


                string IdChuyenBay;
                IdChuyenBay = IdChuyenBayBox.Text;
                string query = $"Select * from ChuyenBay where IdChuyenBay = '{IdChuyenBay}'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                if (dataTable.Rows.Count <= 0)
                {
                    MessageBox.Show("Không có chuyên bay cần tìm");
                    ResetBtn_Click(sender, new EventArgs());
                    return;
                }
                IdChuyenBayBox.Text = dataTable.Rows[0][0].ToString();
                NoiCatCanhBox.Text = dataTable.Rows[0][1].ToString();
                NoiHaCanhBox.Text = dataTable.Rows[0][2].ToString();
                TGKhoiHanhBox.Text = dataTable.Rows[0][3].ToString();
                TGDenNoiBox.Text = dataTable.Rows[0][4].ToString();
                GiaVeBox.Text = dataTable.Rows[0][5].ToString();
                TongChoNgoiBox.Text = dataTable.Rows[0][6].ToString();
                IdChuyenBayKhuHoiBox.Text = dataTable.Rows[0][7].ToString();

            }
        }

        private void ThucHienBtn_Click(object sender, EventArgs e)
        {
            if (XoaChuyenBayLb.Visible.ToString() == "True")
            {
                string qry = $"DELETE from ChuyenBay where IdChuyenBay = {IdChuyenBayBox.Text}";
                SqlCommand cmd = new SqlCommand(qry, conn);
                cmd.ExecuteNonQuery();
                ResetBtn_Click(sender, new EventArgs());
                MessageBox.Show("Xóa chuyến bay thành công");

            }


            if (ThemChuyenBayLb.Visible.ToString() == "True")
            {
                string qry = $"INSERT INTO ChuyenBay Values( {IdChuyenBayBox.Text}, '{NoiCatCanhBox.Text}', '{NoiHaCanhBox.Text}', '{TGKhoiHanhBox.Text}', '{TGDenNoiBox.Text}', {GiaVeBox.Text}, {TongChoNgoiBox.Text}, {IdChuyenBayKhuHoiBox.Text}, {LaChuyenBayKhuHoiBox.Text})";
                SqlCommand cmd = new SqlCommand(qry, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("thêm chuyến bay thành công");
            }
        }

        private void ThoatBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
         */


        private void Grid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ThemChuyenBayBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
