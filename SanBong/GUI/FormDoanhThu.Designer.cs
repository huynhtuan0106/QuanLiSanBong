namespace GUI
{
    partial class FormDoanhThu
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
            this.listHD = new System.Windows.Forms.ListView();
            this.colMaHD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenKH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGioVao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGioRa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelHoaDon = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelTongChi = new System.Windows.Forms.Label();
            this.labelSoSan = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelTongThu = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TimeEnd = new System.Windows.Forms.DateTimePicker();
            this.TimeStart = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listHD
            // 
            this.listHD.BackColor = System.Drawing.SystemColors.Window;
            this.listHD.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaHD,
            this.colSan,
            this.colTenKH,
            this.colGioVao,
            this.colGioRa,
            this.colTong});
            this.listHD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listHD.GridLines = true;
            this.listHD.HideSelection = false;
            this.listHD.Location = new System.Drawing.Point(386, 22);
            this.listHD.Name = "listHD";
            this.listHD.Size = new System.Drawing.Size(801, 624);
            this.listHD.TabIndex = 22;
            this.listHD.UseCompatibleStateImageBehavior = false;
            this.listHD.View = System.Windows.Forms.View.Details;
            this.listHD.SelectedIndexChanged += new System.EventHandler(this.listHD_SelectedIndexChanged_1);
            // 
            // colMaHD
            // 
            this.colMaHD.Text = "Mã ";
            this.colMaHD.Width = 50;
            // 
            // colSan
            // 
            this.colSan.DisplayIndex = 2;
            this.colSan.Text = "Sân";
            this.colSan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colSan.Width = 70;
            // 
            // colTenKH
            // 
            this.colTenKH.DisplayIndex = 1;
            this.colTenKH.Text = "Tên khách hàng";
            this.colTenKH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colTenKH.Width = 170;
            // 
            // colGioVao
            // 
            this.colGioVao.Text = "Giờ vào";
            this.colGioVao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colGioVao.Width = 190;
            // 
            // colGioRa
            // 
            this.colGioRa.Text = "Giờ ra";
            this.colGioRa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colGioRa.Width = 190;
            // 
            // colTong
            // 
            this.colTong.Text = "Tổng tiền";
            this.colTong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colTong.Width = 100;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.labelHoaDon);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.labelTongChi);
            this.groupBox2.Controls.Add(this.labelSoSan);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.labelTongThu);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(12, 244);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 402);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tổng quan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(18, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 22);
            this.label2.TabIndex = 36;
            this.label2.Text = "Số sân:";
            // 
            // labelHoaDon
            // 
            this.labelHoaDon.AutoSize = true;
            this.labelHoaDon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoaDon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelHoaDon.Location = new System.Drawing.Point(136, 141);
            this.labelHoaDon.Name = "labelHoaDon";
            this.labelHoaDon.Size = new System.Drawing.Size(25, 22);
            this.labelHoaDon.TabIndex = 39;
            this.labelHoaDon.Text = "...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(18, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 22);
            this.label7.TabIndex = 31;
            this.label7.Text = "Tổng thu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(18, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 22);
            this.label6.TabIndex = 37;
            this.label6.Text = "Hoá đơn:";
            // 
            // labelTongChi
            // 
            this.labelTongChi.AutoSize = true;
            this.labelTongChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTongChi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelTongChi.Location = new System.Drawing.Point(136, 75);
            this.labelTongChi.Name = "labelTongChi";
            this.labelTongChi.Size = new System.Drawing.Size(25, 22);
            this.labelTongChi.TabIndex = 35;
            this.labelTongChi.Text = "...";
            // 
            // labelSoSan
            // 
            this.labelSoSan.AutoSize = true;
            this.labelSoSan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoSan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelSoSan.Location = new System.Drawing.Point(136, 108);
            this.labelSoSan.Name = "labelSoSan";
            this.labelSoSan.Size = new System.Drawing.Size(25, 22);
            this.labelSoSan.TabIndex = 38;
            this.labelSoSan.Text = "...";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(18, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 22);
            this.label8.TabIndex = 32;
            this.label8.Tag = "";
            this.label8.Text = "Tổng chi:";
            // 
            // labelTongThu
            // 
            this.labelTongThu.AutoSize = true;
            this.labelTongThu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTongThu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelTongThu.Location = new System.Drawing.Point(136, 41);
            this.labelTongThu.Name = "labelTongThu";
            this.labelTongThu.Size = new System.Drawing.Size(25, 22);
            this.labelTongThu.TabIndex = 34;
            this.labelTongThu.Text = "...";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TimeEnd);
            this.groupBox1.Controls.Add(this.TimeStart);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 213);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Khoảng thời gian";
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnFind.Location = new System.Drawing.Point(18, 156);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(301, 34);
            this.btnFind.TabIndex = 19;
            this.btnFind.Text = "Tìm kiếm";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(17, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Từ ngày:";
            // 
            // TimeEnd
            // 
            this.TimeEnd.CustomFormat = "HH:mm:ss MM/dd/yyyy";
            this.TimeEnd.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimeEnd.Location = new System.Drawing.Point(19, 110);
            this.TimeEnd.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.TimeEnd.Name = "TimeEnd";
            this.TimeEnd.Size = new System.Drawing.Size(300, 27);
            this.TimeEnd.TabIndex = 16;
            this.TimeEnd.Value = System.DateTime.Now;
            // 
            // TimeStart
            // 
            this.TimeStart.CustomFormat = "HH:mm:ss MM/dd/yyyy";
            this.TimeStart.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimeStart.Location = new System.Drawing.Point(19, 54);
            this.TimeStart.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.TimeStart.Name = "TimeStart";
            this.TimeStart.Size = new System.Drawing.Size(300, 27);
            this.TimeStart.TabIndex = 15;
            this.TimeStart.Value = new System.DateTime(2022, 11, 30, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(18, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Đến ngày:";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 748);
            this.Controls.Add(this.listHD);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listHD;
        private System.Windows.Forms.ColumnHeader colMaHD;
        private System.Windows.Forms.ColumnHeader colSan;
        private System.Windows.Forms.ColumnHeader colTenKH;
        private System.Windows.Forms.ColumnHeader colGioVao;
        private System.Windows.Forms.ColumnHeader colGioRa;
        private System.Windows.Forms.ColumnHeader colTong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelHoaDon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelTongChi;
        private System.Windows.Forms.Label labelSoSan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelTongThu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker TimeEnd;
        private System.Windows.Forms.DateTimePicker TimeStart;
        private System.Windows.Forms.Label label3;
    }
}