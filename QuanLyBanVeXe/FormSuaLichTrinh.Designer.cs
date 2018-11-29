namespace QuanLyBanVeXe
{
    partial class FormSuaLichTrinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSuaLichTrinh));
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.cbbDiaDiemKetThuc = new System.Windows.Forms.ComboBox();
            this.cbbXe = new System.Windows.Forms.ComboBox();
            this.cbbDiaDiemKhoiHanh = new System.Windows.Forms.ComboBox();
            this.cbbTaiXe = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaChuyenDi = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(183, 94);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 24);
            this.dtpDate.TabIndex = 42;
            // 
            // dtpTime
            // 
            this.dtpTime.CustomFormat = "HH:mm";
            this.dtpTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(391, 94);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(90, 24);
            this.dtpTime.TabIndex = 41;
            // 
            // cbbDiaDiemKetThuc
            // 
            this.cbbDiaDiemKetThuc.BackColor = System.Drawing.Color.Gainsboro;
            this.cbbDiaDiemKetThuc.FormattingEnabled = true;
            this.cbbDiaDiemKetThuc.Location = new System.Drawing.Point(720, 146);
            this.cbbDiaDiemKetThuc.Name = "cbbDiaDiemKetThuc";
            this.cbbDiaDiemKetThuc.Size = new System.Drawing.Size(298, 24);
            this.cbbDiaDiemKetThuc.TabIndex = 38;
            this.cbbDiaDiemKetThuc.Click += new System.EventHandler(this.cbbDiaDiemKetThuc_Click);
            // 
            // cbbXe
            // 
            this.cbbXe.BackColor = System.Drawing.Color.Gainsboro;
            this.cbbXe.FormattingEnabled = true;
            this.cbbXe.Location = new System.Drawing.Point(720, 45);
            this.cbbXe.Name = "cbbXe";
            this.cbbXe.Size = new System.Drawing.Size(298, 24);
            this.cbbXe.TabIndex = 37;
            // 
            // cbbDiaDiemKhoiHanh
            // 
            this.cbbDiaDiemKhoiHanh.BackColor = System.Drawing.Color.Gainsboro;
            this.cbbDiaDiemKhoiHanh.FormattingEnabled = true;
            this.cbbDiaDiemKhoiHanh.Location = new System.Drawing.Point(720, 96);
            this.cbbDiaDiemKhoiHanh.Name = "cbbDiaDiemKhoiHanh";
            this.cbbDiaDiemKhoiHanh.Size = new System.Drawing.Size(298, 24);
            this.cbbDiaDiemKhoiHanh.TabIndex = 39;
            this.cbbDiaDiemKhoiHanh.Click += new System.EventHandler(this.cbbDiaDiemKhoiHanh_Click);
            // 
            // cbbTaiXe
            // 
            this.cbbTaiXe.BackColor = System.Drawing.Color.Gainsboro;
            this.cbbTaiXe.FormattingEnabled = true;
            this.cbbTaiXe.Location = new System.Drawing.Point(183, 146);
            this.cbbTaiXe.Name = "cbbTaiXe";
            this.cbbTaiXe.Size = new System.Drawing.Size(298, 24);
            this.cbbTaiXe.TabIndex = 36;
            this.cbbTaiXe.SelectedIndexChanged += new System.EventHandler(this.cbbTaiXe_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(513, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 25);
            this.label6.TabIndex = 33;
            this.label6.Text = "Địa Điểm Tới :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(513, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 25);
            this.label7.TabIndex = 32;
            this.label7.Text = "Chọn Xe :";
            // 
            // txtMaChuyenDi
            // 
            this.txtMaChuyenDi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaChuyenDi.Enabled = false;
            this.txtMaChuyenDi.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtMaChuyenDi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMaChuyenDi.HintForeColor = System.Drawing.Color.Empty;
            this.txtMaChuyenDi.HintText = "";
            this.txtMaChuyenDi.isPassword = false;
            this.txtMaChuyenDi.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtMaChuyenDi.LineIdleColor = System.Drawing.Color.Gray;
            this.txtMaChuyenDi.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtMaChuyenDi.LineThickness = 3;
            this.txtMaChuyenDi.Location = new System.Drawing.Point(183, 37);
            this.txtMaChuyenDi.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaChuyenDi.Name = "txtMaChuyenDi";
            this.txtMaChuyenDi.Size = new System.Drawing.Size(298, 33);
            this.txtMaChuyenDi.TabIndex = 35;
            this.txtMaChuyenDi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(513, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 25);
            this.label5.TabIndex = 31;
            this.label5.Text = "Địa Điểm Xuất Phát :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(579, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "Chọn Tài Xế :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 34;
            this.label2.Text = "Thời Gian : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Mã Chuyến Đi :";
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Gainsboro;
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(1038, 146);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(34, 24);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 44;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Gainsboro;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(1038, 96);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(34, 24);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 43;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Gainsboro;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(406, 218);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(208, 71);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 40;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // FormSuaLichTrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1091, 323);
            this.Controls.Add(this.bunifuImageButton3);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.cbbDiaDiemKetThuc);
            this.Controls.Add(this.cbbXe);
            this.Controls.Add(this.cbbDiaDiemKhoiHanh);
            this.Controls.Add(this.cbbTaiXe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMaChuyenDi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormSuaLichTrinh";
            this.Text = "FormSuaLichTrinh";
            this.Load += new System.EventHandler(this.FormSuaLichTrinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.ComboBox cbbDiaDiemKetThuc;
        private System.Windows.Forms.ComboBox cbbXe;
        private System.Windows.Forms.ComboBox cbbDiaDiemKhoiHanh;
        private System.Windows.Forms.ComboBox cbbTaiXe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMaChuyenDi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}