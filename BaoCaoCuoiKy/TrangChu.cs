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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BaoCaoCuoiKy
{
    public partial class TrangChu : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-JTO2V7H;Initial Catalog=qlSanBay;Integrated Security=True");
        public TrangChu()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            MatKhauBox.PasswordChar = '*';
        }

        private void DangNhapBtn_Click(object sender, EventArgs e)
        {
            string query = $"select MaNV from QuanTri where TaiKhoan = '{TaiKhoanBox.Text}' AND MatKhau = '{MatKhauBox.Text}'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            adapter.Fill(data);
            QuanTriForm qtf = new QuanTriForm();
            if (data.Rows.Count <= 0)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng");
                TaiKhoanBox.Clear();
                MatKhauBox.Clear();
            }
            else
            {
                qtf.Show();
                this.Hide();
                qtf.FormBorderStyle = FormBorderStyle.FixedDialog;
            }
            qtf.Closed += ShowTrangChu;
        }

        private void ShowTrangChu(object sender, EventArgs e)
        {
            this.Show();
        }

        //Chỉ edit chô này thôi nha
        private void DatChuyenBayBtn_Click(object sender, EventArgs e)
        {
            DatChuyenBay datChuyenBay = new DatChuyenBay();
            datChuyenBay.Show();
        }

        //bên dưới này để nguyên

        private void ThoatBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
