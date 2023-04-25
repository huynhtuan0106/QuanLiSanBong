using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChiTietHDDAL : DataaccessDAL
    {
        List<ChiTietHD> chiTietHDs = new List<ChiTietHD>();

        public List<ChiTietHD> getChiTietHD(int MaHD)
        {
            OpenConec();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from ChiTietHD where MaHD = " + MaHD;
            cmd.Connection = conec;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ChiTietHD chiTietHD = new ChiTietHD();
                chiTietHD.MaHD = MaHD;
                chiTietHD.MaSP = dr.GetString(1);
                chiTietHD.SoLuong = (float) dr.GetDouble(2);
                chiTietHD.ThanhTien = (float)dr.GetDouble(3);
                chiTietHDs.Add(chiTietHD);
            }
            dr.Close();
            return chiTietHDs;
        }

        public void addChiTietHD(int MaHD, string MaSP, float SoLuong, float ThanhTien, int DonGia)
        {
            float soluong = 0;
            float thanhtien = 0;

            OpenConec();
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "select * from ChiTietHD where MaHD = " + MaHD + " and MaSP = '" + MaSP + "'";
            command.Connection = conec;
            SqlDataReader dr = command.ExecuteReader();

            if (dr.Read() == false)
            {
                dr.Close();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "insert into ChiTietHD values(" + MaHD + ",'" + MaSP + "'," + SoLuong +"," + ThanhTien + "," + DonGia + ")";
                cmd.Connection = conec;
                cmd.ExecuteNonQuery();
            }

            else
            {
                soluong = (float)dr.GetDouble(2) + SoLuong;
                thanhtien = soluong * dr.GetInt32(4);
                dr.Close();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "update ChiTietHD set SoLuong = " + soluong + ", ThanhTien = " + thanhtien + " where MaHD = " + MaHD + " and MaSP = '" + MaSP + "'";
                cmd.Connection = conec;
                cmd.ExecuteNonQuery();
            }
        }

        public float getTongTien(int MaHD)
        {
            OpenConec();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select sum(ThanhTien) as TongTien from ChiTietHD where MaHD = " + MaHD;
            cmd.Connection = conec;
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            float TongTien = (float) dr.GetDouble(0);
            dr.Close();
            return TongTien;
        }

        public void deleteChiTietHD(int MaHD)
        {
            OpenConec();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "Delete from ChiTietHD where MaHD = " + MaHD;
            cmd.Connection = conec;
            cmd.ExecuteNonQuery();
        }

        public void deleteSanPham(int MaHD, string MaSP)
        {
            OpenConec();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "Delete from ChiTietHD where MaHD = " + MaHD + "and MaSP = N'" + MaSP + "'";
            cmd.Connection = conec;
            cmd.ExecuteNonQuery();
        }
    }
}
