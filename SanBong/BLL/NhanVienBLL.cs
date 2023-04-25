using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class NhanVienBLL
    {
        NhanVienDAL NhanVienDAL = new NhanVienDAL();

        public List<NhanVien> getAll()
        {
            return NhanVienDAL.getAll();
        }

        public Boolean getNhanVien_Login(string username, string password)
        {
            return NhanVienDAL.getNhanVien_Login(username, password);
        }

        public NhanVien getNhanVien_ByPhone(string Phone)
        {
            return NhanVienDAL.getNhanVien_ByPhone(Phone);
        }

        public int getSoNhanVien()
        {
            return NhanVienDAL.getSoNhanVien();
        }

        public Boolean check_addNhanVien(string username, string Phone)
        {
            List<NhanVien> list = NhanVienDAL.getAll();

            foreach (NhanVien n in list)
            {
                if (n.username.Equals(username) || n.SDT.Equals(Phone))
                {
                    return false;
                }
            }

            return true;
        }

        public void addNhanVien(string TenNV, string user, string pass, string Phone)
        {
            NhanVienDAL.addNhanVien(TenNV, user, pass, Phone);
        }

        public void updateNhanVien(int MaNV, string TenNV, string user, string pass, string Phone)
        {
            NhanVienDAL.updateNhanVien(MaNV, TenNV, user, pass, Phone);
        }

        public void delete(int MaNV)
        {
            NhanVienDAL.delete(MaNV);
        }

        public Boolean check_changePassword(string username, string Phone, string PassCu)
        {
            List<NhanVien> list = NhanVienDAL.getAll();

            foreach (NhanVien n in list)
            {
                if (n.username.Equals(username) && n.SDT.Equals(Phone) && n.password.Equals(PassCu))
                {
                    return true;
                }
            }

            return false;
        }

        public void changePassword(string username, string Phone, string PassCu, string PassMoi)
        {
            NhanVienDAL.changePassword(username, Phone, PassCu, PassMoi);
        }
    }
}
