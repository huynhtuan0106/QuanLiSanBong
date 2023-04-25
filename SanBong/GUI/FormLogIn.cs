using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BLL;
using System.IO;

namespace GUI
{
    public partial class FormLogIn : Form
    {

        public FormLogIn()
        {
            InitializeComponent();
        }

        public bool readConfigFile()
        {
            if (File.Exists("config.txt"))
            {
                StreamReader sr = new StreamReader("config.txt");
                string s = sr.ReadLine();
                Program.server = sr.ReadLine();
                Program.db = sr.ReadLine();
                if (s.Equals("sql"))
                {
                    Program.uid = sr.ReadLine();
                    Program.pwd = sr.ReadLine();
                }

                sr.Close();
                return true;
            }
            else
            {
                MessageBox.Show("Tập tin cấu hình không tồn tại.");
                return false;
            }
        }

        public void signin()
        {
            if (readConfigFile() == false)
            {
                FormConfig f = new FormConfig();
                f.ShowDialog();
            }
            else
            {
                try
                {
                    NhanVienBLL nhanVienBLL = new NhanVienBLL();
                    QuanLyBLL quanLyBLL = new QuanLyBLL();
                    string user = txtUser.Text;
                    string pass = txtPass.Text;

                    if (radioStaff.Checked == true)
                    {
                        if (user == "")
                        {
                            MessageBox.Show("Vui lòng nhập tên đăng nhập.");
                        }
                        else if (pass == "")
                        {
                            MessageBox.Show("Vui lòng nhập mật khẩu.");
                        }
                        else if (nhanVienBLL.getNhanVien_Login(user, pass) == true)
                        {
                            this.Hide();
                            FormMain form2 = new FormMain(0);
                            form2.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.");
                        }
                    }
                    else
                    {
                        if (user == "")
                        {
                            MessageBox.Show("Vui lòng nhập tên đăng nhập.");
                        }
                        else if (pass == "")
                        {
                            MessageBox.Show("Vui lòng nhập mật khẩu.");
                        }
                        else if (quanLyBLL.getQuanLy_Login(user, pass) == true)
                        {
                            this.Hide();
                            FormMain form2 = new FormMain(1);
                            form2.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi. Vui lòng cấu hình lại hệ thống.");
                    FormConfig f = new FormConfig();
                    f.ShowDialog();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioManage.Checked = true;
            txtUser.Focus();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            signin();
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnOK_Click(sender, e);
            }
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOK_Click(sender, e);
            }
        }

        private void changePass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormDoiMatKhau f = new FormDoiMatKhau();
            f.ShowDialog();
        }
    }

}