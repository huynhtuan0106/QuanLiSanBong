using DTO;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GUI
{
    public partial class FormDoiMatKhau : Form
    {
        public FormDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            NhanVienBLL nhanVienBLL = new NhanVienBLL();
            string user = txtUser.Text;
            string phone = txtSDT.Text;
            string passCu = txtPassCu.Text;
            string passMoi = txtPassMoi.Text;
            string passMoi2 = txtPassMoi2.Text;

            if (user == "" || passCu == "" || passMoi == "" || passMoi2 == "" || phone == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
            }
            else if (passMoi.Equals(passMoi2) == false)
            {
                MessageBox.Show("Xác nhận mật khẩu không đúng.");
            }
            else if (nhanVienBLL.check_changePassword(user, phone, passCu) == false)
            {
                MessageBox.Show("Thông tin nhân viên không trùng khớp.");
            }
            else
            {
                nhanVienBLL.changePassword(user,phone,passCu,passMoi);
                MessageBox.Show("Đổi mật khẩu thành công.");
                this.Close();
            }
        }
    }
}
