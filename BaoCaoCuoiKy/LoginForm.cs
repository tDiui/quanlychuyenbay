using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaoCaoCuoiKy
{
    public partial class LoginForm : Form
    {
        private int currentImageIndex = 0;
        private string[] imagePaths = { @"C:\Users\Admin\Downloads\quanlychuyenbay\BaoCaoCuoiKy\Resources\anh-may-bay-dang-bay.jpg", @"C:\Users\Admin\Downloads\quanlychuyenbay\BaoCaoCuoiKy\Resources\hinh-anh-bay-tren-troi-la-may-bay_111631532.jpg", @"C:\Users\Admin\Downloads\quanlychuyenbay\BaoCaoCuoiKy\Resources\anh-may-bay-dep_041752800.jpg", @"C:\Users\Admin\Downloads\quanlychuyenbay\BaoCaoCuoiKy\Resources\hinh-anh-may-bay-phan-luc.jpg" };
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-JTO2V7H;Initial Catalog=qlSanBay;Integrated Security=True");
        public LoginForm()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // Để ảnh hiển thị đầy đủ trong PictureBox
            timer1.Interval = 1000; // 1 giây
            timer1.Tick += Timer_Tick;
            timer1.Start();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = imagePaths[currentImageIndex];
        }

        private void LoginForm_Load_1(object sender, EventArgs e)
        {

        }

        private void RunProgressBar(object sender, KeyPressEventArgs e)
        {
            pB1.Value = 30;
            pB1.Maximum = 100;
            pB1.Minimum = 0;
            int num = 10;
            for (int i = 0; i < 7; i++)
            {
                pB1.Value += num;
                Thread.Sleep(200);
            }

            TrangChu rf = new TrangChu();
            rf.Show();
            this.Hide();
            rf.Closed += (sender, e) => this.Close();

        }
        private void Timer_Tick(object? sender, EventArgs e)
        {
            // Chuyển đổi ảnh
            currentImageIndex = (currentImageIndex + 1) % imagePaths.Length;
            pictureBox1.ImageLocation = imagePaths[currentImageIndex];
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        
    }
}
