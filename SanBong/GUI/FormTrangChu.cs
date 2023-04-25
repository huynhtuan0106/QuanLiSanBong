using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using Button = System.Windows.Forms.Button;
using ListView = System.Windows.Forms.ListView;

namespace GUI
{
    public partial class FormTrangChu : Form
    {
        public FormTrangChu()
        {
            InitializeComponent();
            Load_San();
            tabControl1.Enabled = false;
            labelTongTien.Hide();
        }

        void Load_San()
        {
            SanBLL sanBLL = new SanBLL();
            List<San> sans = sanBLL.getAll();
            
            foreach (San san in sans)
            {
                Button button = new Button() { Width = 110, Height = 110 };
                switch (san.TrangThai)
                {
                    case 0:
                        button.BackColor = Color.LightGreen;
                        button.Text = san.TenSan + Environment.NewLine + "Trống";
                        button.Click += btnSan_Click;
                        button.Tag = san;
                        break;
                    case 1:
                        button.BackColor = Color.LightGray;
                        button.Text = san.TenSan + Environment.NewLine + "Có người";
                        button.Click += btnSan_Click;
                        button.Tag = san;
                        break;
                }
                flowLayoutPanel1.Controls.Add(button);
            } 
        }

        void btnSan_Click(object sender, EventArgs e)
        {
            SanBLL sanBLL = new SanBLL();
            int MaSan = ((sender as Button).Tag as San).MaSan;
            string TenSan = sanBLL.getSan(MaSan).TenSan;

            tabControl1.Enabled = true;
            flowLayoutPanel2.Controls.Clear();
            Load_DichVu(MaSan);
            ShowHoaDon(MaSan);
            tab3.Text = TenSan;
        }

        void ShowHoaDon(int maSan)
        {
            SanBLL sanBLL = new SanBLL();
            HoaDonBLL hoaDonBLL = new HoaDonBLL();
            KhachHangBLL khachHangBLL = new KhachHangBLL();
            btnStart.Tag = maSan;

            if (sanBLL.getSan(maSan).TrangThai == 1)
            {
                HoaDon hoadon = hoaDonBLL.getHoaDon_ByMaSan(maSan);
                KhachHang khachhang = khachHangBLL.getKhachHang(hoadon.MaKH);

                txtSDT.Text = khachhang.Phone;
                txtName.Text = khachhang.TenKH;
                TimeIn.Value = hoadon.GioVao;
                TimeOut.Value = DateTime.Today;
                listHoaDon.Items.Clear();
                Load_ChiTietHD(hoadon.MaHD);

                btnPay.Tag = hoadon.MaHD;
                btnCancel.Tag = hoadon.MaHD;
                btnEnd.Tag = hoadon.MaHD;
                listHoaDon.Tag = hoadon.MaHD;
                listHoaDon.FullRowSelect = true;
                btnStart.Enabled = false;
                btnEnd.Enabled = true;
                btnAdd.Enabled = false;
                btnFind.Enabled = false;
            }
            if (sanBLL.getSan(maSan).TrangThai == 0)
            {
                txtSDT.Text = "";
                txtName.Text = "";
                TimeIn.Value = DateTime.Now;
                TimeOut.Value = DateTime.Today;
                txtTimeAM.Text = "0";
                txtTimePM.Text = "0";
                labelTongTien.Text = "0";
                labelTongTien2.Text = "0 VNĐ";
                listHoaDon.Items.Clear();
                txtSDT.Focus();

                btnStart.Enabled = true;
                btnEnd.Enabled = false;
                btnAdd.Enabled = true;
                btnFind.Enabled = true;
            }

            btnPay.Enabled = false;
        }

        void Load_DichVu(int MaSan)
        {
            SanPhamBLL sanPhamBLL = new SanPhamBLL();
            List<SanPham> sanPhams = sanPhamBLL.getAll();

            foreach (SanPham sanpham in sanPhams)
            {
                Button button = new Button() { Width = 105, Height = 105 };
                button.Text = sanpham.TenSP;
                button.BackColor = Color.LightYellow;
                button.Tag = MaSan;
                button.Click += btnDichVu_Click;
                flowLayoutPanel2.Controls.Add(button);
            }
        }

