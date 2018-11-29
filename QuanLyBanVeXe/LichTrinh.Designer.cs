namespace QuanLyBanVeXe
{
    partial class us_LichTrinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(us_LichTrinh));
            this.tbchuyendiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBanVeXeDataSet = new QuanLyBanVeXe.QLBanVeXeDataSet();
            this.tb_chuyendiTableAdapter = new QuanLyBanVeXe.QLBanVeXeDataSetTableAdapters.tb_chuyendiTableAdapter();
            this.dgvData = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnTimKiem = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLamMoi = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSua = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnThem = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnXoa = new Bunifu.Framework.UI.BunifuThinButton2();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MaChuyenDi1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianKhoiHanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmtTaiXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BienSoXe1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDiemXP1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDiemKT1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tbchuyendiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBanVeXeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // tbchuyendiBindingSource
            // 
            this.tbchuyendiBindingSource.DataMember = "tb_chuyendi";
            this.tbchuyendiBindingSource.DataSource = this.qLBanVeXeDataSet;
            // 
            // qLBanVeXeDataSet
            // 
            this.qLBanVeXeDataSet.DataSetName = "QLBanVeXeDataSet";
            this.qLBanVeXeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_chuyendiTableAdapter
            // 
            this.tb_chuyendiTableAdapter.ClearBeforeFill = true;
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
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaChuyenDi1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column7,
            this.ThoiGianKhoiHanh,
            this.CmtTaiXe,
            this.Column1,
            this.BienSoXe1,
            this.Column11,
            this.Column12,
            this.MaDiemXP1,
            this.MaDiemKT1,
            this.Column10,
            this.Column9,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column6,
            this.LoaiXe});
            this.dgvData.DoubleBuffered = true;
            this.dgvData.EnableHeadersVisualStyles = false;
            this.dgvData.HeaderBgColor = System.Drawing.Color.Honeydew;
            this.dgvData.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgvData.Location = new System.Drawing.Point(26, 81);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(849, 408);
            this.dgvData.TabIndex = 29;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick_1);
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
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click_1);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(147, 20);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(608, 29);
            this.txtTimKiem.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 29);
            this.label2.TabIndex = 30;
            this.label2.Text = "Tìm Kiếm :";
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
            this.btnLamMoi.TabIndex = 37;
            this.btnLamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click_1);
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
            this.btnSua.TabIndex = 38;
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
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
            this.btnThem.TabIndex = 39;
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
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
            this.btnXoa.TabIndex = 40;
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MaChuyenDi1
            // 
            this.MaChuyenDi1.DataPropertyName = "MaChuyenDi";
            this.MaChuyenDi1.HeaderText = "Mã Chuyến Đi";
            this.MaChuyenDi1.Name = "MaChuyenDi1";
            this.MaChuyenDi1.ReadOnly = true;
            this.MaChuyenDi1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TrangThai";
            this.Column2.HeaderText = "Trạng Thái";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "BienSoXe1";
            this.Column3.HeaderText = "BienSoXe1";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "MaLoaiXe";
            this.Column4.HeaderText = "MaLoaiXe";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "MaLoaiXe1";
            this.Column5.HeaderText = "MaLoaiXe1";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "SoChoNgoi";
            this.Column7.HeaderText = "SoChoNgoi";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // ThoiGianKhoiHanh
            // 
            this.ThoiGianKhoiHanh.DataPropertyName = "ThoiGianKhoiHanh";
            this.ThoiGianKhoiHanh.HeaderText = "Thời Gian Khởi Hành";
            this.ThoiGianKhoiHanh.Name = "ThoiGianKhoiHanh";
            this.ThoiGianKhoiHanh.ReadOnly = true;
            this.ThoiGianKhoiHanh.Width = 150;
            // 
            // CmtTaiXe
            // 
            this.CmtTaiXe.DataPropertyName = "CmtTaiXe";
            this.CmtTaiXe.HeaderText = "Cmt Tài Xế";
            this.CmtTaiXe.Name = "CmtTaiXe";
            this.CmtTaiXe.ReadOnly = true;
            this.CmtTaiXe.Visible = false;
            this.CmtTaiXe.Width = 150;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ten";
            this.Column1.HeaderText = "Tên Tài Xế";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // BienSoXe1
            // 
            this.BienSoXe1.DataPropertyName = "BienSoXe";
            this.BienSoXe1.HeaderText = "Biển Số Xe";
            this.BienSoXe1.Name = "BienSoXe1";
            this.BienSoXe1.ReadOnly = true;
            this.BienSoXe1.Width = 150;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "TenDiaDiem1";
            this.Column11.HeaderText = "Địa Điểm Khởi Hành";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 200;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "TenDiaDiem";
            this.Column12.HeaderText = "Địa Điểm Kết Thúc";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 200;
            // 
            // MaDiemXP1
            // 
            this.MaDiemXP1.DataPropertyName = "MaDiaDiemXuatPhat";
            this.MaDiemXP1.HeaderText = "Mã Địa Điểm Khởi Hành";
            this.MaDiemXP1.Name = "MaDiemXP1";
            this.MaDiemXP1.ReadOnly = true;
            this.MaDiemXP1.Visible = false;
            this.MaDiemXP1.Width = 150;
            // 
            // MaDiemKT1
            // 
            this.MaDiemKT1.DataPropertyName = "MaDiaDiemKetThuc";
            this.MaDiemKT1.HeaderText = "Mã Địa Điểm Đến";
            this.MaDiemKT1.Name = "MaDiemKT1";
            this.MaDiemKT1.ReadOnly = true;
            this.MaDiemKT1.Visible = false;
            this.MaDiemKT1.Width = 150;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "MaDiaDiem1";
            this.Column10.HeaderText = "MaDiaDiem1";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Visible = false;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "MaDiaDiem";
            this.Column9.HeaderText = "MaDiaDiem";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Visible = false;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "cmtTaiXe1";
            this.Column13.HeaderText = "cmt1";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Visible = false;
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "sdt";
            this.Column14.HeaderText = "sdt";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Visible = false;
            // 
            // Column15
            // 
            this.Column15.DataPropertyName = "diachi";
            this.Column15.HeaderText = "diachi";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Visible = false;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "TongGiaVe";
            this.Column6.HeaderText = "Tổng Giá Vé";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            this.Column6.Width = 150;
            // 
            // LoaiXe
            // 
            this.LoaiXe.DataPropertyName = "LoaiXe";
            this.LoaiXe.HeaderText = "Loại Xe";
            this.LoaiXe.Name = "LoaiXe";
            this.LoaiXe.ReadOnly = true;
            this.LoaiXe.Width = 150;
            // 
            // us_LichTrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvData);
            this.Name = "us_LichTrinh";
            this.Size = new System.Drawing.Size(900, 570);
            this.Load += new System.EventHandler(this.us_LichTrinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbchuyendiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBanVeXeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource tbchuyendiBindingSource;
        private QLBanVeXeDataSet qLBanVeXeDataSet;
        private QLBanVeXeDataSetTableAdapters.tb_chuyendiTableAdapter tb_chuyendiTableAdapter;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvData;
        private Bunifu.Framework.UI.BunifuThinButton2 btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLamMoi;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSua;
        private Bunifu.Framework.UI.BunifuThinButton2 btnThem;
        private Bunifu.Framework.UI.BunifuThinButton2 btnXoa;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChuyenDi1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianKhoiHanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn CmtTaiXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BienSoXe1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDiemXP1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDiemKT1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiXe;
    }
}
