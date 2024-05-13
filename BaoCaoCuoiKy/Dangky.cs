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

        public Dangky()
        {
            InitializeComponent();

        }
        private void RegisterForm_Load(object sender, EventArgs e)
        {
            textBox3.PasswordChar = '*';
            textBox4.PasswordChar = '*';
        }

        private void Dangky_Load(object sender, EventArgs e)
        {
            // Đặt ảnh ban đầu

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
