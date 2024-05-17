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
        static string connection_string = @"Data Source=DESKTOP-JOQJAEU;Initial Catalog=qlSanBay;Integrated Security=True;";
        
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
            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM TenBang", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lammoi_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void them_Click(object sender, EventArgs e)
        {

        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy ID của khách hàng được chọn để xóa
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                int id = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["ID"].Value);

                // Viết mã để xóa dữ liệu từ CSDL ở đây

                // Sau khi xóa, làm mới DataGridView
                LoadData();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khách hàng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
