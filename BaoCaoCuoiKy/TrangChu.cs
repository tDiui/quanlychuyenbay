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
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BaoCaoCuoiKy
{
    public partial class TrangChu : Form
    {
        QuanTriDTO quanTriDTO = new QuanTriDTO();
        QuanTriBUS quanTriBUS = new QuanTriBUS();
        //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-JTO2V7H;Initial Catalog=qlSanBay;Integrated Security=True");
        public TrangChu()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            MatKhauBox.PasswordChar = '*';
        }

        private void getData()
        {
            quanTriDTO.TaiKhoan = TaiKhoanBox.Text;
            quanTriDTO.MatKhau = MatKhauBox.Text;
            quanTriBUS.info = quanTriDTO;
        }

        private void DangNhapBtn_Click(object sender, EventArgs e)
        {
            getData();
            QuanTriForm qtf = new QuanTriForm();
            if (!quanTriBUS.DangNhap())
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

        private void Dangkibtn_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            registerForm.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