        void btnDichVu_Click(object sender, EventArgs e)
        {
            HoaDonBLL hoaDonBLL = new HoaDonBLL();
            SanPhamBLL sanPhamBLL = new SanPhamBLL();
            ChiTietHDBLL chiTietHDBLL = new ChiTietHDBLL();
            SanBLL sanBLL = new SanBLL();

            int MaSan = (int)(sender as Button).Tag;
            string TenSP = (sender as Button).Text;

            if (sanBLL.getSan(MaSan).TrangThai == 0)
            {
                MessageBox.Show(sanBLL.getSan(MaSan).TenSan + " đang trống, không thể thêm dịch vụ.");
            }
            else
            {
                int MaHD = hoaDonBLL.getHoaDon_ByMaSan(MaSan).MaHD;
                string MaSP = sanPhamBLL.getSanPham_ByName(TenSP).MaSP;
                float ThanhTien = (float)sanPhamBLL.getSanPham_ByName(TenSP).DonGia;
                int DonGia = sanPhamBLL.getSanPham_ByName(TenSP).DonGia;

                chiTietHDBLL.addChiTietHD(MaHD, MaSP, 1, ThanhTien, DonGia);
                listHoaDon.Items.Clear();
                Load_ChiTietHD(MaHD);
            }
        }

