using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaoCaoCuoiKy
{
    public partial class Dangky : Form
    {
        private int currentImageIndex = 0;
        private string[] imagePaths = { @"C:\Users\Admin\Downloads\quanlychuyenbay\BaoCaoCuoiKy\Resources\anh-may-bay-dang-bay.jpg", @"C:\Users\Admin\Downloads\quanlychuyenbay\BaoCaoCuoiKy\Resources\hinh-anh-bay-tren-troi-la-may-bay_111631532.jpg", @"C:\Users\Admin\Downloads\quanlychuyenbay\BaoCaoCuoiKy\Resources\anh-may-bay-dep_041752800.jpg", @"C:\Users\Admin\Downloads\quanlychuyenbay\BaoCaoCuoiKy\Resources\hinh-anh-may-bay-phan-luc.jpg" };
        public Dangky()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // Để ảnh hiển thị đầy đủ trong PictureBox
            timer1.Interval = 2000; // 2 giây
            timer1.Tick += Timer_Tick;
            timer1.Start();
        }
        private void RegisterForm_Load(object sender, EventArgs e)
        {
            textBox3.PasswordChar = '*';
            textBox4.PasswordChar = '*';
        }
        private void Timer_Tick(object? sender, EventArgs e)
        {
            // Chuyển đổi ảnh
            currentImageIndex = (currentImageIndex + 1) % imagePaths.Length;
            pictureBox1.ImageLocation = imagePaths[currentImageIndex];
        }
        private void Đangky_Load(object sender, EventArgs e)
        {
            // Đặt ảnh ban đầu
            pictureBox1.ImageLocation = imagePaths[currentImageIndex];
        }
    }
}
