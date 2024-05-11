using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoCaoCuoiKy
{
    internal class ChuyenBayDAO
    {
        DataTable dt;
        DataProvider data = new DataProvider();


        public DataTable getDSChuyenBay()
        {
            String query = "select * from ChuyenBay";
            DataTable dt = data.executeQuery(query);
            return dt;
        }

        public void insert(int IdChuyenBay, string NoiKhoiHanh, string NoiHaCanh, DateTime TGKhoiHanh, DateTime TGDen, float GiaVe, int TongChoNgoi, int IdChuyenBayKhuHoi, bool KhuHoi)
        {
            string query = $"INSERT INTO QuanTri values ({IdChuyenBay}, '{NoiKhoiHanh}', '{NoiHaCanh}', '{TGKhoiHanh}', '{TGDen}', {GiaVe}, {TongChoNgoi}, {IdChuyenBayKhuHoi}, {KhuHoi})";
            data.executeNonQuery(query);
        }

        public void update(int IdChuyenBay, string NoiKhoiHanh, string NoiHaCanh, DateTime TGKhoiHanh, DateTime TGDen, float GiaVe, int TongChoNgoi, int IdChuyenBayKhuHoi, bool KhuHoi)
        {
            string query = $"UPDATE QuanTri SET IdChuyenBay = {IdChuyenBay}, NoiKhoiHanh = '{NoiKhoiHanh}', NoiHaCanh = '{NoiHaCanh}', TGKhoiHanh = '{TGKhoiHanh}', TGDen = '{TGDen}', GiaVe = {GiaVe}, TongChoNgoi = {TongChoNgoi}, IdChuyenBayKhuHoi = {IdChuyenBayKhuHoi}, KhuHoi = {KhuHoi}";
            data.executeNonQuery(query);
        }

        public void delete(int IdChuyenBay)
        {
            string query = $"DELETE FROM QuanTri WHERE MaNV = {IdChuyenBay}";
            data.executeNonQuery(query);
        }

        public DataTable getListDiemDi()
        {
            string query = "SELECT NoiKhoiHanh FROM ChuyenBay GROUP BY NoiKhoiHanh";
            DataTable dt = data.executeQuery(query);
            return dt;
        }

        public DataTable getListDiemDen()
        {
            string query = "SELECT NoiHaCanh FROM ChuyenBay GROUP BY NoiHaCanh";
            DataTable dt = data.executeQuery(query);
            return dt;
        }
    }
}
