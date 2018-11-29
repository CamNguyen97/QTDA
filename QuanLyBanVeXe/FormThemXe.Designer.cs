namespace QuanLyBanVeXe
{
    partial class FormThemXe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThemXe));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbLoaiXeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBanVeXeDataSet = new QuanLyBanVeXe.QLBanVeXeDataSet();
            this.tb_LoaiXeTableAdapter = new QuanLyBanVeXe.QLBanVeXeDataSetTableAdapters.tb_LoaiXeTableAdapter();
            this.cbbMaLoaiXe = new System.Windows.Forms.ComboBox();
            this.txtBienSoXe = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnSua = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.tbLoaiXeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBanVeXeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Loại Xe :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Biển Số Xe :";
            // 
            // tbLoaiXeBindingSource
            // 
            this.tbLoaiXeBindingSource.DataMember = "tb_LoaiXe";
            this.tbLoaiXeBindingSource.DataSource = this.qLBanVeXeDataSet;
            // 
            // qLBanVeXeDataSet
            // 
            this.qLBanVeXeDataSet.DataSetName = "QLBanVeXeDataSet";
            this.qLBanVeXeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_LoaiXeTableAdapter
            // 
            this.tb_LoaiXeTableAdapter.ClearBeforeFill = true;
            // 
            // cbbMaLoaiXe
            // 
            this.cbbMaLoaiXe.BackColor = System.Drawing.Color.Silver;
            this.cbbMaLoaiXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaLoaiXe.FormattingEnabled = true;
            this.cbbMaLoaiXe.Location = new System.Drawing.Point(176, 89);
            this.cbbMaLoaiXe.Name = "cbbMaLoaiXe";
            this.cbbMaLoaiXe.Size = new System.Drawing.Size(298, 33);
            this.cbbMaLoaiXe.TabIndex = 2;
            this.cbbMaLoaiXe.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtBienSoXe
            // 
            this.txtBienSoXe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBienSoXe.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtBienSoXe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBienSoXe.HintForeColor = System.Drawing.Color.Empty;
            this.txtBienSoXe.HintText = "";
            this.txtBienSoXe.isPassword = false;
            this.txtBienSoXe.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtBienSoXe.LineIdleColor = System.Drawing.Color.Gray;
            this.txtBienSoXe.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtBienSoXe.LineThickness = 3;
            this.txtBienSoXe.Location = new System.Drawing.Point(176, 24);
            this.txtBienSoXe.Margin = new System.Windows.Forms.Padding(4);
            this.txtBienSoXe.Name = "txtBienSoXe";
            this.txtBienSoXe.Size = new System.Drawing.Size(298, 33);
            this.txtBienSoXe.TabIndex = 1;
            this.txtBienSoXe.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnSua
            // 
            this.btnSua.ActiveBorderThickness = 1;
            this.btnSua.ActiveCornerRadius = 20;
            this.btnSua.ActiveFillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSua.ActiveForecolor = System.Drawing.Color.White;
            this.btnSua.ActiveLineColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSua.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSua.BackgroundImage")));
            this.btnSua.ButtonText = "Thêm";
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSua.IdleBorderThickness = 1;
            this.btnSua.IdleCornerRadius = 20;
            this.btnSua.IdleFillColor = System.Drawing.Color.White;
            this.btnSua.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnSua.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnSua.Location = new System.Drawing.Point(361, 144);
            this.btnSua.Margin = new System.Windows.Forms.Padding(5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(113, 37);
            this.btnSua.TabIndex = 3;
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSua.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormThemXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(515, 211);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.txtBienSoXe);
            this.Controls.Add(this.cbbMaLoaiXe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormThemXe";
            this.Text = "Thêm Xe";
            ((System.ComponentModel.ISupportInitialize)(this.tbLoaiXeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBanVeXeDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private QLBanVeXeDataSet qLBanVeXeDataSet;
        private System.Windows.Forms.BindingSource tbLoaiXeBindingSource;
        private QLBanVeXeDataSetTableAdapters.tb_LoaiXeTableAdapter tb_LoaiXeTableAdapter;
        private System.Windows.Forms.ComboBox cbbMaLoaiXe;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtBienSoXe;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSua;

    }
}