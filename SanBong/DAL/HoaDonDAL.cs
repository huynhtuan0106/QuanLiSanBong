using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HoaDonDAL : DataaccessDAL
    {
        List<HoaDon> HDs = new List<HoaDon>();

        public List<HoaDon> getAll(DateTime start, DateTime end)
        {
            OpenConec();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from HoaDon where TrangThai = 1 and GioVao >= '" + start + "' and GioRa <= '" + end + "'";
            cmd.Connection = conec;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                HoaDon hoadon = new HoaDon();
                hoadon.MaSan = dr.GetInt32(2);
                hoadon.MaHD = dr.GetInt32(0);
                hoadon.MaKH = dr.GetInt32(1);
                hoadon.GioVao = dr.GetDateTime(3);
                hoadon.GioRa = dr.GetDateTime(4);
                hoadon.TongTien = (float) dr.GetDouble(5);
                hoadon.TrangThai = dr.GetInt32(6);
                HDs.Add(hoadon);
            }
            dr.Close();
            return HDs;
        }

        public HoaDon getHoaDon_ByMaSan(int MaSan)
        {
            OpenConec();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from HoaDon where MaSan = " + MaSan + "and TrangThai = 0";
            cmd.Connection = conec;
            SqlDataReader dr = cmd.ExecuteReader();
            HoaDon hoadon = new HoaDon();
            while (dr.Read())
            {
                hoadon.MaSan = MaSan;
                hoadon.MaHD = dr.GetInt32(0);
                hoadon.MaKH = dr.GetInt32(1);
                hoadon.GioVao = dr.GetDateTime(3);
                hoadon.TrangThai = dr.GetInt32(6);
            }
            dr.Close();
            return hoadon;
        }

        public HoaDon getHoaDon_ByMaHD(int MaHD)
        {
            OpenConec();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from HoaDon where MaHD = " + MaHD + "and TrangThai = 0";
            cmd.Connection = conec;
            SqlDataReader dr = cmd.ExecuteReader();
            HoaDon hoadon = new HoaDon();
            while (dr.Read())
            {
                hoadon.MaSan = dr.GetInt32(2);
                hoadon.MaHD = dr.GetInt32(0);
                hoadon.MaKH = dr.GetInt32(1);
                hoadon.GioVao = dr.GetDateTime(3);
                hoadon.TrangThai = dr.GetInt32(6);
            }
            dr.Close();
            return hoadon;
        }

        public HoaDon getHoaDon_DaThanhToan(int MaHD)
        {
            OpenConec();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from HoaDon where MaHD = " + MaHD + "and TrangThai = 1";
            cmd.Connection = conec;
            SqlDataReader dr = cmd.ExecuteReader();
            HoaDon hoadon = new HoaDon();
            while (dr.Read())
            {
                hoadon.MaSan = dr.GetInt32(2);
                hoadon.MaHD = dr.GetInt32(0);
                hoadon.MaKH = dr.GetInt32(1);
                hoadon.GioVao = dr.GetDateTime(3);
                hoadon.TrangThai = dr.GetInt32(6);
            }
            dr.Close();
            return hoadon;
        }

        public void addHoaDon(int MaSan, int MaKH, DateTime GioVao)
        {
            OpenConec();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "insert into HoaDon values(" + MaKH + "," + MaSan + ",'" + GioVao + "',null,0,0)";
            cmd.Connection = conec;
            cmd.ExecuteNonQuery();
        }

        public void updateHoaDon_ThanhToan(int MaHD, string GioRa, float TongTien, int TrangThai)
        {
            OpenConec();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "update HoaDon set GioRa = '" + GioRa + "', TongTien = " + TongTien + ", TrangThai = " + TrangThai + " where MaHD = " + MaHD;
            cmd.Connection = conec;
            cmd.ExecuteNonQuery();
        }

        public void deleteHoaDon(int MaHD)
        {
            OpenConec();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "Delete from HoaDon where MaHD = " + MaHD;
            cmd.Connection = conec;
            cmd.ExecuteNonQuery();
        }

        public float getDoanhThu(DateTime start, DateTime end)
        {
            OpenConec();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select sum(TongTien) as DoanhThu from HoaDon where TrangThai = 1 and GioVao >= '" + start + "' and GioRa <= '" + end + "'";
            cmd.Connection = conec;
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            float DoanhThu = (float)dr.GetDouble(0);
            dr.Close();
            return DoanhThu;
        }

        public int getSoHoaDon(DateTime start, DateTime end)
        {
            OpenConec();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select count(MaHD) as SoLuong from HoaDon where TrangThai = 1 and GioVao >= '" + start + "' and GioRa <= '" + end + "'";
            cmd.Connection = conec;
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            int SoLuong = dr.GetInt32(0);
            dr.Close();
            return SoLuong;
        }
    }
}