        void Load_ChiTietHD(int MaHD)
        {
            ChiTietHDBLL chiTietHDBLL = new ChiTietHDBLL();
            SanPhamBLL sanPhamBLL = new SanPhamBLL();
            List<ChiTietHD> list = chiTietHDBLL.getChiTietHD(MaHD);
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            int i = 1;

            foreach (ChiTietHD chiTietHD in list)
            {
                ListViewItem item = new ListViewItem();
                item.Text = Convert.ToString(i);
                listHoaDon.Items.Add(item);

                String TenSP = sanPhamBLL.getSanPham(chiTietHD.MaSP).TenSP;
                int DonGia = sanPhamBLL.getSanPham(chiTietHD.MaSP).DonGia;
                ListViewItem.ListViewSubItem subitem1 = new ListViewItem.ListViewSubItem(item, TenSP);
                ListViewItem.ListViewSubItem subitem2 = new ListViewItem.ListViewSubItem(item, Convert.ToString(chiTietHD.SoLuong));
                string donGia = Convert.ToString(DonGia);
                ListViewItem.ListViewSubItem subitem3 = new ListViewItem.ListViewSubItem(item, double.Parse(donGia).ToString("#,###", cul.NumberFormat));
                string thanhTien = Convert.ToString(chiTietHD.ThanhTien);
                ListViewItem.ListViewSubItem subitem4 = new ListViewItem.ListViewSubItem(item, double.Parse(thanhTien).ToString("#,###", cul.NumberFormat));
                
                item.SubItems.Add(subitem1);
                item.SubItems.Add(subitem2);
                item.SubItems.Add(subitem3);
                item.SubItems.Add(subitem4);

                i++;
                labelTongTien.Text = Convert.ToString(chiTietHDBLL.getTongTien(MaHD));
                string tongTien = Convert.ToString(chiTietHDBLL.getTongTien(MaHD));
                labelTongTien2.Text =  double.Parse(tongTien).ToString("#,###", cul.NumberFormat) + " VNĐ";
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
        }

        private void tab3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            ChiTietHDBLL chiTietHDBLL = new ChiTietHDBLL();
            SanPhamBLL sanPhamBLL = new SanPhamBLL();
            int MaHD = (int)(sender as Button).Tag;
            float time_am = 0;
            float time_pm = 0;
            float time = 0;

            if (TimeOut.Value.Hour == 0)
            {
                TimeOut.Value = DateTime.Now;
            }

            TimeSpan time_use = TimeOut.Value - TimeIn.Value;

            if (time_use.TotalHours - Math.Floor(time_use.TotalHours) <= 0.5)
            {
                time = (float) Math.Floor(time_use.TotalHours) + (float) 0.5;
            }
            else
            {
                time = (float)Math.Ceiling(time_use.TotalHours);
            }


            if (TimeIn.Value.Hour < 15 && TimeOut.Value.Hour > 15)
            {
                DateTime dt = DateTime.Today.AddHours(15);
                TimeSpan time_use_am = dt - TimeIn.Value;

                if (time_use_am.TotalHours - Math.Floor(time_use_am.TotalHours) <= 0.5)
                {
                    time_am = (float)Math.Floor(time_use_am.TotalHours) + (float)0.5;
                }
                else
                {
                    time_am = (float)Math.Ceiling(time_use_am.TotalHours);
                }

                 time_pm = time - time_am;

                txtTimeAM.Text = Convert.ToString(time_am);
                txtTimePM.Text = Convert.ToString(time_pm);
            }
            else if (TimeOut.Value.Hour <= 15) {
                time_am = time;
                txtTimeAM.Text = Convert.ToString(time_am);
                txtTimePM.Text = Convert.ToString(0);
            }
            else if (TimeIn.Value.Hour >= 15)
            {
                time_pm = time;
                txtTimeAM.Text = Convert.ToString(0);
                txtTimePM.Text = Convert.ToString(time_pm);
            }


            if (TimeIn.Value.DayOfWeek.ToString() == "Sunday" || TimeIn.Value.DayOfWeek.ToString() == "Saturday")
            {
                if (time_pm > 0)
                {
                    chiTietHDBLL.addChiTietHD(MaHD, "2CT2", time_pm, 200000 * time_pm, 200000);
                }
                if (time_am > 0)
                {
                    chiTietHDBLL.addChiTietHD(MaHD, "2CT1", time_am, 170000 * time_am, 170000);
                }
            }
            else 
            {
                if (time_pm > 0)
                {
                    chiTietHDBLL.addChiTietHD(MaHD, "1NT2", time_pm, 180000 * time_pm, 180000);
                }
                if (time_am > 0)
                {
                    chiTietHDBLL.addChiTietHD(MaHD, "1NT1", time_am, 150000 * time_am, 150000);
                }
            }

            listHoaDon.Items.Clear();
            Load_ChiTietHD(MaHD);
            btnEnd.Enabled = false;
            btnPay.Enabled = true;
            btnPay.Tag = MaHD;
            btnPay.Focus();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (txtSDT.Text.ToString() == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại khách hàng.");
                txtSDT.Focus();
            }
            else
            {
                KhachHangBLL khachHangBLL = new KhachHangBLL();
                string TenKH = khachHangBLL.getKhachHang_ByPhone(txtSDT.Text.ToString()).TenKH;
                if (TenKH != null)
                {
                    txtName.Text = TenKH;
                    btnAdd.Enabled = false;
                    btnFind.Enabled = false;
                    btnStart.Focus();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khách hàng.");
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            KhachHangBLL khachHangBLL = new KhachHangBLL();

            if (txtSDT.Text.ToString() == "" || txtName.Text.ToString() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng.");
                txtName.Focus();
            }
            else if (khachHangBLL.check_addKhachHang(txtSDT.Text.ToString()) == false)
            {
                txtSDT.Focus();
                MessageBox.Show("Số điện thoại này đã tồn tại.");
            }
            else
            {
                khachHangBLL.addKhachHang(txtName.Text.ToString(), txtSDT.Text.ToString());
                MessageBox.Show("Thêm khách hàng mới thành công.");
                btnAdd.Enabled = false;
                btnFind.Enabled = false;
            }
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (txtSDT.Text.ToString() == "" || txtName.Text.ToString() == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin khách hàng.");
            }
            else
            {
                KhachHangBLL khachHangBLL = new KhachHangBLL();
                HoaDonBLL hoaDonBLL = new HoaDonBLL();
                SanBLL sanBLL = new SanBLL();

                int MaSan = (int)(sender as Button).Tag;
                int MaKH = khachHangBLL.getKhachHang_ByPhone(txtSDT.Text.ToString()).MaKH;

                hoaDonBLL.addHoaDon(MaSan, MaKH, TimeIn.Value);
                sanBLL.updateSanStatus(MaSan);

                flowLayoutPanel1.Controls.Clear();
                Load_San();
                btnStart.Enabled = false;
                btnEnd.Tag = hoaDonBLL.getHoaDon_ByMaSan(MaSan).MaHD;
                btnCancel.Tag = hoaDonBLL.getHoaDon_ByMaSan(MaSan).MaHD;
                listHoaDon.Tag = hoaDonBLL.getHoaDon_ByMaSan(MaSan).MaHD;
                btnEnd.Enabled = true;
                btnEnd.Focus();
            }
        }

        private void txtKhachDua_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Convert.ToInt32(txtKhachDua.Text.ToString()) < 10000)
                {
                    string tmp = txtKhachDua.Text.ToString() + "000";
                    txtKhachDua.Text = tmp;
                    btnPay.Focus();
                }
            }
            
        }

