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
    public class ChiTietHDBLL
    {
        ChiTietHDDAL chiTietHDDAL = new ChiTietHDDAL();

        public List<ChiTietHD> getChiTietHD(int MaHD)
        {
            return chiTietHDDAL.getChiTietHD(MaHD);
        }

        public void addChiTietHD(int MaHD, string MaSP, float SoLuong, float ThanhTien, int DonGia)
        {
            chiTietHDDAL.addChiTietHD(MaHD, MaSP, SoLuong, ThanhTien, DonGia);
        }

        public float getTongTien(int MaHD)
        {
            return chiTietHDDAL.getTongTien(MaHD);
        }

        public void deleteChiTietHD(int MaHD)
        {
            chiTietHDDAL.deleteChiTietHD(MaHD);
        }

        public void deleteSanPham(int MaHD, string MaSP)
        {
            chiTietHDDAL.deleteSanPham(MaHD, MaSP);
        }
    }
}
