using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormKhachHang : Form
    {
        public FormKhachHang()
        {
            InitializeComponent();
            listKH.FullRowSelect = true;
        }

        void Load_KhachHang()
        {
            KhachHangBLL khachHangBLL = new KhachHangBLL();
            List<KhachHang> list = khachHangBLL.getAll();
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");

            foreach (KhachHang khachHang in list)
            {
                ListViewItem item = new ListViewItem();
                item.Text = Convert.ToString(khachHang.MaKH);
                listKH.Items.Add(item);

                ListViewItem.ListViewSubItem s1 = new ListViewItem.ListViewSubItem(item, khachHang.TenKH.Trim());
                ListViewItem.ListViewSubItem s2 = new ListViewItem.ListViewSubItem(item, khachHang.Phone.Trim());

                item.SubItems.Add(s1);
                item.SubItems.Add(s2);
            }

            labelSoluong.Text = Convert.ToString(khachHangBLL.getSoKhachHang());

        }

        private void listKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listKH.SelectedItems.Count == 0)
            {
                return;
            }
            else
            {
                ListViewItem item = listKH.SelectedItems[0];
                int MaKH = Convert.ToInt32(item.SubItems[0].Text);
                btnFix.Tag = MaKH;
                btnDelete.Tag = MaKH;

                txtName.Text = item.SubItems[1].Text.ToString();
                txtSDT.Text = item.SubItems[2].Text.ToString();
            }
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            Load_KhachHang();
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
                string TenNV = khachHangBLL.getKhachHang_ByPhone(txtSDT.Text.ToString()).TenKH;
                string Phone = khachHangBLL.getKhachHang_ByPhone(txtSDT.Text.ToString()).Phone;
                btnFix.Tag = khachHangBLL.getKhachHang_ByPhone(txtSDT.Text.ToString()).MaKH;
                btnDelete.Tag = khachHangBLL.getKhachHang_ByPhone(txtSDT.Text.ToString()).MaKH;

                if (TenNV != null)
                {
                    txtName.Text = TenNV.Trim();
                    txtSDT.Text = Phone.Trim();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khách hàng.");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtSDT.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            KhachHangBLL khachHangBLL = new KhachHangBLL();

            if (txtSDT.Text.ToString() == "" || txtName.Text.ToString() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng.");
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
                listKH.Items.Clear();
                txtName.Clear();
                txtSDT.Clear();
                Load_KhachHang();
            }
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            if (txtSDT.Text.ToString() == "" || txtName.Text.ToString() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng.");
            }
            else
            {
                int MaKH = (int)(sender as Button).Tag;
                KhachHangBLL khachHangBLL = new KhachHangBLL();
                khachHangBLL.updateKhachHang(MaKH, txtName.Text.ToString(), txtSDT.Text.ToString());
                MessageBox.Show("Chỉnh sửa khách hàng mã " + MaKH + " thành công.");
                listKH.Items.Clear();
                txtName.Clear();
                txtSDT.Clear();
                Load_KhachHang();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtSDT.Text.ToString() == "" || txtName.Text.ToString() == "")
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xoá.");
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn muốn xoá khách hàng này?", "Xác nhận xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int MaKH = (int)(sender as Button).Tag;
                    KhachHangBLL khachHangBLL = new KhachHangBLL();
                    khachHangBLL.delete(MaKH);
                    MessageBox.Show("Xoá khách hàng mã " + MaKH + " thành công.");
                    listKH.Items.Clear();
                    txtName.Clear();
                    txtSDT.Clear();
                    Load_KhachHang();
                }
            }
        }

        private void txtSDT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnFind_Click(sender, e);
            }
        }
    }
}
