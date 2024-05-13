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
    public partial class ThongTinKH : Form
    {
        string connectionString = @"Data Source=DESKTOP-JOQJAEU;Initial Catalog=qlSanBay;Integrated Security=True;";
        public ThongTinKH()
        {
            InitializeComponent();
        }

        private void ThongTinKH_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
             using (SqlConnection connection = new SqlConnection(connectionString))
    {
        connection.Open();
        SqlCommand cmd = new SqlCommand("SELECT IdKhachHang, HoTen, CMND FROM KhachHang", connection); // Chỉ định tên cột ở đây
        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        adapter.Fill(dt);
        dataGridView1.DataSource = dt;
    }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Them_Click(object sender, EventArgs e)
        {
           
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy ID của khách hàng được chọn để xóa
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                int id = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["IdKhachHang"].Value);

                // Xóa dữ liệu từ CSDL
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM KhachHang WHERE IdKhachHang = @IdKhachHang", connection);
                    cmd.Parameters.AddWithValue("@IdKhachHang", id);
                    cmd.ExecuteNonQuery();
                }

                // Sau khi xóa, làm mới DataGridView
                LoadData();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khách hàng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
