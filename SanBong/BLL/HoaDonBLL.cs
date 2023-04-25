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
    public class HoaDonBLL
    {
        HoaDonDAL HoaDonDAL = new HoaDonDAL();

        public List<HoaDon> getAll(DateTime start, DateTime end)
        {
            return HoaDonDAL.getAll(start, end);
        }

        public HoaDon getHoaDon_ByMaSan(int MaSan)
        {
            return HoaDonDAL.getHoaDon_ByMaSan(MaSan);
        }

        public HoaDon getHoaDon_ByMaHD(int MaHD)
        {
            return HoaDonDAL.getHoaDon_ByMaHD(MaHD);
        }

        public HoaDon getHoaDon_DaThanhToan(int MaHD)
        {
            return HoaDonDAL.getHoaDon_DaThanhToan(MaHD);
        }

        public void addHoaDon(int MaSan, int MaKH, DateTime GioVao)
        {
            HoaDonDAL.addHoaDon(MaSan, MaKH, GioVao);
        }

        public void updateHoaDon_ThanhToan(int MaHD, string GioRa, float TongTien, int TrangThai)
        {
            HoaDonDAL.updateHoaDon_ThanhToan(MaHD, GioRa, TongTien, TrangThai);
        }

        public void deleteHoaDon(int MaHD)
        {
            HoaDonDAL.deleteHoaDon(MaHD);
        }

        public float getDoanhThu(DateTime start, DateTime end)
        {
            return HoaDonDAL.getDoanhThu(start, end);
        }

        public int getSoHoaDon(DateTime start, DateTime end)
        {
            return HoaDonDAL.getSoHoaDon(start, end);
        }
    }
}
