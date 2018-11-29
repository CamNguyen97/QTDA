namespace QuanLyBanVeXe
{
    partial class FormThemVeBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThemVeBan));
            this.label1 = new System.Windows.Forms.Label();
            this.cbbDiaDiemXp = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbBienSoXe = new System.Windows.Forms.ComboBox();
            this.cbDatVe = new Bunifu.Framework.UI.BunifuCheckbox();
            this.cbbMaKhachHang = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbDiaDiemKt = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnThemVeBan = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnChoNgoi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtThoiGian = new System.Windows.Forms.Label();
            this.txtBienSoXe = new System.Windows.Forms.Label();
            this.txtGiaVe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Điểm Xuất Phát :";
            // 
            // cbbDiaDiemXp
            // 
            this.cbbDiaDiemXp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDiaDiemXp.FormattingEnabled = true;
            this.cbbDiaDiemXp.Location = new System.Drawing.Point(43, 61);
            this.cbbDiaDiemXp.Name = "cbbDiaDiemXp";
            this.cbbDiaDiemXp.Size = new System.Drawing.Size(273, 28);
            this.cbbDiaDiemXp.TabIndex = 1;
            this.cbbDiaDiemXp.SelectionChangeCommitted += new System.EventHandler(this.cbbDiaDiemXp_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chọn Xe :";
            // 
            // cbbBienSoXe
            // 
            this.cbbBienSoXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbBienSoXe.FormattingEnabled = true;
            this.cbbBienSoXe.Location = new System.Drawing.Point(43, 145);
            this.cbbBienSoXe.Name = "cbbBienSoXe";
            this.cbbBienSoXe.Size = new System.Drawing.Size(273, 28);
            this.cbbBienSoXe.TabIndex = 1;
            this.cbbBienSoXe.SelectedIndexChanged += new System.EventHandler(this.cbbBienSoXe_SelectedIndexChanged);
            this.cbbBienSoXe.SelectionChangeCommitted += new System.EventHandler(this.cbbBienSoXe_SelectionChangeCommitted);
            // 
            // cbDatVe
            // 
            this.cbDatVe.AutoSize = true;
            this.cbDatVe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cbDatVe.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cbDatVe.Checked = false;
            this.cbDatVe.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.cbDatVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDatVe.ForeColor = System.Drawing.Color.White;
            this.cbDatVe.Location = new System.Drawing.Point(411, 117);
            this.cbDatVe.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cbDatVe.Name = "cbDatVe";
            this.cbDatVe.Size = new System.Drawing.Size(20, 20);
            this.cbDatVe.TabIndex = 3;
            this.cbDatVe.OnChange += new System.EventHandler(this.cbDatVe_OnChange);
            // 
            // cbbMaKhachHang
            // 
            this.cbbMaKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaKhachHang.FormattingEnabled = true;
            this.cbbMaKhachHang.Location = new System.Drawing.Point(407, 145);
            this.cbbMaKhachHang.Name = "cbbMaKhachHang";
            this.cbbMaKhachHang.Size = new System.Drawing.Size(277, 28);
            this.cbbMaKhachHang.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giờ Khởi Hành :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Biển Số Xe :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Giá Vé :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(406, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Điểm Kết Thúc :";
            // 
            // cbbDiaDiemKt
            // 
            this.cbbDiaDiemKt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDiaDiemKt.FormattingEnabled = true;
            this.cbbDiaDiemKt.Location = new System.Drawing.Point(411, 61);
            this.cbbDiaDiemKt.Name = "cbbDiaDiemKt";
            this.cbbDiaDiemKt.Size = new System.Drawing.Size(273, 28);
            this.cbbDiaDiemKt.TabIndex = 1;
            this.cbbDiaDiemKt.SelectionChangeCommitted += new System.EventHandler(this.cbbDiaDiemKt_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(439, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Đặt vé online";
            // 
            // btnThemVeBan
            // 
            this.btnThemVeBan.ActiveBorderThickness = 1;
            this.btnThemVeBan.ActiveCornerRadius = 20;
            this.btnThemVeBan.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnThemVeBan.ActiveForecolor = System.Drawing.Color.White;
            this.btnThemVeBan.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnThemVeBan.BackColor = System.Drawing.Color.Gainsboro;
            this.btnThemVeBan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThemVeBan.BackgroundImage")));
            this.btnThemVeBan.ButtonText = "Bán Vé";
            this.btnThemVeBan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemVeBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemVeBan.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnThemVeBan.IdleBorderThickness = 1;
            this.btnThemVeBan.IdleCornerRadius = 20;
            this.btnThemVeBan.IdleFillColor = System.Drawing.Color.White;
            this.btnThemVeBan.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnThemVeBan.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnThemVeBan.Location = new System.Drawing.Point(579, 322);
            this.btnThemVeBan.Margin = new System.Windows.Forms.Padding(5);
            this.btnThemVeBan.Name = "btnThemVeBan";
            this.btnThemVeBan.Size = new System.Drawing.Size(152, 34);
            this.btnThemVeBan.TabIndex = 5;
            this.btnThemVeBan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThemVeBan.Click += new System.EventHandler(this.btnThemVeBan_Click);
            // 
            // btnChoNgoi
            // 
            this.btnChoNgoi.Activecolor = System.Drawing.Color.Gainsboro;
            this.btnChoNgoi.BackColor = System.Drawing.Color.Gainsboro;
            this.btnChoNgoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChoNgoi.BorderRadius = 0;
            this.btnChoNgoi.ButtonText = "        Chọn Chỗ Ngồi";
            this.btnChoNgoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChoNgoi.DisabledColor = System.Drawing.Color.Gray;
            this.btnChoNgoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoNgoi.Iconcolor = System.Drawing.Color.Transparent;
            this.btnChoNgoi.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnChoNgoi.Iconimage")));
            this.btnChoNgoi.Iconimage_right = null;
            this.btnChoNgoi.Iconimage_right_Selected = null;
            this.btnChoNgoi.Iconimage_Selected = null;
            this.btnChoNgoi.IconMarginLeft = 140;
            this.btnChoNgoi.IconMarginRight = 0;
            this.btnChoNgoi.IconRightVisible = true;
            this.btnChoNgoi.IconRightZoom = 0D;
            this.btnChoNgoi.IconVisible = true;
            this.btnChoNgoi.IconZoom = 90D;
            this.btnChoNgoi.IsTab = false;
            this.btnChoNgoi.Location = new System.Drawing.Point(407, 210);
            this.btnChoNgoi.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnChoNgoi.Name = "btnChoNgoi";
            this.btnChoNgoi.Normalcolor = System.Drawing.Color.Gainsboro;
            this.btnChoNgoi.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.btnChoNgoi.OnHoverTextColor = System.Drawing.Color.ForestGreen;
            this.btnChoNgoi.selected = false;
            this.btnChoNgoi.Size = new System.Drawing.Size(277, 74);
            this.btnChoNgoi.TabIndex = 6;
            this.btnChoNgoi.Text = "        Chọn Chỗ Ngồi";
            this.btnChoNgoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChoNgoi.Textcolor = System.Drawing.Color.Black;
            this.btnChoNgoi.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoNgoi.Click += new System.EventHandler(this.btnChoNgoi_Click);
            // 
            // txtThoiGian
            // 
            this.txtThoiGian.AutoSize = true;
            this.txtThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThoiGian.Location = new System.Drawing.Point(173, 210);
            this.txtThoiGian.Name = "txtThoiGian";
            this.txtThoiGian.Size = new System.Drawing.Size(0, 20);
            this.txtThoiGian.TabIndex = 0;
            // 
            // txtBienSoXe
            // 
            this.txtBienSoXe.AutoSize = true;
            this.txtBienSoXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBienSoXe.Location = new System.Drawing.Point(173, 251);
            this.txtBienSoXe.Name = "txtBienSoXe";
            this.txtBienSoXe.Size = new System.Drawing.Size(0, 20);
            this.txtBienSoXe.TabIndex = 0;
            // 
            // txtGiaVe
            // 
            this.txtGiaVe.AutoSize = true;
            this.txtGiaVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaVe.Location = new System.Drawing.Point(173, 291);
            this.txtGiaVe.Name = "txtGiaVe";
            this.txtGiaVe.Size = new System.Drawing.Size(0, 20);
            this.txtGiaVe.TabIndex = 0;
            // 
            // FormThemVeBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(756, 385);
            this.Controls.Add(this.btnChoNgoi);
            this.Controls.Add(this.btnThemVeBan);
            this.Controls.Add(this.cbbMaKhachHang);
            this.Controls.Add(this.cbDatVe);
            this.Controls.Add(this.cbbBienSoXe);
            this.Controls.Add(this.cbbDiaDiemKt);
            this.Controls.Add(this.cbbDiaDiemXp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGiaVe);
            this.Controls.Add(this.txtBienSoXe);
            this.Controls.Add(this.txtThoiGian);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormThemVeBan";
            this.Text = "Thêm Vé Bán";
            this.Load += new System.EventHandler(this.FormThemVeBan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbDiaDiemXp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbBienSoXe;
        private Bunifu.Framework.UI.BunifuCheckbox cbDatVe;
        private System.Windows.Forms.ComboBox cbbMaKhachHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbDiaDiemKt;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuThinButton2 btnThemVeBan;
        private Bunifu.Framework.UI.BunifuFlatButton btnChoNgoi;
        private System.Windows.Forms.Label txtThoiGian;
        private System.Windows.Forms.Label txtBienSoXe;
        private System.Windows.Forms.Label txtGiaVe;
    }
}