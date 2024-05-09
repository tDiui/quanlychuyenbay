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
    public partial class ChonGhe : Form
    {
        string connectionString = "Data Source=DESKTOP-JTO2V7H;Initial Catalog=qlSanBay;Integrated Security=True;MultipleActiveResultSets=True;";
        int IdMaChuyenBay, SoLuongVe, IdMaGheChuyenBay;
        int IdKhachHang;
        string LoaiGheChon;
        string SoTaiKhoan, MatKhau;
        public ChonGhe()
        {
            InitializeComponent();
        }

        public void GetMaChuyenBay(int IdChuyenBay, string LoaiGhe, int SoLuongVe)
        {
            this.IdMaChuyenBay = IdChuyenBay;
            this.SoLuongVe = SoLuongVe;
            this.LoaiGheChon = LoaiGhe;
        }

        private void ChonGhe_Load(object sender, EventArgs e)
        {


            // SQL query to select records from a table
            string query = $"select * from GheNgoi WHERE TinhTrangDat = '0' AND LoaiGhe = '{LoaiGheChon}' AND IdChuyenBay = {IdMaChuyenBay}";

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

                                while (reader.Read())
                                {
                                    // Access columns by name or index
                                    int IdGheChuyenBay = reader.GetInt32(0);
                                    int IdChuyenBay = reader.GetInt32(1);
                                    string MaGhe = reader.GetString(2);
                                    var TinhTrangDat = reader.GetString(3);
                                    String LoaiGhe = reader.GetString(4);
                                    // Retrieve other columns as needed...

                                    // Add a new row to the DataGridView

                                    dataGridView1.Rows.Add(IdGheChuyenBay, IdChuyenBay, MaGhe, TinhTrangDat, LoaiGhe);
                                }
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
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(IdKHBox.Text == "" || STKBox.Text == "" || MatKhauBox.Text == "")
                {
                    MessageBox.Show("Vui lập điền thông tin khách hàng!!!");
                    return;
                }
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    // Retrieve the value of the clicked cell
                    SqlConnection sqlConnection1 = new SqlConnection(connectionString);
                    sqlConnection1.Open();
                    object cellValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                    dataGridView1.Rows.Clear();
                    IdMaGheChuyenBay = int.Parse(cellValue.ToString());
                    IdKhachHang = int.Parse(IdKHBox.Text);
                    string another_query = $"INSERT INTO DatCho Values ({IdKhachHang}, '{LoaiGheChon}', {IdMaGheChuyenBay})";
                    SqlConnection sqlConnection = new SqlConnection(connectionString);
                    SqlCommand cmd = new SqlCommand(another_query, sqlConnection1);
                    cmd.ExecuteNonQuery();
                    string Support_query = $"Select IdDatCho from DatCho ORDER BY IdDatCho DESC";
                    SqlCommand command = new SqlCommand(Support_query,sqlConnection1);
                    int IdDatCho;
                    SqlDataReader reader = command.ExecuteReader();
                        // Check if the reader has rows
                    reader.Read();
                    IdDatCho = reader.GetInt32(0);

                    string GiaoDichQuery = $"insert into GiaoDich values ({IdDatCho}, GETDATE(), {IdKhachHang}, '{SoTaiKhoan}', '{MatKhau}')";
                    SqlCommand cmd2 = new SqlCommand(GiaoDichQuery, sqlConnection1);
                    cmd2.ExecuteNonQuery();
                    ChonGhe_Load(sender, e);
                    SoLuongVe--;
                    if( SoLuongVe <= 0)
                    {
                        MessageBox.Show("Đặt vé thành công");
                        this.Close();
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
