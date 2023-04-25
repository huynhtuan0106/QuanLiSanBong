namespace GUI
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Main_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Report_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.LogOut_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1496, 701);
            this.panel1.TabIndex = 1;
            // 
            // Main_menu
            // 
            this.Main_menu.Name = "Main_menu";
            this.Main_menu.Size = new System.Drawing.Size(87, 24);
            this.Main_menu.Text = "Trang chủ";
            this.Main_menu.Click += new System.EventHandler(this.Main_menu_Click);
            // 
            // Report_menu
            // 
            this.Report_menu.Name = "Report_menu";
            this.Report_menu.Size = new System.Drawing.Size(73, 24);
            this.Report_menu.Text = "Quản lý";
            this.Report_menu.Click += new System.EventHandler(this.Report_menu_Click);
            // 
            // LogOut_Menu
            // 
            this.LogOut_Menu.Name = "LogOut_Menu";
            this.LogOut_Menu.Size = new System.Drawing.Size(91, 24);
            this.LogOut_Menu.Text = "Đăng xuất";
            this.LogOut_Menu.Click += new System.EventHandler(this.LogOut_Menu_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Main_menu,
            this.Report_menu,
            this.LogOut_Menu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1495, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1495, 731);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BT Football";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem Main_menu;
        private System.Windows.Forms.ToolStripMenuItem Report_menu;
        private System.Windows.Forms.ToolStripMenuItem LogOut_Menu;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}