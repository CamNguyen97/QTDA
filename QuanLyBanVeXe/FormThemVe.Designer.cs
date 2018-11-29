namespace QuanLyBanVeXe
{
    partial class FormThemVe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThemVe));
            this.label2 = new System.Windows.Forms.Label();
            this.txtGiaVe = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnThem = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbMaChuyenDi = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Giá Vé :";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtGiaVe
            // 
            this.txtGiaVe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaVe.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtGiaVe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGiaVe.HintForeColor = System.Drawing.Color.Empty;
            this.txtGiaVe.HintText = "";
            this.txtGiaVe.isPassword = false;
            this.txtGiaVe.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtGiaVe.LineIdleColor = System.Drawing.Color.Gray;
            this.txtGiaVe.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtGiaVe.LineThickness = 3;
            this.txtGiaVe.Location = new System.Drawing.Point(195, 39);
            this.txtGiaVe.Margin = new System.Windows.Forms.Padding(4);
            this.txtGiaVe.Name = "txtGiaVe";
            this.txtGiaVe.Size = new System.Drawing.Size(313, 33);
            this.txtGiaVe.TabIndex = 2;
            this.txtGiaVe.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.btnThem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnThem.IdleBorderThickness = 1;
            this.btnThem.IdleCornerRadius = 20;
            this.btnThem.IdleFillColor = System.Drawing.Color.White;
            this.btnThem.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnThem.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnThem.Location = new System.Drawing.Point(399, 151);
            this.btnThem.Margin = new System.Windows.Forms.Padding(5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(109, 35);
            this.btnThem.TabIndex = 3;
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Chuyến Đi :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbbMaChuyenDi
            // 
            this.cbbMaChuyenDi.BackColor = System.Drawing.Color.Gainsboro;
            this.cbbMaChuyenDi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaChuyenDi.FormattingEnabled = true;
            this.cbbMaChuyenDi.Location = new System.Drawing.Point(195, 98);
            this.cbbMaChuyenDi.Name = "cbbMaChuyenDi";
            this.cbbMaChuyenDi.Size = new System.Drawing.Size(313, 28);
            this.cbbMaChuyenDi.TabIndex = 1;
            // 
            // FormThemVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(549, 203);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtGiaVe);
            this.Controls.Add(this.cbbMaChuyenDi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormThemVe";
            this.Text = "FormThemVe";
            this.Load += new System.EventHandler(this.FormThemVe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtGiaVe;
        private Bunifu.Framework.UI.BunifuThinButton2 btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbMaChuyenDi;
    }
}