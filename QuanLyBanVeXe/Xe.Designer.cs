namespace QuanLyBanVeXe
{
    partial class Xe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Xe));
            this.tbXeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBanVeXeDataSet = new QuanLyBanVeXe.QLBanVeXeDataSet();
            this.tb_XeTableAdapter = new QuanLyBanVeXe.QLBanVeXeDataSetTableAdapters.tb_XeTableAdapter();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvData = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnTimKiem = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnLamMoi = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnThem = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnXoa = new Bunifu.Framework.UI.BunifuThinButton2();
            this.MaLoaiXe1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BienSoXe1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tbXeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBanVeXeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // tbXeBindingSource
            // 
            this.tbXeBindingSource.DataMember = "tb_Xe";
            this.tbXeBindingSource.DataSource = this.qLBanVeXeDataSet;
            // 
            // qLBanVeXeDataSet
            // 
            this.qLBanVeXeDataSet.DataSetName = "QLBanVeXeDataSet";
            this.qLBanVeXeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_XeTableAdapter
            // 
            this.tb_XeTableAdapter.ClearBeforeFill = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(147, 20);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(608, 29);
            this.txtTimKiem.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 29);
            this.label1.TabIndex = 33;
            this.label1.Text = "Tìm Kiếm :";
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
            this.MaLoaiXe1,
            this.BienSoXe1,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvData.DoubleBuffered = true;
            this.dgvData.EnableHeadersVisualStyles = false;
            this.dgvData.HeaderBgColor = System.Drawing.Color.Honeydew;
            this.dgvData.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgvData.Location = new System.Drawing.Point(26, 73);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(849, 408);
            this.dgvData.TabIndex = 28;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
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
            this.btnTimKiem.TabIndex = 35;
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
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
            this.btnLamMoi.TabIndex = 29;
            this.btnLamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
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
            this.btnThem.TabIndex = 31;
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
            this.btnXoa.TabIndex = 32;
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // MaLoaiXe1
            // 
            this.MaLoaiXe1.DataPropertyName = "MaLoaiXe";
            this.MaLoaiXe1.HeaderText = "Mã Loại Xe";
            this.MaLoaiXe1.Name = "MaLoaiXe1";
            this.MaLoaiXe1.Visible = false;
            this.MaLoaiXe1.Width = 200;
            // 
            // BienSoXe1
            // 
            this.BienSoXe1.DataPropertyName = "BienSoXe";
            this.BienSoXe1.HeaderText = "Biển Số Xe";
            this.BienSoXe1.Name = "BienSoXe1";
            this.BienSoXe1.Width = 200;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SoChoNgoi";
            this.Column3.HeaderText = "Số Chỗ Ngồi";
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "LoaiXe";
            this.Column4.HeaderText = "Loại Xe";
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "MaLoaiXe1";
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.Visible = false;
            // 
            // Xe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.dgvData);
            this.Name = "Xe";
            this.Size = new System.Drawing.Size(900, 570);
            this.Load += new System.EventHandler(this.Xe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbXeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBanVeXeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource tbXeBindingSource;
        private QLBanVeXeDataSet qLBanVeXeDataSet;
        private QLBanVeXeDataSetTableAdapters.tb_XeTableAdapter tb_XeTableAdapter;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLamMoi;
        private Bunifu.Framework.UI.BunifuThinButton2 btnThem;
        private Bunifu.Framework.UI.BunifuThinButton2 btnXoa;
        private Bunifu.Framework.UI.BunifuThinButton2 btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiXe1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BienSoXe1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
