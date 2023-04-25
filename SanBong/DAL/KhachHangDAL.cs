using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KhachHangDAL:DataaccessDAL
    {
        List<KhachHang> khachHangs = new List<KhachHang>();

        public List<KhachHang> getAll()
        {
            OpenConec();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from KhachHang";
            cmd.Connection = conec;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                KhachHang khachHang = new KhachHang();
                int MaKH = dr.GetInt32(0);
                string TenKH = dr.GetString(1).Trim();
                string Phone = dr.GetString(2).Trim();
                khachHang.Phone = Phone;
                khachHang.MaKH = MaKH;
                khachHang.TenKH = TenKH;
                
                khachHangs.Add(khachHang);
            }
            dr.Close();
            return khachHangs;
        }

        public KhachHang getKhachHang(int MaKH)
        {
            OpenConec();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from KhachHang where MaKH = " + MaKH;
            cmd.Connection = conec;
            SqlDataReader dr = cmd.ExecuteReader();
            KhachHang k = new KhachHang();
            while (dr.Read())
            {
                k.MaKH = MaKH;
                k.TenKH = dr.GetString(1);
                k.Phone = dr.GetString(2);
            }
            dr.Close();
            return k;
        }

        public KhachHang getKhachHang_ByPhone(string Phone)
        {
            OpenConec();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from KhachHang where Phone = " + Phone;
            cmd.Connection = conec;
            SqlDataReader dr = cmd.ExecuteReader();
            KhachHang k = new KhachHang();
            while (dr.Read())
            {
                k.MaKH = dr.GetInt32(0);
                k.TenKH = dr.GetString(1);
                k.Phone = dr.GetString(2);
            }
            dr.Close();
            return k;
        }

        public int getSoKhachHang()
        {
            OpenConec();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select count(MaKH) as SoLuong from KhachHang";
            cmd.Connection = conec;
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            int SoLuong = dr.GetInt32(0);
            dr.Close();
            return SoLuong;
        }

        public void addKhachHang(string TenKH, string Phone)
        {
            OpenConec();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "insert into KhachHang values(N'" + TenKH + "','" + Phone + "')";
            cmd.Connection = conec;
            cmd.ExecuteNonQuery();
        }

        public void updateKhachHang(int MaKH, string TenKH, string Phone)
        {
            OpenConec();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "update KhachHang set TenKH = N'" + TenKH + "', Phone = '" + Phone + "' where MaKH = " + MaKH;
            cmd.Connection = conec;
            cmd.ExecuteNonQuery();
        }

        public void delete(int MaKH)
        {
            OpenConec();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "delete from KhachHang where MaKH = " + MaKH;
            cmd.Connection = conec;
            cmd.ExecuteNonQuery();
        }
    }
}
