namespace QuanLyBanVeXe
{
    partial class FormNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhanVien));
            this.bunifuTileButton3 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton2 = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnKhachHang = new Bunifu.Framework.UI.BunifuTileButton();
            this.us_KhachHang = new QuanLyBanVeXe.KhachHang();
            this.us_VeBan = new QuanLyBanVeXe.VeBan();
            this.us_LichTrinh = new QuanLyBanVeXe.us_LichTrinh();
            this.SuspendLayout();
            // 
            // bunifuTileButton3
            // 
            this.bunifuTileButton3.BackColor = System.Drawing.Color.Azure;
            this.bunifuTileButton3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuTileButton3.color = System.Drawing.Color.Azure;
            this.bunifuTileButton3.colorActive = System.Drawing.Color.DeepSkyBlue;
            this.bunifuTileButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton3.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton3.ForeColor = System.Drawing.Color.Gray;
            this.bunifuTileButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton3.Image")));
            this.bunifuTileButton3.ImagePosition = 1;
            this.bunifuTileButton3.ImageZoom = 15;
            this.bunifuTileButton3.LabelPosition = 40;
            this.bunifuTileButton3.LabelText = "Vé Bán";
            this.bunifuTileButton3.Location = new System.Drawing.Point(2, 161);
            this.bunifuTileButton3.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton3.Name = "bunifuTileButton3";
            this.bunifuTileButton3.Size = new System.Drawing.Size(245, 83);
            this.bunifuTileButton3.TabIndex = 9;
            this.bunifuTileButton3.Click += new System.EventHandler(this.bunifuTileButton3_Click);
            // 
            // bunifuTileButton2
            // 
            this.bunifuTileButton2.BackColor = System.Drawing.Color.Azure;
            this.bunifuTileButton2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuTileButton2.color = System.Drawing.Color.Azure;
            this.bunifuTileButton2.colorActive = System.Drawing.Color.DeepSkyBlue;
            this.bunifuTileButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton2.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton2.ForeColor = System.Drawing.Color.Gray;
            this.bunifuTileButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton2.Image")));
            this.bunifuTileButton2.ImagePosition = 1;
            this.bunifuTileButton2.ImageZoom = 15;
            this.bunifuTileButton2.LabelPosition = 40;
            this.bunifuTileButton2.LabelText = "Lịch Trình";
            this.bunifuTileButton2.Location = new System.Drawing.Point(2, 75);
            this.bunifuTileButton2.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton2.Name = "bunifuTileButton2";
            this.bunifuTileButton2.Size = new System.Drawing.Size(245, 83);
            this.bunifuTileButton2.TabIndex = 10;
            this.bunifuTileButton2.Click += new System.EventHandler(this.bunifuTileButton2_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.BackColor = System.Drawing.Color.Azure;
            this.btnKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnKhachHang.color = System.Drawing.Color.Azure;
            this.btnKhachHang.colorActive = System.Drawing.Color.DeepSkyBlue;
            this.btnKhachHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKhachHang.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnKhachHang.ForeColor = System.Drawing.Color.Gray;
            this.btnKhachHang.Image = ((System.Drawing.Image)(resources.GetObject("btnKhachHang.Image")));
            this.btnKhachHang.ImagePosition = 1;
            this.btnKhachHang.ImageZoom = 15;
            this.btnKhachHang.LabelPosition = 40;
            this.btnKhachHang.LabelText = "Khách Hàng";
            this.btnKhachHang.Location = new System.Drawing.Point(2, 246);
            this.btnKhachHang.Margin = new System.Windows.Forms.Padding(6);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(245, 83);
            this.btnKhachHang.TabIndex = 12;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click_1);
            // 
            // us_KhachHang
            // 
            this.us_KhachHang.BackColor = System.Drawing.Color.Gainsboro;
            this.us_KhachHang.Location = new System.Drawing.Point(259, 12);
            this.us_KhachHang.Name = "us_KhachHang";
            this.us_KhachHang.Size = new System.Drawing.Size(900, 570);
            this.us_KhachHang.TabIndex = 15;
            this.us_KhachHang.Load += new System.EventHandler(this.khachHang1_Load);
            // 
            // us_VeBan
            // 
            this.us_VeBan.BackColor = System.Drawing.Color.Gainsboro;
            this.us_VeBan.Location = new System.Drawing.Point(259, 12);
            this.us_VeBan.Name = "us_VeBan";
            this.us_VeBan.Size = new System.Drawing.Size(900, 570);
            this.us_VeBan.TabIndex = 14;
            // 
            // us_LichTrinh
            // 
            this.us_LichTrinh.BackColor = System.Drawing.Color.Gainsboro;
            this.us_LichTrinh.Location = new System.Drawing.Point(259, 12);
            this.us_LichTrinh.Name = "us_LichTrinh";
            this.us_LichTrinh.Size = new System.Drawing.Size(900, 570);
            this.us_LichTrinh.TabIndex = 13;
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1182, 603);
            this.Controls.Add(this.us_LichTrinh);
            this.Controls.Add(this.bunifuTileButton3);
            this.Controls.Add(this.bunifuTileButton2);
            this.Controls.Add(this.btnKhachHang);
            this.Controls.Add(this.us_KhachHang);
            this.Controls.Add(this.us_VeBan);
            this.Name = "FormNhanVien";
            this.Text = "Quản Lý Bán Vé Xe ( Nhân Viên )";
            this.ResumeLayout(false);

        }

        private void userControl11_Load(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton3;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton2;
        private Bunifu.Framework.UI.BunifuTileButton btnKhachHang;
        private us_LichTrinh us_LichTrinh;
        private VeBan us_VeBan;
        private KhachHang us_KhachHang;

    }
}