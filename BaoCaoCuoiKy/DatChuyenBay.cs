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

            DiemDiPick.Items.Add("SG");
            DiemDiPick.Items.Add("HN");
            DiemDiPick.Items.Add("HUE");
            DiemDiPick.Items.Add("DN");
            DiemDiPick.Items.Add("PQ");

            DiemDenPick.Items.Add("SG");
            DiemDenPick.Items.Add("HN");
            DiemDenPick.Items.Add("HUE");
            DiemDenPick.Items.Add("DN");
            DiemDenPick.Items.Add("PQ");


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TimChuyenBayBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            if (DiemDiPick.Text == "" || DiemDenPick.Text == "")
            {
                MessageBox.Show("Không được để trống điêm đi hoặc điểm đến");
                return;
            }
            string DiemDi, DiemDen;
            var NgayDi = NgayDiPick.Text;
            var NgayVe = NgayVePick.Text;
            if (KhuHoiPick.Text != "True" && KhuHoiPick.Text != "False")
            {
                MessageBox.Show("vui lòng chọn chế độ chuyến bay!!");
                return;
            }

            DiemDi = DiemDiPick.Text;
            DiemDen = DiemDenPick.Text;

            string connectionString = "Data Source=DESKTOP-JTO2V7H;Initial Catalog=qlSanBay;Integrated Security=True";

            // SQL query to select records from a table
            string query = $"select CBC.IdChuyenBay, CBC.NoiKhoiHanh, CBC.NoiHaCanh,CBC.TGKhoiHanh, CBKH.TGKhoiHanh as TGVe, CBC.GiaVe, CBC.TongChoNgoi,CBC.IdChuyenBayKhuHoi, CBC.KhuHoi from ChuyenBay as CBC join ChuyenBay as CBKH on( CBC.IdChuyenBayKhuHoi = CBKH.IdChuyenBay) WHERE (CONVERT(DATE,CBC.TGKhoiHanh) = '{NgayDi}' AND CONVERT(DATE, CBKH.TGKhoiHanh) = '{NgayVe}' AND CBC.NoiKhoiHanh = '{DiemDi}' AND CBC.NoiHaCanh = '{DiemDen}')";
            if (KhuHoiPick.Text == "False")
            {
                query = $"select CBC.IdChuyenBay, CBC.NoiKhoiHanh, CBC.NoiHaCanh,CBC.TGKhoiHanh, '' as TGVe, CBC.GiaVe, CBC.TongChoNgoi,'' as IdChuyenBayKhuHoi, CBC.KhuHoi from ChuyenBay as CBC  WHERE CONVERT(DATE,CBC.TGKhoiHanh) = '{NgayDi}' AND CBC.NoiKhoiHanh = '{DiemDi}' AND CBC.NoiHaCanh = '{DiemDen}' ";
            }

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
                                if (KhuHoiPick.Text == "True")
                                {
                                    while (reader.Read())
                                    {
                                        // Access columns by name or index
                                        int IdChuyenBay = reader.GetInt32(0);
                                        string NoiKhoiHanh = reader.GetString(1);
                                        string NoiHaCanh = reader.GetString(2);
                                        var TGKhoiHanh = reader.GetDateTime(3);
                                        var TGVe = reader.GetDateTime(4);
                                        Decimal GiaVe = reader.GetDecimal(5);
                                        int TongChoNgoi = reader.GetInt32(6);
                                        int IdChuyenBayKhuHoi = reader.GetInt32(7);
                                        bool KhuHoi = reader.GetBoolean(8);
                                        // Retrieve other columns as needed...

                                        // Add a new row to the DataGridView

                                        dataGridView1.Rows.Add(IdChuyenBay, NoiKhoiHanh, NoiHaCanh,
                                            TGKhoiHanh, TGVe, GiaVe, TongChoNgoi, IdChuyenBayKhuHoi, KhuHoi);
                                    }
                                }
                                else
                                {
                                    while (reader.Read())
                                    {
                                        // Access columns by name or index
                                        int IdChuyenBay = reader.GetInt32(0);
                                        string NoiKhoiHanh = reader.GetString(1);
                                        string NoiHaCanh = reader.GetString(2);
                                        var TGKhoiHanh = reader.GetDateTime(3);
                                        String TGVe = reader.GetString(4);
                                        Decimal GiaVe = reader.GetDecimal(5);
                                        int TongChoNgoi = reader.GetInt32(6);
                                        string IdChuyenBayKhuHoi = reader.GetString(7);
                                        bool KhuHoi = reader.GetBoolean(8);
                                        // Retrieve other columns as needed...

                                        // Add a new row to the DataGridView

                                        dataGridView1.Rows.Add(IdChuyenBay, NoiKhoiHanh, NoiHaCanh,
                                            TGKhoiHanh, TGVe, GiaVe, TongChoNgoi, IdChuyenBayKhuHoi, KhuHoi);
                                    }
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

        private void DiemDiPick_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Retrieve the value of the clicked cell
                object cellValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                ChonSoLuongVe chonSoLuongVe = new ChonSoLuongVe();
                chonSoLuongVe.GetMaChuyenBay(cellValue.ToString());
                chonSoLuongVe.Show();
                this.Hide();
                chonSoLuongVe.Closed += DongForm;
                // Display the value (for demonstration)
            }
        }

        private void DongForm(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
