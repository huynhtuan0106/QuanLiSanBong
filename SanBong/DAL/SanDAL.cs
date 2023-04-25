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
    public class SanDAL : DataaccessDAL
    {
        List<San> Sans = new List<San>();

        public List<San> getAll()
        {
            OpenConec();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from San";
            cmd.Connection = conec;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                San San = new San();
                int MaSan = dr.GetInt32(0);
                string TenSan = dr.GetString(1);
                int TrangThai = dr.GetInt32(2);
                San.MaSan = MaSan;
                San.TenSan = TenSan;
                San.TrangThai = TrangThai;

                Sans.Add(San);
            }
            dr.Close();
            return Sans;
        }

        public San getSan(int MaSan)
        {
            OpenConec();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from San where MaSan = " + MaSan;
            cmd.Connection = conec;
            SqlDataReader dr = cmd.ExecuteReader();
            San san = new San();
            while (dr.Read())
            {
                san.MaSan = MaSan;
                san.TenSan = dr.GetString(1);
                san.TrangThai = dr.GetInt32(2);
            }
            dr.Close();
            return san;
        }

        public void updateSanStatus(int MaSan)
        {
            int TrangThai = getSan(MaSan).TrangThai;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            if (TrangThai == 0)
            {
                cmd.CommandText = "update San set TrangThai = 1 where MaSan = " + MaSan;
            }
            else
            {
                cmd.CommandText = "update San set TrangThai = 0 where MaSan = " + MaSan;
            }
            cmd.Connection = conec;
            cmd.ExecuteNonQuery();
        }
    }
}
