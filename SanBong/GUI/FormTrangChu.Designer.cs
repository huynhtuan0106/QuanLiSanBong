using System;
using System.Threading;
using System.Windows.Forms;

namespace GUI
{
    partial class FormTrangChu
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab3 = new System.Windows.Forms.TabPage();
            this.listHoaDon = new System.Windows.Forms.ListView();
            this.columnSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelTongTien = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelTongTien2 = new System.Windows.Forms.Label();
            this.txtTraLai = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtKhachDua = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTimePM = new System.Windows.Forms.TextBox();
            this.TimeIn = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTimeAM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TimeOut = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tab1.SuspendLayout();
            this.tab2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.splitContainer1.Panel1.Controls.Add(this.tabControl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1497, 699);
            this.splitContainer1.SplitterDistance = 497;
            this.splitContainer1.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tab1);
            this.tabControl.Controls.Add(this.tab2);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(3, 1);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(501, 698);
            this.tabControl.TabIndex = 0;
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.flowLayoutPanel1);
            this.tab1.Location = new System.Drawing.Point(4, 27);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(493, 667);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "Chọn sân";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(490, 666);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tab2
            // 
            this.tab2.Controls.Add(this.flowLayoutPanel2);
            this.tab2.Location = new System.Drawing.Point(4, 27);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(3);
            this.tab2.Size = new System.Drawing.Size(493, 667);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "Dịch vụ";
            this.tab2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(1, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(488, 668);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(995, 698);
            this.tabControl1.TabIndex = 0;
            // 
            // tab3
            // 
            this.tab3.Controls.Add(this.listHoaDon);
            this.tab3.Controls.Add(this.groupBox3);
            this.tab3.Controls.Add(this.groupBox2);
            this.tab3.Controls.Add(this.label2);
            this.tab3.Controls.Add(this.label1);
            this.tab3.Controls.Add(this.groupBox1);
            this.tab3.Location = new System.Drawing.Point(4, 27);
            this.tab3.Name = "tab3";
            this.tab3.Padding = new System.Windows.Forms.Padding(3);
            this.tab3.Size = new System.Drawing.Size(987, 667);
            this.tab3.TabIndex = 0;
            this.tab3.Text = "Hoá đơn";
            this.tab3.UseVisualStyleBackColor = true;
            this.tab3.Click += new System.EventHandler(this.tab3_Click);
            // 
            // listHoaDon
            // 
            this.listHoaDon.BackColor = System.Drawing.Color.White;
            this.listHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnSTT,
            this.columnTen,
            this.columnSL,
            this.columnGia,
            this.columnTien});
            this.listHoaDon.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listHoaDon.GridLines = true;
            this.listHoaDon.HideSelection = false;
            this.listHoaDon.Location = new System.Drawing.Point(20, 135);
            this.listHoaDon.Name = "listHoaDon";
            this.listHoaDon.Size = new System.Drawing.Size(571, 512);
            this.listHoaDon.TabIndex = 26;
            this.listHoaDon.UseCompatibleStateImageBehavior = false;
            this.listHoaDon.View = System.Windows.Forms.View.Details;
            this.listHoaDon.SelectedIndexChanged += new System.EventHandler(this.listHoaDon_SelectedIndexChanged);
            // 
            // columnSTT
            // 
            this.columnSTT.Text = "STT";
            this.columnSTT.Width = 47;
            // 
            // columnTen
            // 
            this.columnTen.Text = "Tên sản phẩm";
            this.columnTen.Width = 175;
            // 
            // columnSL
            // 
            this.columnSL.Text = "SL";
            this.columnSL.Width = 35;
            // 
            // columnGia
            // 
            this.columnGia.Text = "Đơn giá";
            this.columnGia.Width = 80;
            // 
            // columnTien
            // 
            this.columnTien.Text = "Thành tiền";
            this.columnTien.Width = 90;
            // 
            // labelTongTien
            // 
            this.labelTongTien.AutoSize = true;
            this.labelTongTien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTongTien.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelTongTien.Location = new System.Drawing.Point(203, 49);
            this.labelTongTien.Name = "labelTongTien";
            this.labelTongTien.Size = new System.Drawing.Size(25, 22);
            this.labelTongTien.TabIndex = 29;
            this.labelTongTien.Text = "...";
            this.labelTongTien.TextChanged += new System.EventHandler(this.labelTongTien_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelTongTien2);
            this.groupBox3.Controls.Add(this.labelTongTien);
            this.groupBox3.Controls.Add(this.txtTraLai);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtKhachDua);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.btnCancel);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.btnPay);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox3.Location = new System.Drawing.Point(621, 385);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(336, 263);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thanh toán";
            // 
            // labelTongTien2
            // 
            this.labelTongTien2.AutoSize = true;
            this.labelTongTien2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTongTien2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelTongTien2.Location = new System.Drawing.Point(114, 49);
            this.labelTongTien2.Name = "labelTongTien2";
            this.labelTongTien2.Size = new System.Drawing.Size(25, 22);
            this.labelTongTien2.TabIndex = 30;
            this.labelTongTien2.Text = "...";
            // 
            // txtTraLai
            // 
            this.txtTraLai.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTraLai.Location = new System.Drawing.Point(118, 138);
            this.txtTraLai.Name = "txtTraLai";
            this.txtTraLai.Size = new System.Drawing.Size(200, 27);
            this.txtTraLai.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(14, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 19);
            this.label9.TabIndex = 24;
            this.label9.Text = "Trả lại:";
            // 
            // txtKhachDua
            // 
            this.txtKhachDua.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKhachDua.Location = new System.Drawing.Point(118, 91);
            this.txtKhachDua.Name = "txtKhachDua";
            this.txtKhachDua.Size = new System.Drawing.Size(200, 27);
            this.txtKhachDua.TabIndex = 21;
            this.txtKhachDua.TextChanged += new System.EventHandler(this.txtKhachDua_TextChanged);
            this.txtKhachDua.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKhachDua_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(14, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 19);
            this.label8.TabIndex = 22;
            this.label8.Text = "Khách đưa:";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCancel.Location = new System.Drawing.Point(175, 198);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(143, 46);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Huỷ hoá đơn";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(14, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "Tổng tiền:";
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnPay.Location = new System.Drawing.Point(18, 198);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(143, 46);
            this.btnPay.TabIndex = 23;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnStart);
            this.groupBox2.Controls.Add(this.btnEnd);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtTimePM);
            this.groupBox2.Controls.Add(this.TimeIn);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtTimeAM);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TimeOut);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(621, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 347);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giờ sử dụng sân";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnStart.Location = new System.Drawing.Point(18, 281);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(143, 46);
            this.btnStart.TabIndex = 18;
            this.btnStart.Text = "Thuê sân";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnd.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnEnd.Location = new System.Drawing.Point(175, 281);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(143, 46);
            this.btnEnd.TabIndex = 19;
            this.btnEnd.Text = "Trả sân";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(16, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Giờ vào sân:";
            // 
            // txtTimePM
            // 
            this.txtTimePM.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimePM.Location = new System.Drawing.Point(18, 230);
            this.txtTimePM.Name = "txtTimePM";
            this.txtTimePM.Size = new System.Drawing.Size(300, 27);
            this.txtTimePM.TabIndex = 16;
            // 
            // TimeIn
            // 
            this.TimeIn.CustomFormat = "HH:mm:ss MM/dd/yyyy";
            this.TimeIn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimeIn.Location = new System.Drawing.Point(18, 54);
            this.TimeIn.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.TimeIn.Name = "TimeIn";
            this.TimeIn.Size = new System.Drawing.Size(300, 27);
            this.TimeIn.TabIndex = 11;
            this.TimeIn.Value = new System.DateTime(2022, 11, 24, 11, 24, 58, 550);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(19, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Số giờ chiều:";
            // 
            // txtTimeAM
            // 
            this.txtTimeAM.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeAM.Location = new System.Drawing.Point(18, 170);
            this.txtTimeAM.Name = "txtTimeAM";
            this.txtTimeAM.Size = new System.Drawing.Size(300, 27);
            this.txtTimeAM.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(17, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Giờ trả sân:";
            // 
            // TimeOut
            // 
            this.TimeOut.CustomFormat = "HH:mm:ss MM/dd/yyyy";
            this.TimeOut.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimeOut.Location = new System.Drawing.Point(18, 110);
            this.TimeOut.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.TimeOut.Name = "TimeOut";
            this.TimeOut.Size = new System.Drawing.Size(300, 27);
            this.TimeOut.TabIndex = 12;
            this.TimeOut.Value = new System.DateTime(2022, 11, 24, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(18, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Số giờ sáng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "SĐT:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(20, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 94);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Khách hàng";
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(57, 24);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(301, 27);
            this.txtSDT.TabIndex = 0;
            this.txtSDT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSDT_KeyDown);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(57, 54);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(301, 27);
            this.txtName.TabIndex = 1;
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(364, 23);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(89, 58);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Tìm kiếm";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(459, 22);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(97, 59);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Thêm KH";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1497, 699);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tab2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tab3.ResumeLayout(false);
            this.tab3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion



        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTimePM;
        private System.Windows.Forms.DateTimePicker TimeIn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTimeAM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker TimeOut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnAdd;
        private GroupBox groupBox3;
        private TextBox txtTraLai;
        private Label label9;
        private TextBox txtKhachDua;
        private Label label8;
        private Button btnCancel;
        private Label label7;
        private Button btnPay;
        private Button btnStart;
        private ListView listHoaDon;
        private ColumnHeader columnSTT;
        private ColumnHeader columnTen;
        private ColumnHeader columnSL;
        private ColumnHeader columnGia;
        private ColumnHeader columnTien;
        private Label labelTongTien;
        private Label labelTongTien2;
    }
}