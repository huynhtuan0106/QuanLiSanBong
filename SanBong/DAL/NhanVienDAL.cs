using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class NhanVienDAL:DataaccessDAL
    {
        List<NhanVien> nhanViens = new List<NhanVien>();

        public List<NhanVien> getAll()
        {
            OpenConec();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from NhanVien";
            cmd.Connection = conec;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                NhanVien nhanVien = new NhanVien();
                nhanVien.MaNV = dr.GetInt32(0);
                nhanVien.TenNV = dr.GetString(1).Trim();
                nhanVien.username = dr.GetString(2).Trim();
                nhanVien.password = dr.GetString(3).Trim();
                nhanVien.SDT = dr.GetString(4).Trim();
                nhanViens.Add(nhanVien);
            }
            dr.Close();
            return nhanViens;
        }

        public Boolean getNhanVien_Login(string username, string password)
        {
            OpenConec();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from NhanVien where username = '" + username + "' and password = '" + password + "'";
            cmd.Connection = conec;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read() == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public NhanVien getNhanVien_ByPhone(string Phone)
        {
            OpenConec();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from NhanVien where phone = '" + Phone + "'";
            cmd.Connection = conec;
            SqlDataReader dr = cmd.ExecuteReader();
            NhanVien k = new NhanVien();
            while (dr.Read())
            {
                k.MaNV = dr.GetInt32(0);
                k.TenNV = dr.GetString(1);
                k.username = dr.GetString(2);
                k.password = dr.GetString(3);
                k.SDT = dr.GetString(4);
            }
            dr.Close();
            return k;
        }

        public int getSoNhanVien()
        {
            OpenConec();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select count(MaNV) as SoLuong from NhanVien";
            cmd.Connection = conec;
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            int SoLuong = dr.GetInt32(0);
            dr.Close();
            return SoLuong;
        }

        public void addNhanVien(string TenNV, string user, string pass, string Phone)
        {
            OpenConec();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "insert into NhanVien values(N'" + TenNV + "','" + user + "','" + pass + "','" + Phone + "')";
            cmd.Connection = conec;
            cmd.ExecuteNonQuery();
        }

        public void updateNhanVien(int MaNV, string TenNV, string user, string pass, string Phone)
        {
            OpenConec();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "update NhanVien set TenNV = N'" + TenNV + "', username = '" + user + "', password = '" + pass + "', phone = '" + Phone + "' where MaNV = " + MaNV;
            cmd.Connection = conec;
            cmd.ExecuteNonQuery();
        }

        public void delete(int MaNV)
        {
            OpenConec();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "delete from NhanVien where MaNV = " + MaNV;
            cmd.Connection = conec;
            cmd.ExecuteNonQuery();
        }

        public void changePassword(string username, string Phone, string PassCu, string PassMoi)
        {
            OpenConec();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "update NhanVien set password = '" + PassMoi + "' where username = '" + username + "' and phone = '" + Phone + "' and password = '" + PassCu + "'";
            cmd.Connection = conec;
            cmd.ExecuteNonQuery();
        }
    }
}
