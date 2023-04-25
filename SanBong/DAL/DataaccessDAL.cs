using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DataaccessDAL
    {
        public String server, db, uid, pwd;
        public SqlConnection conec = null;

        public void OpenConec()
        {
            readConfigFile();

            string strconec = "server = " + server + "; database = " + db + "; integrated security=true";
            
            if (uid != null)
            {
                strconec = "server = " + server + "; database = " + db + "; uid = " + uid + "; pwd = " + pwd;
            }

            if (conec == null)
            {
                conec = new SqlConnection(strconec);
            }
            if (conec.State == System.Data.ConnectionState.Closed)
            {
                conec.Open();
            }
        }

        public void CloseConec()
        {
            if (conec != null && conec.State == System.Data.ConnectionState.Open)
            {
                conec.Close();
            }
        }

        public void readConfigFile()
        {
            if (File.Exists("config.txt"))
            {
                StreamReader sr = new StreamReader("config.txt");
                string s = sr.ReadLine();
                server = sr.ReadLine();
                db = sr.ReadLine();
                uid = null;
                pwd = null;

                if (s.Equals("sql"))
                {
                    uid = sr.ReadLine();
                    pwd = sr.ReadLine();
                }

                sr.Close();
            }
        }

    }
}
