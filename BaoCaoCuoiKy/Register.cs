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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void passwordtextbox(object sender, EventArgs e)
        {

        }

        private void accounttextbox(object sender, EventArgs e)
        {

        }

        private void Nhaphovatentextbox(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dangnhap_button_Click(object sender, EventArgs e)
        {
            TrangChu Tc = new TrangChu();
            Tc.ShowDialog();
        }

        private void Dangkitaikhoan_button_Click(object sender, EventArgs e)
        {
            string hoTen = nhapvaohovaten_textbox.Text;
            string taiKhoan = account_TextBox.Text;
            string matKhau = password_TextBox.Text;
            if (string.IsNullOrWhiteSpace(hoTen))
            {
                MessageBox.Show("Vui lòng nhập họ và tên.");
                return;
            }

            if (string.IsNullOrWhiteSpace(taiKhoan))
            {
                MessageBox.Show("Vui lòng nhập tài khoản.");
                return;
            }

            if (string.IsNullOrWhiteSpace(matKhau))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu.");
                return;
            }

            if (hoTen.Any(char.IsDigit) || hoTen.Any(ch => !char.IsLetterOrDigit(ch) && ch != ' '))
            {
                MessageBox.Show("Họ tên không được chứa số hoặc kí tự đặc biệt, ngoại trừ khoảng trắng.");
                return;
            }


            // Kiểm tra khoảng cách giữa các từ và độ dài họ tên
            string[] words = hoTen.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                int spaceCount = 0;
                foreach (char c in words[i])
                {
                    if (c == ' ')
                    {
                        spaceCount++;
                        if (spaceCount > 2)
                        {
                            MessageBox.Show("Họ tên không được có nhiều hơn hai khoảng trắng liên tiếp giữa các từ.");
                            return;
                        }
                    }
                    else
                    {
                        spaceCount = 0;
                    }
                }
            }



            if (hoTen.Length > 25)
            {
                MessageBox.Show("Họ tên không được vượt quá 25 ký tự.");
                return;
            }

            if (!taiKhoan.Any(char.IsDigit) /* || !taiKhoan.Any(char.IsLetter) || taiKhoan.Any(ch => !char.IsLetterOrDigit(ch))  */)
            {
                MessageBox.Show("Vui lòng nhập chính xác số CMND.");
                return;
            }
            /*
            if (matKhau.Length < 8 && !matKhau.All(char.IsLower) && !matKhau.All(char.IsDigit))
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 8 ký tự và chỉ chứa chữ số và chữ thường.");
                return;
            }
            if (taiKhoan == matKhau)
            {
                MessageBox.Show("Tài khoản không được giống với mật khẩu.");
                return;
            }
            */
            string xacNhanMatKhau = XacnhanMatKhau_textbox.Text; // lữu trữ chuỗi xác nhận mật khẩu é :))
            if (matKhau != xacNhanMatKhau)
            {
                // Mật khẩu và xác nhận mật khẩu không giống nhau thì cout ra lỗi =)))
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu không khớp.");
            }




            // Tạo câu truy vấn SQL chèn dữ liệu vào bảng QuanTri
            string query = $"INSERT INTO KhachHang(HoTen, CMND, MatKhau) Values( '{hoTen}', '{taiKhoan}', '{matKhau}')";

            DataProvider dataProvider = new DataProvider();
            dataProvider.OpenConnection();
            dataProvider.executeNonQuery(query);
            dataProvider.CloseConnection();

            MessageBox.Show("Đăng kí tài khoản thành công.");
        }

        private void XacnhanMatKhau_textbox_TextChanged(object sender, EventArgs e)
        {
        }

    }
}