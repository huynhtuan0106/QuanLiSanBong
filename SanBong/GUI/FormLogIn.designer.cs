namespace GUI
{
    partial class FormLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogIn));
            this.panel1 = new System.Windows.Forms.Panel();
            this.changePass = new System.Windows.Forms.LinkLabel();
            this.btnOK = new System.Windows.Forms.Button();
            this.radioStaff = new System.Windows.Forms.RadioButton();
            this.radioManage = new System.Windows.Forms.RadioButton();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.changePass);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.radioStaff);
            this.panel1.Controls.Add(this.radioManage);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.txtUser);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(285, 134);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 278);
            this.panel1.TabIndex = 0;
            // 
            // changePass
            // 
            this.changePass.AutoSize = true;
            this.changePass.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.changePass.LinkColor = System.Drawing.Color.Black;
            this.changePass.Location = new System.Drawing.Point(135, 247);
            this.changePass.Name = "changePass";
            this.changePass.Size = new System.Drawing.Size(87, 17);
            this.changePass.TabIndex = 7;
            this.changePass.TabStop = true;
            this.changePass.Text = "Đổi mật khẩu";
            this.changePass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.changePass_LinkClicked);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOK.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(125, 212);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(110, 29);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // radioStaff
            // 
            this.radioStaff.AutoSize = true;
            this.radioStaff.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioStaff.Location = new System.Drawing.Point(63, 185);
            this.radioStaff.Name = "radioStaff";
            this.radioStaff.Size = new System.Drawing.Size(58, 21);
            this.radioStaff.TabIndex = 5;
            this.radioStaff.TabStop = true;
            this.radioStaff.Text = "Staff";
            this.radioStaff.UseVisualStyleBackColor = true;
            // 
            // radioManage
            // 
            this.radioManage.AutoSize = true;
            this.radioManage.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioManage.Location = new System.Drawing.Point(221, 185);
            this.radioManage.Name = "radioManage";
            this.radioManage.Size = new System.Drawing.Size(77, 21);
            this.radioManage.TabIndex = 4;
            this.radioManage.TabStop = true;
            this.radioManage.Text = "Manage";
            this.radioManage.UseVisualStyleBackColor = true;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(63, 154);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(236, 25);
            this.txtPass.TabIndex = 3;
            this.txtPass.Text = "123456";
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPass_KeyDown);
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(63, 92);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(236, 30);
            this.txtUser.TabIndex = 2;
            this.txtUser.Text = "tuan1234";
            this.txtUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUser_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(285, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(369, 53);
            this.panel2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Broadway", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(14, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "LOGIN";
            // 
            // FormLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(920, 520);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BT Football";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioManage;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.RadioButton radioStaff;
        private System.Windows.Forms.LinkLabel changePass;
    }
}

