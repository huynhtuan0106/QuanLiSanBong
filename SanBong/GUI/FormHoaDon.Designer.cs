namespace GUI
{
    partial class FormHoaDon
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
            this.btnDong = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSDT = new System.Windows.Forms.Label();
            this.labelSan = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelTraLai = new System.Windows.Forms.Label();
            this.labelKhachDua = new System.Windows.Forms.Label();
            this.labelTongTien = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ListHoaDon = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnThanhTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(260, 25);
            this.btnDong.Margin = new System.Windows.Forms.Padding(4);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(222, 48);
            this.btnDong.TabIndex = 4;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(18, 25);
            this.btnIn.Margin = new System.Windows.Forms.Padding(4);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(222, 48);
            this.btnIn.TabIndex = 0;
            this.btnIn.Text = "In hoá đơn";
            this.btnIn.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDong);
            this.groupBox3.Controls.Add(this.btnIn);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox3.Location = new System.Drawing.Point(13, 640);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(496, 87);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelDate);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Controls.Add(this.labelSDT);
            this.groupBox1.Controls.Add(this.labelSan);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 63);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(496, 147);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(235, 53);
            this.labelDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(25, 22);
            this.labelDate.TabIndex = 10;
            this.labelDate.Text = "...";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(235, 83);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(25, 22);
            this.labelName.TabIndex = 9;
            this.labelName.Text = "...";
            // 
            // labelSDT
            // 
            this.labelSDT.AutoSize = true;
            this.labelSDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSDT.Location = new System.Drawing.Point(235, 113);
            this.labelSDT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSDT.Name = "labelSDT";
            this.labelSDT.Size = new System.Drawing.Size(25, 22);
            this.labelSDT.TabIndex = 8;
            this.labelSDT.Text = "...";
            // 
            // labelSan
            // 
            this.labelSan.AutoSize = true;
            this.labelSan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSan.Location = new System.Drawing.Point(236, 27);
            this.labelSan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSan.Name = "labelSan";
            this.labelSan.Size = new System.Drawing.Size(25, 22);
            this.labelSan.TabIndex = 7;
            this.labelSan.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 53);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ngày in:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên khách hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số điện thoại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sân:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(117, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "HÓA ĐƠN THANH TOÁN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelTraLai);
            this.groupBox2.Controls.Add(this.labelKhachDua);
            this.groupBox2.Controls.Add(this.labelTongTien);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.ListHoaDon);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 218);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(496, 414);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết hoá đơn";
            // 
            // labelTraLai
            // 
            this.labelTraLai.AutoSize = true;
            this.labelTraLai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTraLai.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelTraLai.Location = new System.Drawing.Point(294, 375);
            this.labelTraLai.Name = "labelTraLai";
            this.labelTraLai.Size = new System.Drawing.Size(25, 22);
            this.labelTraLai.TabIndex = 30;
            this.labelTraLai.Text = "...";
            // 
            // labelKhachDua
            // 
            this.labelKhachDua.AutoSize = true;
            this.labelKhachDua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKhachDua.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelKhachDua.Location = new System.Drawing.Point(295, 342);
            this.labelKhachDua.Name = "labelKhachDua";
            this.labelKhachDua.Size = new System.Drawing.Size(25, 22);
            this.labelKhachDua.TabIndex = 29;
            this.labelKhachDua.Text = "...";
            // 
            // labelTongTien
            // 
            this.labelTongTien.AutoSize = true;
            this.labelTongTien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTongTien.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelTongTien.Location = new System.Drawing.Point(295, 311);
            this.labelTongTien.Name = "labelTongTien";
            this.labelTongTien.Size = new System.Drawing.Size(25, 22);
            this.labelTongTien.TabIndex = 28;
            this.labelTongTien.Text = "...";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(34, 375);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 22);
            this.label9.TabIndex = 27;
            this.label9.Text = "Trả lại:";
            // 
            // ListHoaDon
            // 
            this.ListHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnSL,
            this.columnThanhTien});
            this.ListHoaDon.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListHoaDon.GridLines = true;
            this.ListHoaDon.HideSelection = false;
            this.ListHoaDon.Location = new System.Drawing.Point(18, 30);
            this.ListHoaDon.Name = "ListHoaDon";
            this.ListHoaDon.Size = new System.Drawing.Size(464, 263);
            this.ListHoaDon.TabIndex = 0;
            this.ListHoaDon.UseCompatibleStateImageBehavior = false;
            this.ListHoaDon.View = System.Windows.Forms.View.Details;
            // 
            // columnName
            // 
            this.columnName.Text = "Tên sản phẩm";
            this.columnName.Width = 225;
            // 
            // columnSL
            // 
            this.columnSL.Text = "SL";
            this.columnSL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnSL.Width = 40;
            // 
            // columnThanhTien
            // 
            this.columnThanhTien.Text = "Thành Tiền";
            this.columnThanhTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnThanhTien.Width = 80;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(35, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 22);
            this.label8.TabIndex = 26;
            this.label8.Text = "Khách đưa:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(35, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 22);
            this.label7.TabIndex = 25;
            this.label7.Text = "Tổng tiền:";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(526, 735);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hoá đơn thanh toán";
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView ListHoaDon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSDT;
        private System.Windows.Forms.Label labelSan;
        private System.Windows.Forms.Label labelTraLai;
        private System.Windows.Forms.Label labelKhachDua;
        private System.Windows.Forms.Label labelTongTien;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnSL;
        private System.Windows.Forms.ColumnHeader columnThanhTien;
    }
}