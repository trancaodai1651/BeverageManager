
namespace Beverage_Manager
{
    partial class frmNhapKho
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.NK_DGV_CTNK = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colMSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.NK_CB_NCC = new Guna.UI2.WinForms.Guna2ComboBox();
            this.NK_DATENK = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.NK_CB_NV = new Guna.UI2.WinForms.Guna2ComboBox();
            this.NK_TXT_SL = new Guna.UI2.WinForms.Guna2TextBox();
            this.NK_CB_SP = new Guna.UI2.WinForms.Guna2ComboBox();
            this.NK_BTN_THEM_CTNK = new Guna.UI2.WinForms.Guna2Button();
            this.NK_BTN_XACNHAN = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.NK_DGV_CTNK)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(228)))));
            this.guna2ControlBox1.Location = new System.Drawing.Point(931, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 0;
            this.guna2ControlBox1.TabStop = false;
            // 
            // NK_DGV_CTNK
            // 
            this.NK_DGV_CTNK.AllowUserToAddRows = false;
            this.NK_DGV_CTNK.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.NK_DGV_CTNK.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.NK_DGV_CTNK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.NK_DGV_CTNK.BackgroundColor = System.Drawing.Color.White;
            this.NK_DGV_CTNK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NK_DGV_CTNK.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.NK_DGV_CTNK.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.NK_DGV_CTNK.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.NK_DGV_CTNK.ColumnHeadersHeight = 40;
            this.NK_DGV_CTNK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMSP,
            this.clTenSP,
            this.clSoLuong,
            this.clGia});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.NK_DGV_CTNK.DefaultCellStyle = dataGridViewCellStyle3;
            this.NK_DGV_CTNK.EnableHeadersVisualStyles = false;
            this.NK_DGV_CTNK.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.NK_DGV_CTNK.Location = new System.Drawing.Point(440, 36);
            this.NK_DGV_CTNK.Name = "NK_DGV_CTNK";
            this.NK_DGV_CTNK.ReadOnly = true;
            this.NK_DGV_CTNK.RowHeadersVisible = false;
            this.NK_DGV_CTNK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.NK_DGV_CTNK.Size = new System.Drawing.Size(525, 280);
            this.NK_DGV_CTNK.TabIndex = 0;
            this.NK_DGV_CTNK.TabStop = false;
            this.NK_DGV_CTNK.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.NK_DGV_CTNK.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.NK_DGV_CTNK.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.NK_DGV_CTNK.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.NK_DGV_CTNK.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.NK_DGV_CTNK.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.NK_DGV_CTNK.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.NK_DGV_CTNK.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.NK_DGV_CTNK.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.NK_DGV_CTNK.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.NK_DGV_CTNK.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.NK_DGV_CTNK.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.NK_DGV_CTNK.ThemeStyle.HeaderStyle.Height = 40;
            this.NK_DGV_CTNK.ThemeStyle.ReadOnly = true;
            this.NK_DGV_CTNK.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.NK_DGV_CTNK.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.NK_DGV_CTNK.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.NK_DGV_CTNK.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.NK_DGV_CTNK.ThemeStyle.RowsStyle.Height = 22;
            this.NK_DGV_CTNK.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.NK_DGV_CTNK.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.NK_DGV_CTNK.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.NK_DGV_CTNK_RowsAdded);
            // 
            // colMSP
            // 
            this.colMSP.HeaderText = "Mã sản phẩm";
            this.colMSP.Name = "colMSP";
            this.colMSP.ReadOnly = true;
            // 
            // clTenSP
            // 
            this.clTenSP.HeaderText = "Tên sản phẩm";
            this.clTenSP.Name = "clTenSP";
            this.clTenSP.ReadOnly = true;
            // 
            // clSoLuong
            // 
            this.clSoLuong.HeaderText = "Số lượng";
            this.clSoLuong.Name = "clSoLuong";
            this.clSoLuong.ReadOnly = true;
            // 
            // clGia
            // 
            this.clGia.HeaderText = "Thành tiền";
            this.clGia.Name = "clGia";
            this.clGia.ReadOnly = true;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // NK_CB_NCC
            // 
            this.NK_CB_NCC.BackColor = System.Drawing.Color.Transparent;
            this.NK_CB_NCC.BorderRadius = 5;
            this.NK_CB_NCC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.NK_CB_NCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NK_CB_NCC.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NK_CB_NCC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NK_CB_NCC.FocusedState.Parent = this.NK_CB_NCC;
            this.NK_CB_NCC.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.NK_CB_NCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.NK_CB_NCC.HoverState.Parent = this.NK_CB_NCC;
            this.NK_CB_NCC.ItemHeight = 30;
            this.NK_CB_NCC.ItemsAppearance.Parent = this.NK_CB_NCC;
            this.NK_CB_NCC.Location = new System.Drawing.Point(148, 64);
            this.NK_CB_NCC.Name = "NK_CB_NCC";
            this.NK_CB_NCC.ShadowDecoration.Parent = this.NK_CB_NCC;
            this.NK_CB_NCC.Size = new System.Drawing.Size(200, 36);
            this.NK_CB_NCC.TabIndex = 0;
            // 
            // NK_DATENK
            // 
            this.NK_DATENK.BorderRadius = 5;
            this.NK_DATENK.CheckedState.Parent = this.NK_DATENK;
            this.NK_DATENK.CustomFormat = "dd/MM/yyyy";
            this.NK_DATENK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(228)))));
            this.NK_DATENK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NK_DATENK.ForeColor = System.Drawing.Color.White;
            this.NK_DATENK.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.NK_DATENK.HoverState.Parent = this.NK_DATENK;
            this.NK_DATENK.Location = new System.Drawing.Point(148, 111);
            this.NK_DATENK.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.NK_DATENK.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.NK_DATENK.Name = "NK_DATENK";
            this.NK_DATENK.ShadowDecoration.Parent = this.NK_DATENK;
            this.NK_DATENK.Size = new System.Drawing.Size(200, 36);
            this.NK_DATENK.TabIndex = 1;
            this.NK_DATENK.Value = new System.DateTime(2021, 10, 18, 14, 12, 15, 442);
            // 
            // NK_CB_NV
            // 
            this.NK_CB_NV.BackColor = System.Drawing.Color.Transparent;
            this.NK_CB_NV.BorderRadius = 5;
            this.NK_CB_NV.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.NK_CB_NV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NK_CB_NV.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NK_CB_NV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NK_CB_NV.FocusedState.Parent = this.NK_CB_NV;
            this.NK_CB_NV.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.NK_CB_NV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.NK_CB_NV.HoverState.Parent = this.NK_CB_NV;
            this.NK_CB_NV.ItemHeight = 30;
            this.NK_CB_NV.ItemsAppearance.Parent = this.NK_CB_NV;
            this.NK_CB_NV.Location = new System.Drawing.Point(148, 158);
            this.NK_CB_NV.Name = "NK_CB_NV";
            this.NK_CB_NV.ShadowDecoration.Parent = this.NK_CB_NV;
            this.NK_CB_NV.Size = new System.Drawing.Size(200, 36);
            this.NK_CB_NV.TabIndex = 2;
            // 
            // NK_TXT_SL
            // 
            this.NK_TXT_SL.BorderRadius = 5;
            this.NK_TXT_SL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NK_TXT_SL.DefaultText = "";
            this.NK_TXT_SL.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NK_TXT_SL.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NK_TXT_SL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NK_TXT_SL.DisabledState.Parent = this.NK_TXT_SL;
            this.NK_TXT_SL.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NK_TXT_SL.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NK_TXT_SL.FocusedState.Parent = this.NK_TXT_SL;
            this.NK_TXT_SL.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NK_TXT_SL.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NK_TXT_SL.HoverState.Parent = this.NK_TXT_SL;
            this.NK_TXT_SL.Location = new System.Drawing.Point(148, 252);
            this.NK_TXT_SL.Name = "NK_TXT_SL";
            this.NK_TXT_SL.PasswordChar = '\0';
            this.NK_TXT_SL.PlaceholderText = "";
            this.NK_TXT_SL.SelectedText = "";
            this.NK_TXT_SL.ShadowDecoration.Parent = this.NK_TXT_SL;
            this.NK_TXT_SL.Size = new System.Drawing.Size(200, 36);
            this.NK_TXT_SL.TabIndex = 4;
            this.NK_TXT_SL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NK_TXT_SL_KeyDown);
            this.NK_TXT_SL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NK_TXT_SL_KeyPress);
            // 
            // NK_CB_SP
            // 
            this.NK_CB_SP.BackColor = System.Drawing.Color.Transparent;
            this.NK_CB_SP.BorderRadius = 5;
            this.NK_CB_SP.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.NK_CB_SP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NK_CB_SP.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NK_CB_SP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NK_CB_SP.FocusedState.Parent = this.NK_CB_SP;
            this.NK_CB_SP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.NK_CB_SP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.NK_CB_SP.HoverState.Parent = this.NK_CB_SP;
            this.NK_CB_SP.ItemHeight = 30;
            this.NK_CB_SP.ItemsAppearance.Parent = this.NK_CB_SP;
            this.NK_CB_SP.Location = new System.Drawing.Point(148, 205);
            this.NK_CB_SP.Name = "NK_CB_SP";
            this.NK_CB_SP.ShadowDecoration.Parent = this.NK_CB_SP;
            this.NK_CB_SP.Size = new System.Drawing.Size(200, 36);
            this.NK_CB_SP.TabIndex = 3;
            // 
            // NK_BTN_THEM_CTNK
            // 
            this.NK_BTN_THEM_CTNK.BorderRadius = 5;
            this.NK_BTN_THEM_CTNK.CheckedState.Parent = this.NK_BTN_THEM_CTNK;
            this.NK_BTN_THEM_CTNK.CustomImages.Parent = this.NK_BTN_THEM_CTNK;
            this.NK_BTN_THEM_CTNK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.NK_BTN_THEM_CTNK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.NK_BTN_THEM_CTNK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.NK_BTN_THEM_CTNK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.NK_BTN_THEM_CTNK.DisabledState.Parent = this.NK_BTN_THEM_CTNK;
            this.NK_BTN_THEM_CTNK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(228)))));
            this.NK_BTN_THEM_CTNK.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NK_BTN_THEM_CTNK.ForeColor = System.Drawing.Color.White;
            this.NK_BTN_THEM_CTNK.HoverState.Parent = this.NK_BTN_THEM_CTNK;
            this.NK_BTN_THEM_CTNK.Location = new System.Drawing.Point(116, 315);
            this.NK_BTN_THEM_CTNK.Name = "NK_BTN_THEM_CTNK";
            this.NK_BTN_THEM_CTNK.ShadowDecoration.Parent = this.NK_BTN_THEM_CTNK;
            this.NK_BTN_THEM_CTNK.Size = new System.Drawing.Size(113, 45);
            this.NK_BTN_THEM_CTNK.TabIndex = 6;
            this.NK_BTN_THEM_CTNK.TabStop = false;
            this.NK_BTN_THEM_CTNK.Text = "Thêm";
            this.NK_BTN_THEM_CTNK.Click += new System.EventHandler(this.NK_BTN_THEM_CTNK_Click);
            // 
            // NK_BTN_XACNHAN
            // 
            this.NK_BTN_XACNHAN.BorderRadius = 5;
            this.NK_BTN_XACNHAN.CheckedState.Parent = this.NK_BTN_XACNHAN;
            this.NK_BTN_XACNHAN.CustomImages.Parent = this.NK_BTN_XACNHAN;
            this.NK_BTN_XACNHAN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.NK_BTN_XACNHAN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.NK_BTN_XACNHAN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.NK_BTN_XACNHAN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.NK_BTN_XACNHAN.DisabledState.Parent = this.NK_BTN_XACNHAN;
            this.NK_BTN_XACNHAN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(228)))));
            this.NK_BTN_XACNHAN.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NK_BTN_XACNHAN.ForeColor = System.Drawing.Color.White;
            this.NK_BTN_XACNHAN.HoverState.Parent = this.NK_BTN_XACNHAN;
            this.NK_BTN_XACNHAN.Location = new System.Drawing.Point(235, 315);
            this.NK_BTN_XACNHAN.Name = "NK_BTN_XACNHAN";
            this.NK_BTN_XACNHAN.ShadowDecoration.Parent = this.NK_BTN_XACNHAN;
            this.NK_BTN_XACNHAN.Size = new System.Drawing.Size(113, 45);
            this.NK_BTN_XACNHAN.TabIndex = 146;
            this.NK_BTN_XACNHAN.TabStop = false;
            this.NK_BTN_XACNHAN.Text = "Xác nhận";
            this.NK_BTN_XACNHAN.Click += new System.EventHandler(this.NK_BTN_XACNHAN_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(228)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(60, 74);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(77, 17);
            this.guna2HtmlLabel1.TabIndex = 147;
            this.guna2HtmlLabel1.TabStop = false;
            this.guna2HtmlLabel1.Text = "Nhà cung cấp";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(228)))));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(80, 168);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(57, 17);
            this.guna2HtmlLabel4.TabIndex = 147;
            this.guna2HtmlLabel4.TabStop = false;
            this.guna2HtmlLabel4.Text = "Nhân viên";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(228)))));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(81, 215);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(56, 17);
            this.guna2HtmlLabel5.TabIndex = 147;
            this.guna2HtmlLabel5.TabStop = false;
            this.guna2HtmlLabel5.Text = "Sản phẩm";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(228)))));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(87, 262);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(50, 17);
            this.guna2HtmlLabel6.TabIndex = 147;
            this.guna2HtmlLabel6.TabStop = false;
            this.guna2HtmlLabel6.Text = "Số lượng";
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(228)))));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(87, 121);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(50, 17);
            this.guna2HtmlLabel7.TabIndex = 147;
            this.guna2HtmlLabel7.TabStop = false;
            this.guna2HtmlLabel7.Text = "Ngày lập";
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(228)))));
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(138, 12);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(116, 32);
            this.guna2HtmlLabel8.TabIndex = 147;
            this.guna2HtmlLabel8.TabStop = false;
            this.guna2HtmlLabel8.Text = "NHẬP KHO";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // frmNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(977, 375);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2HtmlLabel7);
            this.Controls.Add(this.guna2HtmlLabel8);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.NK_BTN_XACNHAN);
            this.Controls.Add(this.NK_BTN_THEM_CTNK);
            this.Controls.Add(this.NK_DATENK);
            this.Controls.Add(this.NK_TXT_SL);
            this.Controls.Add(this.NK_CB_SP);
            this.Controls.Add(this.NK_CB_NV);
            this.Controls.Add(this.NK_CB_NCC);
            this.Controls.Add(this.NK_DGV_CTNK);
            this.Controls.Add(this.guna2ControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNhapKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThemNK";
            this.Load += new System.EventHandler(this.frmNhapKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NK_DGV_CTNK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2DataGridView NK_DGV_CTNK;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DateTimePicker NK_DATENK;
        private Guna.UI2.WinForms.Guna2TextBox NK_TXT_SL;
        private Guna.UI2.WinForms.Guna2ComboBox NK_CB_NV;
        private Guna.UI2.WinForms.Guna2ComboBox NK_CB_NCC;
        private Guna.UI2.WinForms.Guna2ComboBox NK_CB_SP;
        private Guna.UI2.WinForms.Guna2Button NK_BTN_XACNHAN;
        private Guna.UI2.WinForms.Guna2Button NK_BTN_THEM_CTNK;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGia;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}