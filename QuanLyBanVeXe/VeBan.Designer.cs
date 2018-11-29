namespace QuanLyBanVeXe
{
    partial class VeBan
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VeBan));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbVeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBanVeXeDataSet = new QuanLyBanVeXe.QLBanVeXeDataSet();
            this.tb_VeTableAdapter = new QuanLyBanVeXe.QLBanVeXeDataSetTableAdapters.tb_VeTableAdapter();
            this.dgvData = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.MaVe1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaVe1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaChuyenDi1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLamMoi = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSua = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnThem = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnXoa = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnTimKiem = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dgvData1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BienSoXe1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViTriGheNgoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDiaDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDiaDiem1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaVe12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhanVien1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDiaDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDiaDiem1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem1 = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.tbVeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBanVeXeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbVeBindingSource
            // 
            this.tbVeBindingSource.DataMember = "tb_Ve";
            this.tbVeBindingSource.DataSource = this.qLBanVeXeDataSet;
            // 
            // qLBanVeXeDataSet
            // 
            this.qLBanVeXeDataSet.DataSetName = "QLBanVeXeDataSet";
            this.qLBanVeXeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_VeTableAdapter
            // 
            this.tb_VeTableAdapter.ClearBeforeFill = true;
            // 
            // dgvData
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvData.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaVe1,
            this.GiaVe1,
            this.MaChuyenDi1});
            this.dgvData.DoubleBuffered = true;
            this.dgvData.EnableHeadersVisualStyles = false;
            this.dgvData.HeaderBgColor = System.Drawing.Color.Honeydew;
            this.dgvData.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgvData.Location = new System.Drawing.Point(26, 81);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(849, 408);
            this.dgvData.TabIndex = 29;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            // 
            // MaVe1
            // 
            this.MaVe1.DataPropertyName = "MaVe";
            this.MaVe1.HeaderText = "Mã Vé";
            this.MaVe1.Name = "MaVe1";
            this.MaVe1.Width = 150;
            // 
            // GiaVe1
            // 
            this.GiaVe1.DataPropertyName = "GiaVe";
            this.GiaVe1.HeaderText = "Giá Vé";
            this.GiaVe1.Name = "GiaVe1";
            this.GiaVe1.Width = 150;
            // 
            // MaChuyenDi1
            // 
            this.MaChuyenDi1.DataPropertyName = "MaChuyenDi";
            this.MaChuyenDi1.HeaderText = "Mã Chuyến Đi";
            this.MaChuyenDi1.Name = "MaChuyenDi1";
            this.MaChuyenDi1.Width = 200;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(147, 20);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(608, 29);
            this.txtTimKiem.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 29);
            this.label1.TabIndex = 30;
            this.label1.Text = "Tìm Kiếm :";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.ActiveBorderThickness = 1;
            this.btnLamMoi.ActiveCornerRadius = 20;
            this.btnLamMoi.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnLamMoi.ActiveForecolor = System.Drawing.Color.White;
            this.btnLamMoi.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnLamMoi.BackColor = System.Drawing.Color.Gainsboro;
            this.btnLamMoi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.BackgroundImage")));
            this.btnLamMoi.ButtonText = "Làm Mới";
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnLamMoi.IdleBorderThickness = 1;
            this.btnLamMoi.IdleCornerRadius = 20;
            this.btnLamMoi.IdleFillColor = System.Drawing.Color.White;
            this.btnLamMoi.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnLamMoi.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnLamMoi.Location = new System.Drawing.Point(764, 493);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(113, 68);
            this.btnLamMoi.TabIndex = 33;
            this.btnLamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.ActiveBorderThickness = 1;
            this.btnSua.ActiveCornerRadius = 20;
            this.btnSua.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnSua.ActiveForecolor = System.Drawing.Color.White;
            this.btnSua.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnSua.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSua.BackgroundImage")));
            this.btnSua.ButtonText = "Sửa";
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSua.IdleBorderThickness = 1;
            this.btnSua.IdleCornerRadius = 20;
            this.btnSua.IdleFillColor = System.Drawing.Color.White;
            this.btnSua.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnSua.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnSua.Location = new System.Drawing.Point(268, 493);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(113, 68);
            this.btnSua.TabIndex = 34;
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.ActiveBorderThickness = 1;
            this.btnThem.ActiveCornerRadius = 20;
            this.btnThem.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnThem.ActiveForecolor = System.Drawing.Color.White;
            this.btnThem.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnThem.BackColor = System.Drawing.Color.Gainsboro;
            this.btnThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThem.BackgroundImage")));
            this.btnThem.ButtonText = "Thêm";
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnThem.IdleBorderThickness = 1;
            this.btnThem.IdleCornerRadius = 20;
            this.btnThem.IdleFillColor = System.Drawing.Color.White;
            this.btnThem.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnThem.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnThem.Location = new System.Drawing.Point(26, 493);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(113, 68);
            this.btnThem.TabIndex = 35;
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ActiveBorderThickness = 1;
            this.btnXoa.ActiveCornerRadius = 20;
            this.btnXoa.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnXoa.ActiveForecolor = System.Drawing.Color.White;
            this.btnXoa.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnXoa.BackColor = System.Drawing.Color.Gainsboro;
            this.btnXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.BackgroundImage")));
            this.btnXoa.ButtonText = "Xóa";
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnXoa.IdleBorderThickness = 1;
            this.btnXoa.IdleCornerRadius = 20;
            this.btnXoa.IdleFillColor = System.Drawing.Color.White;
            this.btnXoa.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnXoa.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnXoa.Location = new System.Drawing.Point(147, 493);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(113, 68);
            this.btnXoa.TabIndex = 36;
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.ActiveBorderThickness = 1;
            this.btnTimKiem.ActiveCornerRadius = 20;
            this.btnTimKiem.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnTimKiem.ActiveForecolor = System.Drawing.Color.White;
            this.btnTimKiem.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnTimKiem.BackColor = System.Drawing.Color.Gainsboro;
            this.btnTimKiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.BackgroundImage")));
            this.btnTimKiem.ButtonText = "Tìm kiếm";
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnTimKiem.IdleBorderThickness = 1;
            this.btnTimKiem.IdleCornerRadius = 20;
            this.btnTimKiem.IdleFillColor = System.Drawing.Color.White;
            this.btnTimKiem.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnTimKiem.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnTimKiem.Location = new System.Drawing.Point(764, 14);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(113, 39);
            this.btnTimKiem.TabIndex = 32;
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dgvData1
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvData1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvData1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvData1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvData1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvData1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.Column12,
            this.Column1,
            this.BienSoXe1,
            this.ViTriGheNgoi,
            this.TenDiaDiem,
            this.TenDiaDiem1,
            this.MaKhachHang,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.MaVe12,
            this.MaNhanVien1,
            this.TenNhanVien,
            this.diachi,
            this.sdt,
            this.gmail,
            this.MaNhanVien,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.MaDiaDiem,
            this.MaDiaDiem1});
            this.dgvData1.DoubleBuffered = true;
            this.dgvData1.EnableHeadersVisualStyles = false;
            this.dgvData1.HeaderBgColor = System.Drawing.Color.Honeydew;
            this.dgvData1.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgvData1.Location = new System.Drawing.Point(26, 81);
            this.dgvData1.Name = "dgvData1";
            this.dgvData1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvData1.RowTemplate.Height = 24;
            this.dgvData1.Size = new System.Drawing.Size(849, 408);
            this.dgvData1.TabIndex = 29;
            this.dgvData1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData1_CellClick);
            this.dgvData1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MaChuyenDi";
            this.dataGridViewTextBoxColumn3.HeaderText = "Mã Chuyến Đi";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "TrangThai";
            this.Column12.HeaderText = "Trạng Thái";
            this.Column12.Name = "Column12";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ThoiGianKhoiHanh";
            this.Column1.HeaderText = "Thời Gian Khởi Hành";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // BienSoXe1
            // 
            this.BienSoXe1.DataPropertyName = "BienSoXe";
            this.BienSoXe1.HeaderText = "Biển Số Xe";
            this.BienSoXe1.Name = "BienSoXe1";
            // 
            // ViTriGheNgoi
            // 
            this.ViTriGheNgoi.DataPropertyName = "ViTriGheNgoi";
            this.ViTriGheNgoi.HeaderText = "Vị Trí Ghế Ngồi";
            this.ViTriGheNgoi.Name = "ViTriGheNgoi";
            this.ViTriGheNgoi.Width = 150;
            // 
            // TenDiaDiem
            // 
            this.TenDiaDiem.DataPropertyName = "TenDiaDiem";
            this.TenDiaDiem.HeaderText = "Điểm XP";
            this.TenDiaDiem.Name = "TenDiaDiem";
            // 
            // TenDiaDiem1
            // 
            this.TenDiaDiem1.DataPropertyName = "TenDiaDiem1";
            this.TenDiaDiem1.HeaderText = "Điểm KT";
            this.TenDiaDiem1.Name = "TenDiaDiem1";
            // 
            // MaKhachHang
            // 
            this.MaKhachHang.DataPropertyName = "MaKhachHang";
            this.MaKhachHang.HeaderText = "Mã Khách Hàng";
            this.MaKhachHang.Name = "MaKhachHang";
            this.MaKhachHang.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "GiaVe";
            this.dataGridViewTextBoxColumn2.HeaderText = "Giá Vé";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaVe";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Vé";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // MaVe12
            // 
            this.MaVe12.DataPropertyName = "MaVe1";
            this.MaVe12.HeaderText = "MaVe1";
            this.MaVe12.Name = "MaVe12";
            this.MaVe12.Visible = false;
            // 
            // MaNhanVien1
            // 
            this.MaNhanVien1.DataPropertyName = "MaNhanVien1";
            this.MaNhanVien1.HeaderText = "MaNhanVien1";
            this.MaNhanVien1.Name = "MaNhanVien1";
            this.MaNhanVien1.Visible = false;
            // 
            // TenNhanVien
            // 
            this.TenNhanVien.DataPropertyName = "TenNhanVien";
            this.TenNhanVien.HeaderText = "Ten Nhan Vien";
            this.TenNhanVien.Name = "TenNhanVien";
            this.TenNhanVien.Visible = false;
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "diachi";
            this.diachi.Name = "diachi";
            this.diachi.Visible = false;
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "sdt";
            this.sdt.HeaderText = "sdt";
            this.sdt.Name = "sdt";
            this.sdt.Visible = false;
            // 
            // gmail
            // 
            this.gmail.DataPropertyName = "gmail";
            this.gmail.HeaderText = "gmail";
            this.gmail.Name = "gmail";
            this.gmail.Visible = false;
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.DataPropertyName = "MaNhanVien";
            this.MaNhanVien.HeaderText = "Mã Nhân Viên";
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.Visible = false;
            this.MaNhanVien.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "cmtTaiXe";
            this.Column2.HeaderText = "cmtTaiXe";
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TongGiaVe";
            this.Column4.HeaderText = "TongGiaVe";
            this.Column4.Name = "Column4";
            this.Column4.Visible = false;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "MaDiaDiemXuatPhat";
            this.Column5.HeaderText = "MaDiemXuatPhat";
            this.Column5.Name = "Column5";
            this.Column5.Visible = false;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "MaDiaDiemKetThuc";
            this.Column6.HeaderText = "MaDiemKetThuc";
            this.Column6.Name = "Column6";
            this.Column6.Visible = false;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "MaChuyenDi1";
            this.Column7.HeaderText = "MaChuyenDi1";
            this.Column7.Name = "Column7";
            this.Column7.Visible = false;
            // 
            // MaDiaDiem
            // 
            this.MaDiaDiem.DataPropertyName = "MaDiaDiem";
            this.MaDiaDiem.HeaderText = "MaDiaDiem";
            this.MaDiaDiem.Name = "MaDiaDiem";
            this.MaDiaDiem.Visible = false;
            // 
            // MaDiaDiem1
            // 
            this.MaDiaDiem1.DataPropertyName = "MaDiaDiem1";
            this.MaDiaDiem1.HeaderText = "MaDiaDiem1";
            this.MaDiaDiem1.Name = "MaDiaDiem1";
            this.MaDiaDiem1.Visible = false;
            // 
            // btnThem1
            // 
            this.btnThem1.ActiveBorderThickness = 1;
            this.btnThem1.ActiveCornerRadius = 20;
            this.btnThem1.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnThem1.ActiveForecolor = System.Drawing.Color.White;
            this.btnThem1.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnThem1.BackColor = System.Drawing.Color.Gainsboro;
            this.btnThem1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThem1.BackgroundImage")));
            this.btnThem1.ButtonText = "Thêm";
            this.btnThem1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem1.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnThem1.IdleBorderThickness = 1;
            this.btnThem1.IdleCornerRadius = 20;
            this.btnThem1.IdleFillColor = System.Drawing.Color.White;
            this.btnThem1.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnThem1.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnThem1.Location = new System.Drawing.Point(26, 493);
            this.btnThem1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThem1.Name = "btnThem1";
            this.btnThem1.Size = new System.Drawing.Size(113, 68);
            this.btnThem1.TabIndex = 35;
            this.btnThem1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThem1.Click += new System.EventHandler(this.btnThem1_Click);
            // 
            // VeBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvData1);
            this.Controls.Add(this.dgvData);
            this.Name = "VeBan";
            this.Size = new System.Drawing.Size(900, 570);
            this.Load += new System.EventHandler(this.VeBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbVeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBanVeXeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLBanVeXeDataSet qLBanVeXeDataSet;
        private System.Windows.Forms.BindingSource tbVeBindingSource;
        private QLBanVeXeDataSetTableAdapters.tb_VeTableAdapter tb_VeTableAdapter;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvData;
        private Bunifu.Framework.UI.BunifuThinButton2 btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLamMoi;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSua;
        private Bunifu.Framework.UI.BunifuThinButton2 btnThem;
        private Bunifu.Framework.UI.BunifuThinButton2 btnXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaVe1;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaVe1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChuyenDi1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvData1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnThem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BienSoXe1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ViTriGheNgoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDiaDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDiaDiem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaVe12;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn gmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDiaDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDiaDiem1;
    }
}
