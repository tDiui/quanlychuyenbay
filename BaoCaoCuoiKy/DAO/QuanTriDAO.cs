using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoCaoCuoiKy
{
    internal class QuanTriDAO
    {
        String connection_string = "";
        SqlConnection conn;
        DataTable dt;
        DataProvider data = new DataProvider();

        public DataTable DangNhap(String TaiKhoan, String MatKhau)
        {
            String query = $"SELECT * FROM QuanTri WHERE TaiKhoan = '{TaiKhoan}' AND MatKhau = '{MatKhau}'";
            dt = new DataTable();
            dt = data.executeQuery(query);
            return dt;
        }
        public DataTable getDSQuanTri()
        {
            String query = "select * from QuanTri";
            DataTable dt = data.executeQuery(query);
            return dt;
        }

        public void insert(int MaNV, string TenNV, string TaiKhoan, string MatKhau)
        {
            string query = $"INSERT INTO QuanTri values ({MaNV}, '{TenNV}', '{TaiKhoan}', '{MatKhau}')";
            data.executeNonQuery(query);
        }

        public void update(int MaNV, string TenNV, string TaiKhoan, string MatKhau)
        {
            string query = $"UPDATE QuanTri SET TenNV = '{TenNV}', TaiKhoan = '{TaiKhoan}', MatKhau = '{MatKhau}'";
            data.executeNonQuery(query);
        }

        public void delete(int MaNV)
        {
            string query = $"DELETE FROM QuanTri WHERE MaNV = {MaNV}";
            data.executeNonQuery(query);
        }
    }
}
