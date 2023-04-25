using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDon
    {
        public int MaHD { get; set; }
        public int MaKH { get; set; }
        public int MaSan { get; set; }
        public DateTime GioVao { get; set; }
        public DateTime GioRa { get; set; }
        public float TongTien { get; set; }
        public int TrangThai { get; set; }
    }
}

