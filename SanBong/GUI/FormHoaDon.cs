using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormHoaDon : Form
    {
        public FormHoaDon()
        {
            InitializeComponent();
        }

        public FormHoaDon(int MaHD, string KhachDua, string TraLai) : this()
        {
            Load_HoaDon(MaHD, KhachDua, TraLai);
        }

        public FormHoaDon(int MaHD) : this()
        {
            Load_HoaDon(MaHD, null, null);
        }

        void Load_HoaDon(int MaHD, string KhachDua, string TraLai)
        {
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            HoaDonBLL hoaDonBLL = new HoaDonBLL();
            KhachHangBLL khachHangBLL = new KhachHangBLL();
            ChiTietHDBLL chiTietHDBLL = new ChiTietHDBLL();
            SanPhamBLL sanPhamBLL = new SanPhamBLL();
            SanBLL sanBLL = new SanBLL();
            HoaDon hoaDon = hoaDonBLL.getHoaDon_DaThanhToan(MaHD);
            List<ChiTietHD> list = chiTietHDBLL.getChiTietHD(MaHD);

            labelSan.Text = sanBLL.getSan(hoaDon.MaSan).TenSan;
            labelDate.Text = Convert.ToString(DateTime.Now);
            labelSDT.Text = khachHangBLL.getKhachHang(hoaDon.MaKH).Phone;
            labelName.Text = khachHangBLL.getKhachHang(hoaDon.MaKH).TenKH;

            if(KhachDua == null)
            {
                string tongtien = Convert.ToString(chiTietHDBLL.getTongTien(MaHD));
                labelKhachDua.Text = double.Parse(tongtien).ToString("#,###", cul.NumberFormat) + " VNĐ";
            }
            else
            {
                labelKhachDua.Text = double.Parse(KhachDua).ToString("#,###", cul.NumberFormat) + " VNĐ";
            }

            if (TraLai == null || TraLai == "0")
            {
                labelTraLai.Text = "0 VNĐ";
            }
            else
            {
                labelTraLai.Text = double.Parse(TraLai).ToString("#,###", cul.NumberFormat) + " VNĐ";
            }
            
            foreach (ChiTietHD chiTietHD in list)
            {
                ListViewItem item = new ListViewItem();

                item.Text = sanPhamBLL.getSanPham(chiTietHD.MaSP).TenSP;
                ListHoaDon.Items.Add(item);

                ListViewItem.ListViewSubItem subitem1 = new ListViewItem.ListViewSubItem(item, Convert.ToString(chiTietHD.SoLuong));
                string thanhTien = Convert.ToString(chiTietHD.ThanhTien);
                ListViewItem.ListViewSubItem subitem2 = new ListViewItem.ListViewSubItem(item, double.Parse(thanhTien).ToString("#,###", cul.NumberFormat));

                item.SubItems.Add(subitem1);
                item.SubItems.Add(subitem2);

                string tongtien = Convert.ToString(chiTietHDBLL.getTongTien(MaHD));
                labelTongTien.Text = double.Parse(tongtien).ToString("#,###", cul.NumberFormat) + " VNĐ";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
