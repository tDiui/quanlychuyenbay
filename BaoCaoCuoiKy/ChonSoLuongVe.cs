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
    public partial class ChonSoLuongVe : Form
    {
        int SoLuongVe;
        string LoaiVe;
        int IdChuyenBay;
        int SoLuongVeThuc;
        public ChonSoLuongVe()
        {
            InitializeComponent();
        }

        public void GetMaChuyenBay(string IdChuyenBay)
        {
            this.IdChuyenBay = int.Parse(IdChuyenBay);
        }

        private void BatDauChonGheBtn_Click(object sender, EventArgs e)
        {
            SoLuongVe = int.Parse(SoLuongVeBox.Text);
            LoaiVe = LoaiVeBox.Text;
            string query = $"select count(IdChuyenBay) as SoLuongVe from GheNgoi WHERE TinhTrangDat = '0' AND LoaiGhe = '{LoaiVe}' AND IdChuyenBay = {IdChuyenBay}";
            string connectionString = "Data Source=DESKTOP-JTO2V7H;Initial Catalog=qlSanBay;Integrated Security=True";

            
            // Create a connection to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create a command to execute the query
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        // Open the connection
                        connection.Open();

                        // Execute the query and get a data reader
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Check if the reader has rows
                            if (reader.HasRows)
                            {
                                // Loop through the rows
                                reader.Read();
                                SoLuongVeThuc = reader.GetInt32(0);
                            }
                            else
                            {
                                MessageBox.Show("Nhập không chính xác vui lòng nhập lại");                            
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle any exceptions
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            if(SoLuongVe <= SoLuongVeThuc)
            {
                ChonGhe chonGhe = new ChonGhe();
                chonGhe.GetMaChuyenBay(IdChuyenBay, LoaiVe, SoLuongVe);
                chonGhe.Show();
                this.Hide();
                chonGhe.Closed += DongForm;
            }
            else 
            {
                MessageBox.Show("Số lượng vé không đủ vui lòng nhập lại");
                SoLuongVeBox.Clear();
                return;
            }

        }
        private void DongForm(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
