﻿
namespace Beverage_Manager
{
    partial class ucDonHang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDonHang));
            this.dgvDonHang = new Guna.UI2.WinForms.Guna2DataGridView();
            this.clMaDH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clThuNgan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtTimDH = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.DH_btnXemCTDonHang = new Guna.UI2.WinForms.Guna2Button();
            this.btnBanHang = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.DTP_DH_TUNGAY = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.DTP_DH_DENNGAY = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnTimDH = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnXemDHTheoNgay = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDonHang
            // 
            this.dgvDonHang.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvDonHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDonHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDonHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvDonHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDonHang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDonHang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDonHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDonHang.ColumnHeadersHeight = 40;
            this.dgvDonHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaDH,
            this.clNgayLap,
            this.clKhachHang,
            this.clThuNgan,
            this.clTongTien});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDonHang.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDonHang.EnableHeadersVisualStyles = false;
            this.dgvDonHang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDonHang.Location = new System.Drawing.Point(0, 142);
            this.dgvDonHang.Name = "dgvDonHang";
            this.dgvDonHang.RowHeadersVisible = false;
            this.dgvDonHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDonHang.Size = new System.Drawing.Size(1003, 514);
            this.dgvDonHang.TabIndex = 31;
            this.dgvDonHang.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDonHang.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDonHang.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDonHang.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDonHang.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDonHang.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDonHang.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDonHang.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDonHang.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDonHang.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvDonHang.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDonHang.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDonHang.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvDonHang.ThemeStyle.ReadOnly = false;
            this.dgvDonHang.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDonHang.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDonHang.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvDonHang.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDonHang.ThemeStyle.RowsStyle.Height = 22;
            this.dgvDonHang.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDonHang.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDonHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDonHang_CellClick);
            this.dgvDonHang.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvDonHang_RowsAdded_1);
            // 
            // clMaDH
            // 
            this.clMaDH.HeaderText = "Mã đơn hàng";
            this.clMaDH.Name = "clMaDH";
            // 
            // clNgayLap
            // 
            this.clNgayLap.HeaderText = "Ngày lập";
            this.clNgayLap.Name = "clNgayLap";
            // 
            // clKhachHang
            // 
            this.clKhachHang.HeaderText = "Khách hàng";
            this.clKhachHang.Name = "clKhachHang";
            // 
            // clThuNgan
            // 
            this.clThuNgan.HeaderText = "Thu Ngân";
            this.clThuNgan.Name = "clThuNgan";
            // 
            // clTongTien
            // 
            this.clTongTien.HeaderText = "Tổng tiền";
            this.clTongTien.Name = "clTongTien";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đơn hàng";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(228)))));
            this.guna2Panel3.Controls.Add(this.label1);
            this.guna2Panel3.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel3.Location = new System.Drawing.Point(0, 100);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(1003, 42);
            this.guna2Panel3.TabIndex = 29;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(4, 5);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(33, 32);
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // txtTimDH
            // 
            this.txtTimDH.BorderRadius = 5;
            this.txtTimDH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimDH.DefaultText = "";
            this.txtTimDH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimDH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimDH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimDH.DisabledState.Parent = this.txtTimDH;
            this.txtTimDH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimDH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimDH.FocusedState.Parent = this.txtTimDH;
            this.txtTimDH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimDH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimDH.HoverState.Parent = this.txtTimDH;
            this.txtTimDH.Location = new System.Drawing.Point(8, 55);
            this.txtTimDH.Name = "txtTimDH";
            this.txtTimDH.PasswordChar = '\0';
            this.txtTimDH.PlaceholderText = "Nhập tên nhân viên hoặc tên khách hàng";
            this.txtTimDH.SelectedText = "";
            this.txtTimDH.ShadowDecoration.Parent = this.txtTimDH;
            this.txtTimDH.Size = new System.Drawing.Size(278, 36);
            this.txtTimDH.TabIndex = 27;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(228)))));
            this.guna2Panel2.Controls.Add(this.DH_btnXemCTDonHang);
            this.guna2Panel2.Controls.Add(this.btnBanHang);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(1003, 45);
            this.guna2Panel2.TabIndex = 2;
            // 
            // DH_btnXemCTDonHang
            // 
            this.DH_btnXemCTDonHang.BorderRadius = 5;
            this.DH_btnXemCTDonHang.CheckedState.Parent = this.DH_btnXemCTDonHang;
            this.DH_btnXemCTDonHang.CustomImages.Parent = this.DH_btnXemCTDonHang;
            this.DH_btnXemCTDonHang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DH_btnXemCTDonHang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DH_btnXemCTDonHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DH_btnXemCTDonHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DH_btnXemCTDonHang.DisabledState.Parent = this.DH_btnXemCTDonHang;
            this.DH_btnXemCTDonHang.FillColor = System.Drawing.Color.White;
            this.DH_btnXemCTDonHang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.DH_btnXemCTDonHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(228)))));
            this.DH_btnXemCTDonHang.HoverState.Parent = this.DH_btnXemCTDonHang;
            this.DH_btnXemCTDonHang.Location = new System.Drawing.Point(769, 4);
            this.DH_btnXemCTDonHang.Name = "DH_btnXemCTDonHang";
            this.DH_btnXemCTDonHang.ShadowDecoration.Parent = this.DH_btnXemCTDonHang;
            this.DH_btnXemCTDonHang.Size = new System.Drawing.Size(111, 36);
            this.DH_btnXemCTDonHang.TabIndex = 33;
            this.DH_btnXemCTDonHang.Text = "Xem";
            this.DH_btnXemCTDonHang.Click += new System.EventHandler(this.DH_btnXemCTDonHang_Click);
            // 
            // btnBanHang
            // 
            this.btnBanHang.BorderRadius = 5;
            this.btnBanHang.CheckedState.Parent = this.btnBanHang;
            this.btnBanHang.CustomImages.Parent = this.btnBanHang;
            this.btnBanHang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBanHang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBanHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBanHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBanHang.DisabledState.Parent = this.btnBanHang;
            this.btnBanHang.FillColor = System.Drawing.Color.White;
            this.btnBanHang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBanHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(228)))));
            this.btnBanHang.HoverState.Parent = this.btnBanHang;
            this.btnBanHang.Location = new System.Drawing.Point(886, 4);
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.ShadowDecoration.Parent = this.btnBanHang;
            this.btnBanHang.Size = new System.Drawing.Size(111, 36);
            this.btnBanHang.TabIndex = 32;
            this.btnBanHang.Text = "Bán hàng";
            this.btnBanHang.Click += new System.EventHandler(this.btnBanHang_Click);
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(228)))));
            this.guna2Panel4.Controls.Add(this.label2);
            this.guna2Panel4.Controls.Add(this.guna2PictureBox2);
            this.guna2Panel4.Location = new System.Drawing.Point(0, 100);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.ShadowDecoration.Parent = this.guna2Panel4;
            this.guna2Panel4.Size = new System.Drawing.Size(1003, 42);
            this.guna2Panel4.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(34, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đơn hàng";
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(4, 5);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.ShadowDecoration.Parent = this.guna2PictureBox2;
            this.guna2PictureBox2.Size = new System.Drawing.Size(33, 32);
            this.guna2PictureBox2.TabIndex = 0;
            this.guna2PictureBox2.TabStop = false;
            // 
            // DTP_DH_TUNGAY
            // 
            this.DTP_DH_TUNGAY.BorderRadius = 5;
            this.DTP_DH_TUNGAY.CheckedState.Parent = this.DTP_DH_TUNGAY;
            this.DTP_DH_TUNGAY.CustomFormat = "dd/MM/yyyy";
            this.DTP_DH_TUNGAY.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(228)))));
            this.DTP_DH_TUNGAY.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.DTP_DH_TUNGAY.ForeColor = System.Drawing.Color.White;
            this.DTP_DH_TUNGAY.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_DH_TUNGAY.HoverState.Parent = this.DTP_DH_TUNGAY;
            this.DTP_DH_TUNGAY.Location = new System.Drawing.Point(640, 63);
            this.DTP_DH_TUNGAY.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DTP_DH_TUNGAY.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DTP_DH_TUNGAY.Name = "DTP_DH_TUNGAY";
            this.DTP_DH_TUNGAY.ShadowDecoration.Parent = this.DTP_DH_TUNGAY;
            this.DTP_DH_TUNGAY.Size = new System.Drawing.Size(129, 32);
            this.DTP_DH_TUNGAY.TabIndex = 32;
            this.DTP_DH_TUNGAY.Value = new System.DateTime(2021, 10, 15, 22, 32, 4, 704);
            // 
            // DTP_DH_DENNGAY
            // 
            this.DTP_DH_DENNGAY.BorderRadius = 6;
            this.DTP_DH_DENNGAY.CheckedState.Parent = this.DTP_DH_DENNGAY;
            this.DTP_DH_DENNGAY.CustomFormat = "dd/MM/yyyy";
            this.DTP_DH_DENNGAY.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(228)))));
            this.DTP_DH_DENNGAY.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.DTP_DH_DENNGAY.ForeColor = System.Drawing.Color.White;
            this.DTP_DH_DENNGAY.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_DH_DENNGAY.HoverState.Parent = this.DTP_DH_DENNGAY;
            this.DTP_DH_DENNGAY.Location = new System.Drawing.Point(777, 63);
            this.DTP_DH_DENNGAY.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DTP_DH_DENNGAY.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DTP_DH_DENNGAY.Name = "DTP_DH_DENNGAY";
            this.DTP_DH_DENNGAY.ShadowDecoration.Parent = this.DTP_DH_DENNGAY;
            this.DTP_DH_DENNGAY.Size = new System.Drawing.Size(129, 32);
            this.DTP_DH_DENNGAY.TabIndex = 33;
            this.DTP_DH_DENNGAY.Value = new System.DateTime(2021, 10, 15, 22, 32, 4, 704);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(228)))));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(640, 46);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(48, 15);
            this.guna2HtmlLabel3.TabIndex = 34;
            this.guna2HtmlLabel3.Text = "Từ ngày:";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(228)))));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(777, 46);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(56, 15);
            this.guna2HtmlLabel4.TabIndex = 34;
            this.guna2HtmlLabel4.Text = "Đến ngày:";
            // 
            // btnTimDH
            // 
            this.btnTimDH.CheckedState.Parent = this.btnTimDH;
            this.btnTimDH.CustomImages.Parent = this.btnTimDH;
            this.btnTimDH.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimDH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimDH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimDH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimDH.DisabledState.Parent = this.btnTimDH;
            this.btnTimDH.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(228)))));
            this.btnTimDH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTimDH.ForeColor = System.Drawing.Color.White;
            this.btnTimDH.HoverState.Parent = this.btnTimDH;
            this.btnTimDH.Image = ((System.Drawing.Image)(resources.GetObject("btnTimDH.Image")));
            this.btnTimDH.Location = new System.Drawing.Point(292, 55);
            this.btnTimDH.Name = "btnTimDH";
            this.btnTimDH.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnTimDH.ShadowDecoration.Parent = this.btnTimDH;
            this.btnTimDH.Size = new System.Drawing.Size(36, 36);
            this.btnTimDH.TabIndex = 84;
            this.btnTimDH.Click += new System.EventHandler(this.btnTimDH_Click);
            // 
            // btnXemDHTheoNgay
            // 
            this.btnXemDHTheoNgay.BorderRadius = 5;
            this.btnXemDHTheoNgay.CheckedState.Parent = this.btnXemDHTheoNgay;
            this.btnXemDHTheoNgay.CustomImages.Parent = this.btnXemDHTheoNgay;
            this.btnXemDHTheoNgay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXemDHTheoNgay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXemDHTheoNgay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXemDHTheoNgay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXemDHTheoNgay.DisabledState.Parent = this.btnXemDHTheoNgay;
            this.btnXemDHTheoNgay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(228)))));
            this.btnXemDHTheoNgay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXemDHTheoNgay.ForeColor = System.Drawing.Color.White;
            this.btnXemDHTheoNgay.HoverState.Parent = this.btnXemDHTheoNgay;
            this.btnXemDHTheoNgay.Location = new System.Drawing.Point(914, 63);
            this.btnXemDHTheoNgay.Name = "btnXemDHTheoNgay";
            this.btnXemDHTheoNgay.ShadowDecoration.Parent = this.btnXemDHTheoNgay;
            this.btnXemDHTheoNgay.Size = new System.Drawing.Size(81, 32);
            this.btnXemDHTheoNgay.TabIndex = 85;
            this.btnXemDHTheoNgay.Text = "Xem";
            this.btnXemDHTheoNgay.Click += new System.EventHandler(this.btnXemDHTheoNgay_Click);
            // 
            // ucDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnXemDHTheoNgay);
            this.Controls.Add(this.btnTimDH);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.DTP_DH_DENNGAY);
            this.Controls.Add(this.DTP_DH_TUNGAY);
            this.Controls.Add(this.dgvDonHang);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.txtTimDH);
            this.Name = "ucDonHang";
            this.Size = new System.Drawing.Size(1003, 656);
            this.Load += new System.EventHandler(this.ucDonHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView dgvDonHang;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2TextBox txtTimDH;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnBanHang;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2DateTimePicker DTP_DH_TUNGAY;
        private Guna.UI2.WinForms.Guna2DateTimePicker DTP_DH_DENNGAY;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2CircleButton btnTimDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn clKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clThuNgan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTongTien;
        private Guna.UI2.WinForms.Guna2Button DH_btnXemCTDonHang;
        private Guna.UI2.WinForms.Guna2Button btnXemDHTheoNgay;
    }
}
