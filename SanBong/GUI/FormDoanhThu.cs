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
    public partial class FormDoanhThu : Form
    {
        public FormDoanhThu()
        {
            InitializeComponent();
            listHD.FullRowSelect = true;
        }

        void Load_HoaDon(DateTime start, DateTime end)
        {
            HoaDonBLL hoaDonBLL = new HoaDonBLL();
            SanBLL sanBLL = new SanBLL();
            KhachHangBLL khachHangBLL = new KhachHangBLL();
            ChiTietHDBLL chiTietHDBLL = new ChiTietHDBLL();
            SanPhamBLL sanPhamBLL = new SanPhamBLL();
            List<HoaDon> list = hoaDonBLL.getAll(start, end);
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");

            foreach (HoaDon hoaDon in list)
            {
                ListViewItem item = new ListViewItem();
                item.Text = Convert.ToString(hoaDon.MaHD);
                listHD.Items.Add(item);

                String TenKH = khachHangBLL.getKhachHang(hoaDon.MaKH).TenKH;
                String TenSan = sanBLL.getSan(hoaDon.MaSan).TenSan;
                ListViewItem.ListViewSubItem s1 = new ListViewItem.ListViewSubItem(item, TenSan);
                ListViewItem.ListViewSubItem s2 = new ListViewItem.ListViewSubItem(item, TenKH);
                ListViewItem.ListViewSubItem s3 = new ListViewItem.ListViewSubItem(item, Convert.ToString(hoaDon.GioVao.ToString()));
                ListViewItem.ListViewSubItem s4 = new ListViewItem.ListViewSubItem(item, Convert.ToString(hoaDon.GioRa.ToString()));
                string tongtien = Convert.ToString(hoaDon.TongTien);
                ListViewItem.ListViewSubItem s5 = new ListViewItem.ListViewSubItem(item, double.Parse(tongtien).ToString("#,###", cul.NumberFormat));

                item.SubItems.Add(s1);
                item.SubItems.Add(s2);
                item.SubItems.Add(s3);
                item.SubItems.Add(s4);
                item.SubItems.Add(s5);
            }

            string tongthu = Convert.ToString(hoaDonBLL.getDoanhThu(start, end));
            labelTongThu.Text = double.Parse(tongthu).ToString("#,###", cul.NumberFormat) + " VNĐ";
            labelTongChi.Text = "0 VNĐ";
            labelHoaDon.Text = Convert.ToString(hoaDonBLL.getSoHoaDon(start, end));
            labelSoSan.Text = Convert.ToString(hoaDonBLL.getSoHoaDon(start, end));
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            listHD.Items.Clear();
            DateTime start = TimeStart.Value;
            DateTime end = TimeEnd.Value;
            Load_HoaDon(start, end);
        }

        private void btnFind_Click_1(object sender, EventArgs e)
        {
            listHD.Items.Clear();
            DateTime start = TimeStart.Value;
            DateTime end = TimeEnd.Value;
            Load_HoaDon(start, end);
        }

        private void listHD_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listHD.SelectedItems.Count == 0)
            {
                return;
            }
            else
            {
                ListViewItem item = listHD.SelectedItems[0];
                int MaHD = Convert.ToInt32(item.SubItems[0].Text);

                HoaDonBLL hoaDonBLL = new HoaDonBLL();
                ChiTietHDBLL chiTietHDBLL = new ChiTietHDBLL();
                int MaSan = hoaDonBLL.getHoaDon_ByMaHD(MaHD).MaSan;

                FormHoaDon form4 = new FormHoaDon(MaHD);
                form4.Tag = MaHD;
                form4.ShowDialog();
            }
        }
    }
}
