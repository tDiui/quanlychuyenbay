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
            return data.executeQuery(query);
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

        public DataTable getDSDiemDi()
        {
            string query = "Select NoiKhoiHanh from ChuyenBay where NoiKhoiHanh != '' group by NoiKhoiHanh";
            return data.executeQuery(query);
        }

        public DataTable getDSDiemDen()
        {
            string query = "Select NoiHaCanh from ChuyenBay where NoiKhoiHanh != '' group by NoiHaCanh";
            return data.executeQuery(query);
        }

        private int castBoolToInt(bool Target)
        {
            if(Target == true)
            {
                return 1;
            }else if(Target == false)
            {
                return 0;
            }
            return 0;
        }

        public DataTable getDSChuyenBayCanTim(string DiemDi, string DiemDen, DateTime ThoiGianDi, DateTime ThoiGianDen, bool KhuHoi)
        {
            string query = $"Select * from ChuyenBay as A join ChuyenBay as B on (B.IdChuyenBay = A.IdChuyenBayKhuHoi) where A.NoiKhoiHanh = '{DiemDi}' AND A.NoiHaCanh = '{DiemDen}' AND CONVERT(DATE,A.TGKhoiHanh) = '{ThoiGianDi}' AND CONVERT(DATE,B.TGKhoiHanh) = '{ThoiGianDen}' AND A.KhuHoi = {castBoolToInt(KhuHoi)}";
            return data.executeQuery(query);
        }

        public DataTable getDSChuyenBayCanTim(string DiemDi, string DiemDen, DateTime ThoiGianDi, bool KhuHoi)
        {
            string query = $"Select * from ChuyenBay where NoiKhoiHanh = '{DiemDi}' AND NoiHaCanh = '{DiemDen}' AND CONVERT(DATE,TGKhoiHanh) = '{ThoiGianDi}' AND KhuHoi = {castBoolToInt(KhuHoi)}";
            return data.executeQuery(query);
        }

        public int DemSoLuongGheNgoi(int idChuyenBay, string loaiVe)
        {
            string query = $"select count(IdChuyenBay) as SoLuongVe from GheNgoi WHERE TinhTrangDat = '0' AND LoaiGhe = '{loaiVe}' AND IdChuyenBay = {idChuyenBay}";
            var soLuongVe = data.executeScalar(query);
            return (int)soLuongVe;
        }

        public string daCoDungTruoc(bool flag)
        {
            if (flag)
            {
                return " AND";
            }
            else
            {
                return "";
            }

        }

        public DataTable getDSChuyenBayTheoFilter(int IdChuyenBay, string NoiKhoiHanh, string NoiHaCanh, float GiaVe)
        {
            string query = "select * from ChuyenBay where";
            bool flag = false;
            //string queryIdChuyenBay = "", queryNoiKhoiHanh = "", queryNoiHaCanh = "", queryGiaVe = "";
            if(IdChuyenBay > -1)
            {
                query += $" IdChuyenBay = {IdChuyenBay}";
                flag = true;
            }
            if (NoiKhoiHanh != "None")
            {
                query += $"{daCoDungTruoc(flag)}" + $" NoiKHoiHanh = '{NoiKhoiHanh}'";
                flag = true;
            }
            if (NoiHaCanh != "None")
            {
                query += $"{daCoDungTruoc(flag)}" + $" NoiHaCanh = '{NoiHaCanh}'";
                flag = true;
            }
            if (GiaVe > -1)
            {
                query += $"{daCoDungTruoc(flag)}" + $" GiaVe < {GiaVe}";
                flag = true;
            }
            query += "";
            return data.executeQuery(query);
        }
    }
}
