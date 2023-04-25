using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SanBLL
    {
        SanDAL sanDAL = new SanDAL();

        public List<San> getAll()
        {
            return sanDAL.getAll();
        }

        public San getSan(int MaSan)
        {
            return sanDAL.getSan(MaSan);
        }

        public void updateSanStatus(int MaSan)
        {
            sanDAL.updateSanStatus(MaSan);
        }
    }
}
