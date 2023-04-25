using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SanPhamBLL
    {
        SanPhamDAL SanPhamDAL = new SanPhamDAL();

        public List<SanPham> getAll()
        {
            return SanPhamDAL.getAll();
        }

        public SanPham getSanPham(string MaSP)
        {
            return SanPhamDAL.getSanPham(MaSP);
        }

        public SanPham getSanPham_ByName(string TenSP)
        {
            return SanPhamDAL.getSanPham_ByName(TenSP);
        }
    }
}
