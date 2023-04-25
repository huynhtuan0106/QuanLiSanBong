using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace GUI
{
    public partial class FormConfig : Form
    {
        public FormConfig()
        {
            InitializeComponent();
        }

        private void checkWindow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkWindow.Checked == true)
            {
                txtUid.Enabled = false;
                txtPwd.Enabled = false;
            }
            else
            {
                txtUid.Enabled = true;
                txtPwd.Enabled = true;
                txtServer.Focus();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("config.txt");
            if (checkWindow.Checked == true)
            {
                sw.WriteLine("window");
                sw.WriteLine(txtServer.Text);
                sw.Write(txtData.Text);

            }
            else
            {
                sw.WriteLine("sql");
                sw.WriteLine(txtServer.Text);
                sw.WriteLine(txtData.Text);
                sw.WriteLine(txtUid.Text);
                sw.Write(txtPwd.Text);

            }
            sw.Close();
            this.Close();
        }
    }
}
