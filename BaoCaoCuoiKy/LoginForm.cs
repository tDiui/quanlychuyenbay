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
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-JTO2V7H;Initial Catalog=qlSanBay;Integrated Security=True");
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
