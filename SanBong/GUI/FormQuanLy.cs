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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormQuanLy : Form
    {
        public FormQuanLy()
        {
            InitializeComponent();
            FormDoanhThu form7 = new FormDoanhThu();
            form7.TopLevel = false;
            panel2.Controls.Add(form7);
            form7.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form7.Dock = DockStyle.Fill;
            form7.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            FormDoanhThu form7 = new FormDoanhThu();
            form7.TopLevel = false;
            panel2.Controls.Add(form7);
            form7.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form7.Dock = DockStyle.Fill;
            form7.Show();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            FormNhanVien form6 = new FormNhanVien();
            form6.TopLevel = false;
            panel2.Controls.Add(form6);
            form6.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form6.Dock = DockStyle.Fill;
            form6.Show();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            FormKhachHang form8 = new FormKhachHang();
            form8.TopLevel = false;
            panel2.Controls.Add(form8);
            form8.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form8.Dock = DockStyle.Fill;
            form8.Show();
        }
    }
}
