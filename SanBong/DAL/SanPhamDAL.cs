using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SanPhamDAL:DataaccessDAL
    {
        List<SanPham> SanPhams = new List<SanPham>();

        public List<SanPham> getAll()
        {
            OpenConec();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from SanPham";
            cmd.Connection = conec;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                SanPham sanPham = new SanPham();
                string MaSP = dr.GetString(0);
                string TenSP = dr.GetString(1);
                int DonGia = dr.GetInt32(2);
                sanPham.DonGia = DonGia;
                sanPham.MaSP = MaSP;
                sanPham.TenSP = TenSP;
                
                SanPhams.Add(sanPham);
            }
            dr.Close();
            return SanPhams;
        }

        public SanPham getSanPham(string MaSP)
        {
            OpenConec();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from SanPham where MaSP = '" + MaSP + "'";
            cmd.Connection = conec;
            SqlDataReader dr = cmd.ExecuteReader();
            SanPham sanPham = new SanPham();
            while (dr.Read())
            {
                sanPham.DonGia = dr.GetInt32(2);
                sanPham.MaSP = MaSP;
                sanPham.TenSP = dr.GetString(1);
            }
            dr.Close();
            return sanPham;
        }

        public SanPham getSanPham_ByName(string TenSP)
        {
            OpenConec();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from SanPham where TenSP = N'" + TenSP + "'";
            cmd.Connection = conec;
            SqlDataReader dr = cmd.ExecuteReader();
            SanPham sanPham = new SanPham();
            while (dr.Read())
            {
                sanPham.DonGia = dr.GetInt32(2);
                sanPham.MaSP = dr.GetString(0);
                sanPham.TenSP = dr.GetString(1);
            }
            dr.Close();
            return sanPham;
        }
    }
}
