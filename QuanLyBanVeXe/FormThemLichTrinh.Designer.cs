namespace QuanLyBanVeXe
{
    partial class FormThemLichTrinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThemLichTrinh));
            this.txtMaChuyenDi = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbTaiXe = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbDiaDiemKhoiHanh = new System.Windows.Forms.ComboBox();
            this.cbbDiaDiemKetThuc = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbXe = new System.Windows.Forms.ComboBox();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
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
            this.txtMaChuyenDi.Location = new System.Drawing.Point(179, 46);
            this.txtMaChuyenDi.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaChuyenDi.Name = "txtMaChuyenDi";
            this.txtMaChuyenDi.Size = new System.Drawing.Size(298, 33);
            this.txtMaChuyenDi.TabIndex = 20;
            this.txtMaChuyenDi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMaChuyenDi.OnValueChanged += new System.EventHandler(this.txtBienSoXe_OnValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Mã Chuyến Đi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Thời Gian : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Chọn Tài Xế :";
            // 
            // cbbTaiXe
            // 
            this.cbbTaiXe.BackColor = System.Drawing.Color.Gainsboro;
            this.cbbTaiXe.FormattingEnabled = true;
            this.cbbTaiXe.Location = new System.Drawing.Point(179, 155);
            this.cbbTaiXe.Name = "cbbTaiXe";
            this.cbbTaiXe.Size = new System.Drawing.Size(298, 24);
            this.cbbTaiXe.TabIndex = 22;
            this.cbbTaiXe.SelectedIndexChanged += new System.EventHandler(this.cbbTaiXe_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(575, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(509, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Địa Điểm Xuất Phát :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(509, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Địa Điểm Tới :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cbbDiaDiemKhoiHanh
            // 
            this.cbbDiaDiemKhoiHanh.BackColor = System.Drawing.Color.Gainsboro;
            this.cbbDiaDiemKhoiHanh.FormattingEnabled = true;
            this.cbbDiaDiemKhoiHanh.Location = new System.Drawing.Point(716, 105);
            this.cbbDiaDiemKhoiHanh.Name = "cbbDiaDiemKhoiHanh";
            this.cbbDiaDiemKhoiHanh.Size = new System.Drawing.Size(298, 24);
            this.cbbDiaDiemKhoiHanh.TabIndex = 22;
            this.cbbDiaDiemKhoiHanh.SelectedIndexChanged += new System.EventHandler(this.cbbDiaDiemKhoiHanh_SelectedIndexChanged);
            this.cbbDiaDiemKhoiHanh.Click += new System.EventHandler(this.cbbDiaDiemKhoiHanh_Click);
            // 
            // cbbDiaDiemKetThuc
            // 
            this.cbbDiaDiemKetThuc.BackColor = System.Drawing.Color.Gainsboro;
            this.cbbDiaDiemKetThuc.FormattingEnabled = true;
            this.cbbDiaDiemKetThuc.Location = new System.Drawing.Point(716, 155);
            this.cbbDiaDiemKetThuc.Name = "cbbDiaDiemKetThuc";
            this.cbbDiaDiemKetThuc.Size = new System.Drawing.Size(298, 24);
            this.cbbDiaDiemKetThuc.TabIndex = 22;
            this.cbbDiaDiemKetThuc.SelectedIndexChanged += new System.EventHandler(this.cbbDiaDiemKetThuc_SelectedIndexChanged);
            this.cbbDiaDiemKetThuc.Click += new System.EventHandler(this.cbbDiaDiemKetThuc_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(509, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Chọn Xe :";
            this.label7.Click += new System.EventHandler(this.label5_Click);
            // 
            // cbbXe
            // 
            this.cbbXe.BackColor = System.Drawing.Color.Gainsboro;
            this.cbbXe.FormattingEnabled = true;
            this.cbbXe.Location = new System.Drawing.Point(716, 54);
            this.cbbXe.Name = "cbbXe";
            this.cbbXe.Size = new System.Drawing.Size(298, 24);
            this.cbbXe.TabIndex = 22;
            // 
            // dtpTime
            // 
            this.dtpTime.CustomFormat = "HH:mm";
            this.dtpTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(387, 103);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(90, 24);
            this.dtpTime.TabIndex = 25;
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(179, 103);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 24);
            this.dtpDate.TabIndex = 26;
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Gainsboro;
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(1034, 155);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(34, 24);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 27;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            this.bunifuImageButton3.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Gainsboro;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(1034, 105);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(34, 24);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 27;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Gainsboro;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(402, 227);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(208, 71);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 23;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // FormThemLichTrinh
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
            this.Name = "FormThemLichTrinh";
            this.Text = "Thêm Lịch Trình";
            this.Load += new System.EventHandler(this.FormThemLichTrinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMaChuyenDi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbTaiXe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbDiaDiemKhoiHanh;
        private System.Windows.Forms.ComboBox cbbDiaDiemKetThuc;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbXe;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
    }
}