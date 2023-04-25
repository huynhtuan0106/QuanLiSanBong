using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KhachHangBLL
    {
        KhachHangDAL KhachHangDAL = new KhachHangDAL();

        public List<KhachHang> getAll()
        {
            return KhachHangDAL.getAll();
        }

        public KhachHang getKhachHang(int MaKH)
        {
            return KhachHangDAL.getKhachHang(MaKH);
        }

        public KhachHang getKhachHang_ByPhone(string Phone)
        {
            return KhachHangDAL.getKhachHang_ByPhone(Phone);
        }

        public int getSoKhachHang()
        {
            return KhachHangDAL.getSoKhachHang();
        }

        public Boolean check_addKhachHang(string Phone)
        {
            List<KhachHang> list = KhachHangDAL.getAll();

            foreach (KhachHang n in list)
            {
                if (n.Phone.Equals(Phone))
                {
                    return false;
                }
            }

            return true;
        }

        public void addKhachHang(string TenKH, string Phone)
        {
            KhachHangDAL.addKhachHang(TenKH, Phone);
        }

        public void updateKhachHang(int MaKH, string TenKH, string Phone)
        {
            KhachHangDAL.updateKhachHang(MaKH, TenKH, Phone);
        }

        public void delete(int MaKH)
        {
            KhachHangDAL.delete(MaKH);
        }
    }
}
