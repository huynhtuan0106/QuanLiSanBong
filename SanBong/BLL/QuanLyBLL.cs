using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class QuanLyBLL
    {
        QuanLyDAL QuanLyDAL = new QuanLyDAL();

        public List<QuanLy> getAll()
        {
            return QuanLyDAL.getAll();
        }

        public Boolean getQuanLy_Login(string username, string password)
        {
            return QuanLyDAL.getQuanLy_Login(username, password);
        }
    }
}
