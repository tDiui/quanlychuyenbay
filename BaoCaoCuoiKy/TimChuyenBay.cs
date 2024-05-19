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
    public partial class TimChuyenBay : Form
    {
        DatChuyenBayDTO datChuyenBayDTO = new DatChuyenBayDTO();
        DatChuyenBayBUS dcbBUS = new DatChuyenBayBUS();
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-JTO2V7H;Initial Catalog=qlSanBay;Integrated Security=True");
        ChuyenBayDAO chuyenBayDAO = new ChuyenBayDAO();
        DataTable chuyenBayGrid = new DataTable();
        public TimChuyenBay()
        {
            InitializeComponent();
        }

        public void getData()
        {
            datChuyenBayDTO.DienDi = DiemDiPick.Text;
            datChuyenBayDTO.DiemDen = DiemDenPick.Text;
            datChuyenBayDTO.ThoiGianDi = DateTime.Parse(NgayDiPick.Text);
            datChuyenBayDTO.ThoiGianDen = DateTime.Parse(NgayVePick.Text);
            bool flag = true;
            if(KhuHoiPick.SelectedItem == "True")
            {
                flag = true;
            }
            else if(KhuHoiPick.SelectedItem == "False")
            {
                flag = false;
            }
            datChuyenBayDTO.KhuHoi = flag;
            dcbBUS.DTO = datChuyenBayDTO;
        }

        private void DatChuyenBay_Load(object sender, EventArgs e)
        {
            DataTable DiemDi = dcbBUS.getDSDiemDi();
            DataTable DiemDen = dcbBUS.getDSDiemDen();
            DiemDiPick.ValueMember = "NoiKhoiHanh";
            DiemDenPick.ValueMember = "NoiHaCanh";
            DiemDiPick.DataSource = DiemDi;
            DiemDenPick.DataSource = DiemDen;


            DataTable dsChuyenBay = chuyenBayDAO.getDSChuyenBay();
            dataGridView1.DataSource = dsChuyenBay;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TimChuyenBayBtn_Click(object sender, EventArgs e)
        {
            getData();
            chuyenBayGrid.Rows.Clear();
            chuyenBayGrid = dcbBUS.getDSChuyenBayCanTim();
            if (DiemDiPick.Text == "" || DiemDenPick.Text == "")
            {
                MessageBox.Show("Không được để trống điêm đi hoặc điểm đến");
                return;
            }

            if (KhuHoiPick.Text != "True" && KhuHoiPick.Text != "False")
            {
                MessageBox.Show("vui lòng chọn chế độ chuyến bay!!");
                return;
            }

            if(chuyenBayGrid.Rows.Count <= 0)
            {
                MessageBox.Show("Không có chuyến bay cần tìm");
            }

            dataGridView1.DataSource = chuyenBayGrid;

            //string connectionString = "Data Source=DESKTOP-JTO2V7H;Initial Catalog=qlSanBay;Integrated Security=True";

            // SQL query to select records from a table

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Retrieve the value of the clicked cell
                var idChuyenBay = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                ChonSoLuongVe chonSoLuongVe = new ChonSoLuongVe(idChuyenBay.ToString());
                try
                {
                    chonSoLuongVe.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    //nothing
                }
                
                chonSoLuongVe.Closed += MoForm;
                // Display the value (for demonstration)
            }
        }

        private void MoForm(object sender, EventArgs e)
        {
            this.Show();
        }


        private void KhuHoiPick_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (KhuHoiPick.SelectedItem == "True")
            {
                NgayVePick.Enabled = true;
            }
            else if(KhuHoiPick.SelectedItem == "False")
            {
                NgayVePick.Enabled = false;
            }
        }

        private void Formating(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.CellStyle.SelectionBackColor != e.CellStyle.BackColor)
            {
                DataGridViewCellStyle origin = e.CellStyle.Clone();
                e.CellStyle.SelectionBackColor = e.CellStyle.BackColor;
                e.CellStyle.SelectionForeColor = origin.ForeColor;
            }
        }
    }
}
