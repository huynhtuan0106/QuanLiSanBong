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
using System.Xml.Linq;

namespace GUI
{
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();
            listNV.FullRowSelect = true;
        }

        void Load_NhanVien()
        {
            NhanVienBLL nhanVienBLL = new NhanVienBLL();
            List<NhanVien> list = nhanVienBLL.getAll();
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");

            foreach (NhanVien nhanVien in list)
            {
                ListViewItem item = new ListViewItem();
                item.Text = Convert.ToString(nhanVien.MaNV);
                listNV.Items.Add(item);

                ListViewItem.ListViewSubItem s1 = new ListViewItem.ListViewSubItem(item, nhanVien.TenNV.Trim());
                ListViewItem.ListViewSubItem s3 = new ListViewItem.ListViewSubItem(item, nhanVien.username.Trim());
                ListViewItem.ListViewSubItem s4 = new ListViewItem.ListViewSubItem(item, nhanVien.password.Trim());
                ListViewItem.ListViewSubItem s2 = new ListViewItem.ListViewSubItem(item, nhanVien.SDT.Trim());

                item.SubItems.Add(s1);
                item.SubItems.Add(s2);
                item.SubItems.Add(s3);
                item.SubItems.Add(s4);
            }

            labelSoluong.Text = Convert.ToString(nhanVienBLL.getSoNhanVien());
            
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            Load_NhanVien();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (txtSDT.Text.ToString() == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại nhân viên.");
                txtSDT.Focus();
            }
            else
            {
                NhanVienBLL nhanVienBLL = new NhanVienBLL();
                string TenNV = nhanVienBLL.getNhanVien_ByPhone(txtSDT.Text.ToString()).TenNV;
                string User = nhanVienBLL.getNhanVien_ByPhone(txtSDT.Text.ToString()).username;
                string Pass = nhanVienBLL.getNhanVien_ByPhone(txtSDT.Text.ToString()).password;
                string Phone = nhanVienBLL.getNhanVien_ByPhone(txtSDT.Text.ToString()).SDT;
                btnFix.Tag = nhanVienBLL.getNhanVien_ByPhone(txtSDT.Text.ToString()).MaNV;
                btnDelete.Tag = nhanVienBLL.getNhanVien_ByPhone(txtSDT.Text.ToString()).MaNV;

                if (TenNV != null)
                {
                    txtName.Text = TenNV.Trim();
                    txtUser.Text = User.Trim();
                    txtPass.Text = Pass.Trim();
                    txtSDT.Text = Phone.Trim();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên.");
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NhanVienBLL nhanVienBLL = new NhanVienBLL();

            if (txtSDT.Text.ToString() == "" || txtName.Text.ToString() == "" || txtPass.Text.ToString() == "" || txtUser.Text.ToString() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhân viên.");
            }
            else if (nhanVienBLL.check_addNhanVien(txtUser.Text.ToString(), txtSDT.Text.ToString()) == false)
            {
                txtUser.Focus();
                MessageBox.Show("Tên đăng nhập hoặc số điện thoại đã tồn tại.");
            }
            else
            {
                nhanVienBLL.addNhanVien(txtName.Text.ToString(), txtUser.Text.ToString(), txtPass.Text.ToString(), txtSDT.Text.ToString());
                MessageBox.Show("Thêm nhân viên mới thành công.");
                listNV.Items.Clear();
                txtName.Clear();
                txtPass.Clear();
                txtSDT.Clear();
                txtUser.Clear();
                Load_NhanVien();
            }
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            if (txtSDT.Text.ToString() == "" || txtName.Text.ToString() == "" || txtPass.Text.ToString() == "" || txtUser.Text.ToString() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhân viên.");
            }
            else
            {
                int MaNV = (int)(sender as Button).Tag;
                NhanVienBLL nhanVienBLL = new NhanVienBLL();
                nhanVienBLL.updateNhanVien(MaNV,txtName.Text.ToString(), txtUser.Text.ToString(), txtPass.Text.ToString(), txtSDT.Text.ToString());
                MessageBox.Show("Chỉnh sửa nhân viên mã " + MaNV + " thành công.");
                listNV.Items.Clear();
                listNV.Items.Clear();
                txtName.Clear();
                txtPass.Clear();
                txtSDT.Clear();
                txtUser.Clear();
                Load_NhanVien();
            }
        }

        private void listNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listNV.SelectedItems.Count == 0)
            {
                return;
            }
            else
            {
                ListViewItem item = listNV.SelectedItems[0];
                int MaNV = Convert.ToInt32(item.SubItems[0].Text);
                btnFix.Tag = MaNV;
                btnDelete.Tag = MaNV;

                txtName.Text = item.SubItems[1].Text.ToString();
                txtSDT.Text = item.SubItems[2].Text.ToString();
                txtUser.Text = item.SubItems[3].Text.ToString();
                txtPass.Text = item.SubItems[4].Text.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtSDT.Text.ToString() == "" || txtName.Text.ToString() == "" || txtPass.Text.ToString() == "" || txtUser.Text.ToString() == "")
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xoá.");
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn muốn xoá nhân viên này?", "Xác nhận xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int MaNV = (int)(sender as Button).Tag;
                    NhanVienBLL nhanVienBLL = new NhanVienBLL();
                    nhanVienBLL.delete(MaNV);
                    MessageBox.Show("Xoá nhân viên mã " + MaNV + " thành công.");
                    listNV.Items.Clear();
                    txtName.Clear();
                    txtPass.Clear();
                    txtSDT.Clear();
                    txtUser.Clear();
                    Load_NhanVien();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPass.Clear();
            txtSDT.Clear();
            txtUser.Clear();
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