        private void txtKhachDua_TextChanged(object sender, EventArgs e)
        {
            if(txtKhachDua.Text.ToString() != "")
            {
                int TongTien = Convert.ToInt32(labelTongTien.Text.ToString());
                int KhachDua = Convert.ToInt32(txtKhachDua.Text.ToString());
                int TraLai = KhachDua - TongTien;

                txtTraLai.Text = Convert.ToString(TraLai);
            }
            
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            HoaDonBLL hoaDonBLL = new HoaDonBLL();
            SanBLL sanBLL = new SanBLL();
            ChiTietHDBLL chiTietHDBLL = new ChiTietHDBLL();
            int MaHD = (int)(sender as Button).Tag;
            int MaSan = hoaDonBLL.getHoaDon_ByMaHD(MaHD).MaSan;

            hoaDonBLL.updateHoaDon_ThanhToan(MaHD, TimeOut.Text.ToString(), chiTietHDBLL.getTongTien(MaHD), 1);
            sanBLL.updateSanStatus(MaSan);

            FormHoaDon form4 = new FormHoaDon(MaHD, txtKhachDua.Text.ToString(), txtTraLai.Text.ToString());
            form4.Tag = MaHD;
            form4.ShowDialog();

            flowLayoutPanel1.Controls.Clear();
            Load_San();
            ShowHoaDon(MaSan); 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn huỷ hoá đơn này?", "Xác nhận huỷ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                HoaDonBLL hoaDonBLL = new HoaDonBLL();
                SanBLL sanBLL = new SanBLL();
                ChiTietHDBLL chiTietHDBLL = new ChiTietHDBLL();
                int MaHD = (int)(sender as Button).Tag;
                int MaSan = hoaDonBLL.getHoaDon_ByMaHD(MaHD).MaSan;

                chiTietHDBLL.deleteChiTietHD(MaHD);
                hoaDonBLL.deleteHoaDon(MaHD);
                sanBLL.updateSanStatus(MaSan);

                flowLayoutPanel1.Controls.Clear();
                Load_San();
                ShowHoaDon(MaSan);

                MessageBox.Show("Huỷ hoá đơn thành công");
            }
        }

        private void txtSDT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnFind_Click(sender, e);
            }
        }

        private void listHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listHoaDon.SelectedItems.Count == 0)
            {
                return;
            }
            else
            {
                ChiTietHDBLL chiTietHDBLL = new ChiTietHDBLL();
                SanPhamBLL sanPhamBLL = new SanPhamBLL();

                ListViewItem item = listHoaDon.SelectedItems[0];
                string TenSP = item.SubItems[1].Text;
                int MaHD = (int)(sender as ListView).Tag;
                string MaSP = sanPhamBLL.getSanPham_ByName(TenSP).MaSP;


                chiTietHDBLL.deleteSanPham(MaHD, MaSP);
                listHoaDon.Items.Clear();
                Load_ChiTietHD(MaHD);
            }
        }

        private void labelTongTien_TextChanged(object sender, EventArgs e)
        {
            txtKhachDua.Text = labelTongTien.Text;
        }
    }
}
