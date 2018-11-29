namespace QuanLyBanVeXe
{
    partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.label1 = new System.Windows.Forms.Label();
			this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
			this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
			this.btnLogin = new Bunifu.Framework.UI.BunifuThinButton2();
			this.txtMatKhau = new System.Windows.Forms.TextBox();
			this.txtTaiKhoan = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(143, 21);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 28);
			this.label1.TabIndex = 0;
			this.label1.Text = "Login";
			// 
			// bunifuImageButton2
			// 
			this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
			this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
			this.bunifuImageButton2.ImageActive = null;
			this.bunifuImageButton2.Location = new System.Drawing.Point(26, 122);
			this.bunifuImageButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.bunifuImageButton2.Name = "bunifuImageButton2";
			this.bunifuImageButton2.Size = new System.Drawing.Size(46, 37);
			this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.bunifuImageButton2.TabIndex = 6;
			this.bunifuImageButton2.TabStop = false;
			this.bunifuImageButton2.Zoom = 10;
			// 
			// bunifuImageButton1
			// 
			this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
			this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
			this.bunifuImageButton1.ImageActive = null;
			this.bunifuImageButton1.Location = new System.Drawing.Point(26, 67);
			this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.bunifuImageButton1.Name = "bunifuImageButton1";
			this.bunifuImageButton1.Size = new System.Drawing.Size(47, 37);
			this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.bunifuImageButton1.TabIndex = 6;
			this.bunifuImageButton1.TabStop = false;
			this.bunifuImageButton1.Zoom = 10;
			// 
			// btnLogin
			// 
			this.btnLogin.ActiveBorderThickness = 1;
			this.btnLogin.ActiveCornerRadius = 20;
			this.btnLogin.ActiveFillColor = System.Drawing.Color.SeaGreen;
			this.btnLogin.ActiveForecolor = System.Drawing.Color.White;
			this.btnLogin.ActiveLineColor = System.Drawing.Color.SeaGreen;
			this.btnLogin.BackColor = System.Drawing.Color.Silver;
			this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
			this.btnLogin.ButtonText = "Login";
			this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.ForeColor = System.Drawing.Color.SeaGreen;
			this.btnLogin.IdleBorderThickness = 1;
			this.btnLogin.IdleCornerRadius = 20;
			this.btnLogin.IdleFillColor = System.Drawing.Color.White;
			this.btnLogin.IdleForecolor = System.Drawing.Color.SeaGreen;
			this.btnLogin.IdleLineColor = System.Drawing.Color.SeaGreen;
			this.btnLogin.Location = new System.Drawing.Point(133, 189);
			this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(125, 33);
			this.btnLogin.TabIndex = 3;
			this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnLogin.Click += new System.EventHandler(this.btnDangNhap_Click);
			// 
			// txtMatKhau
			// 
			this.txtMatKhau.Location = new System.Drawing.Point(93, 139);
			this.txtMatKhau.Name = "txtMatKhau";
			this.txtMatKhau.PasswordChar = '*';
			this.txtMatKhau.Size = new System.Drawing.Size(232, 20);
			this.txtMatKhau.TabIndex = 7;
			// 
			// txtTaiKhoan
			// 
			this.txtTaiKhoan.Location = new System.Drawing.Point(93, 84);
			this.txtTaiKhoan.Name = "txtTaiKhoan";
			this.txtTaiKhoan.Size = new System.Drawing.Size(232, 20);
			this.txtTaiKhoan.TabIndex = 8;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Silver;
			this.ClientSize = new System.Drawing.Size(361, 235);
			this.Controls.Add(this.txtTaiKhoan);
			this.Controls.Add(this.txtMatKhau);
			this.Controls.Add(this.bunifuImageButton2);
			this.Controls.Add(this.bunifuImageButton1);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "Form1";
			this.Text = "Đăng Nhập";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLogin;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
		private System.Windows.Forms.TextBox txtMatKhau;
		private System.Windows.Forms.TextBox txtTaiKhoan;
	}
}

