using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class QuanLyDAL:DataaccessDAL
    {
        List<QuanLy> quanLies = new List<QuanLy>();

        public List<QuanLy> getAll()
        {
            OpenConec();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from QuanLy";
            return quanLies;
        }

        public Boolean getQuanLy_Login(string username, string password)
        {
            OpenConec();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from QuanLy where username = '" + username + "' and password = '" + password + "'";
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
    }
}
