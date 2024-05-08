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
    public partial class DatChuyenBay : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-JTO2V7H;Initial Catalog=qlSanBay;Integrated Security=True");
        public DatChuyenBay()
        {
            InitializeComponent();
        }

        private void DatChuyenBay_Load(object sender, EventArgs e)
        {
            string query = "select * from chuyenbay";
            SqlCommand cmd = new SqlCommand(query, conn);
            List<string> ls = new List<string>();
            conn.Open();
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable db = new DataTable();
            data.Fill(db);
            
            
        }
    }
}
