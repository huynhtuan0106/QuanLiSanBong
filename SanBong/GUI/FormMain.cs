using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace GUI
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        public FormMain(int tmp) : this()
        {

            if (tmp == 0)
            {
                Report_menu.Enabled = false;
                Main_Load();
            }
            else
            {
                Report_menu.Enabled = true;
                Main_Load();
            }
            
        }

        void Main_Load()
        {
            FormTrangChu form3 = new FormTrangChu();
            form3.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(form3);
            form3.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form3.Dock = DockStyle.Fill;
            form3.Show();
        }

        private void Main_menu_Click(object sender, EventArgs e)
        {
            Main_Load();
        }

        void Report_Load()
        {
            FormQuanLy form5 = new FormQuanLy();
            form5.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(form5);
            form5.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form5.Dock = DockStyle.Fill;
            form5.Show();
        }

        private void Report_menu_Click(object sender, EventArgs e)
        {
            Report_Load();
        }

        private void LogOut_Menu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn đăng xuất khỏi hệ thống?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                FormLogIn form1 = new FormLogIn();
                form1.ShowDialog();
                this.Close();
            }
        }
    }
}
