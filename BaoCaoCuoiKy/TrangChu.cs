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
        private int currentImageIndex = 0;
        static string path = Application.StartupPath + "../../../"; //không thay đổi cái path này nhaaa
        private string[] imagePaths = { @$"{path}\Resources\anh-may-bay-dang-bay.jpg", @$"{path}\Resources\hinh-anh-bay-tren-troi-la-may-bay_111631532.jpg", @$"{path}\Resources\anh-may-bay-dep_041752800.jpg", @$"{path}\Resources\hinh-anh-may-bay-phan-luc.jpg" };
        QuanTriDTO quanTriDTO = new QuanTriDTO();
        QuanTriBUS quanTriBUS = new QuanTriBUS();
        //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-JTO2V7H;Initial Catalog=qlSanBay;Integrated Security=True");
        public TrangChu()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // Để ảnh hiển thị đầy đủ trong PictureBox
            timer1.Interval = 5000; // 5 giây
            timer1.Tick += Timer_Tick;

            timer1.Start();
        }
        private void Timer_Tick(object? sender, EventArgs e)
        {
            // Chuyển đổi ảnh
            currentImageIndex = (currentImageIndex + 1) % imagePaths.Length;
            pictureBox1.ImageLocation = imagePaths[currentImageIndex];
        }
        private void TrangChu_Load(object sender, EventArgs e)
        {
            // Đặt ảnh ban đầu
            pictureBox1.ImageLocation = imagePaths[currentImageIndex];
            this.ControlBox = false;
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dangky dangky= new Dangky();    
            dangky.ShowDialog();
        }
    }
}
