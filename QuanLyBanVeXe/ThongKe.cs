using System;
using System.Windows.Forms;

namespace QuanLyBanVeXe
{
    public partial class ThongKe : UserControl
    {
        public ThongKe()
        {
            InitializeComponent();
            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.sp_ThongKeVeTableAdapter.Fill(this.QLBanVeXeDataSet.sp_ThongKeVe,int.Parse(dtpYear.Value.Year.ToString()));
            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void ThongKe_Load(object sender, EventArgs e)
        {

        }

        private void reportViewer2_Load(object sender, EventArgs e)
        {

        }

       
    }
}
