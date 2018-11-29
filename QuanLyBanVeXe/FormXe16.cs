using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanVeXe
{
    public partial class FormXe16 : Form
    {
        int vitri = 0;

        public List<Button> listBtn ;

        public FormXe16()
        {
            InitializeComponent();
        }

        public void LoadData(int mave) {
            listBtn = new List<Button>() { b1,b2,b3,b4,b5,b6,b7,b8,b9,b10,b11,b12,b13,b14,b15,b16};

            DataTable dt = new DataTable();
            dt = DAO.VeBanDAO.Instance.getViTri(mave);
            for (int i = 0; i < dt.Rows.Count; i++) {
                int a = int.Parse(dt.Rows[i][0].ToString());
                for (int j = 0; j < 16; j++) {
                    if (int.Parse(listBtn[j].Text.ToString()) == a) {
                        listBtn[j].Enabled = false;
                        listBtn[j].BackColor = Color.Blue;

                    }
                }
            }
        }

        

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (vitri == 0) {
                MessageBox.Show("Chọn Vị Trí");
            }
            else
            {
                FormThemVeBan.vitri = vitri;
                FormSuaVeBan.vitri = vitri;
                this.Close();
            }
        }

        private void b1_Click(object sender, EventArgs e)
        {
            vitri = 1;
            for (int i = 0; i < 16; i++) {
                if (listBtn[i].BackColor == Color.Aqua) {
                    listBtn[i].BackColor = Color.Gainsboro;
                }
            }
            b1.BackColor = Color.Aqua;
        }

        private void b2_Click(object sender, EventArgs e)
        {
            vitri = 2;
            for (int i = 0; i < 16; i++)
            {
                if (listBtn[i].BackColor == Color.Aqua)
                {
                    listBtn[i].BackColor = Color.Gainsboro;
                }
            }
            b2.BackColor = Color.Aqua;
        }

        private void b3_Click(object sender, EventArgs e)
        {
            vitri = 3;
            for (int i = 0; i < 16; i++)
            {
                if (listBtn[i].BackColor == Color.Aqua)
                {
                    listBtn[i].BackColor = Color.Gainsboro;
                }
            }
            b3.BackColor = Color.Aqua;
        }

        private void b4_Click(object sender, EventArgs e)
        {
            vitri = 4;
            for (int i = 0; i < 16; i++)
            {
                if (listBtn[i].BackColor == Color.Aqua)
                {
                    listBtn[i].BackColor = Color.Gainsboro;
                }
            }
            b4.BackColor = Color.Aqua;
        }

        private void b5_Click(object sender, EventArgs e)
        {
            vitri = 5;
            for (int i = 0; i < 16; i++)
            {
                if (listBtn[i].BackColor == Color.Aqua)
                {
                    listBtn[i].BackColor = Color.Gainsboro;
                }
            }
            b5.BackColor = Color.Aqua;
        }

        private void b6_Click(object sender, EventArgs e)
        {
            vitri = 6;
            for (int i = 0; i < 16; i++)
            {
                if (listBtn[i].BackColor == Color.Aqua)
                {
                    listBtn[i].BackColor = Color.Gainsboro;
                }
            }
            b6.BackColor = Color.Aqua;
        }

        private void b7_Click(object sender, EventArgs e)
        {
            vitri = 7;
            for (int i = 0; i < 16; i++)
            {
                if (listBtn[i].BackColor == Color.Aqua)
                {
                    listBtn[i].BackColor = Color.Gainsboro;
                }
            }
            b7.BackColor = Color.Aqua;
        }

        private void b8_Click(object sender, EventArgs e)
        {
            vitri = 8;
            for (int i = 0; i < 16; i++)
            {
                if (listBtn[i].BackColor == Color.Aqua)
                {
                    listBtn[i].BackColor = Color.Gainsboro;
                }
            }
            b8.BackColor = Color.Aqua;
        }

        private void b9_Click(object sender, EventArgs e)
        {
            vitri = 9;
            for (int i = 0; i < 16; i++)
            {
                if (listBtn[i].BackColor == Color.Aqua)
                {
                    listBtn[i].BackColor = Color.Gainsboro;
                }
            }
            b9.BackColor = Color.Aqua;
        }

        private void b10_Click(object sender, EventArgs e)
        {
            vitri = 10;
            for (int i = 0; i < 16; i++)
            {
                if (listBtn[i].BackColor == Color.Aqua)
                {
                    listBtn[i].BackColor = Color.Gainsboro;
                }
            }
            b10.BackColor = Color.Aqua;
        }

        private void b11_Click(object sender, EventArgs e)
        {
            vitri = 11;
            for (int i = 0; i < 16; i++)
            {
                if (listBtn[i].BackColor == Color.Aqua)
                {
                    listBtn[i].BackColor = Color.Gainsboro;
                }
            }
            b11.BackColor = Color.Aqua;
        }

        private void b12_Click(object sender, EventArgs e)
        {
            vitri = 12;
            for (int i = 0; i < 16; i++)
            {
                if (listBtn[i].BackColor == Color.Aqua)
                {
                    listBtn[i].BackColor = Color.Gainsboro;
                }
            }
            b12.BackColor = Color.Aqua;
        }

        private void b13_Click(object sender, EventArgs e)
        {
            vitri = 13;
            for (int i = 0; i < 16; i++)
            {
                if (listBtn[i].BackColor == Color.Aqua)
                {
                    listBtn[i].BackColor = Color.Gainsboro;
                }
            }
            b13.BackColor = Color.Aqua;
        }

        private void b14_Click(object sender, EventArgs e)
        {
            vitri = 14;
            for (int i = 0; i < 16; i++)
            {
                if (listBtn[i].BackColor == Color.Aqua)
                {
                    listBtn[i].BackColor = Color.Gainsboro;
                }
            }
            b14.BackColor = Color.Aqua;
        }

        private void b15_Click(object sender, EventArgs e)
        {
            vitri = 15;
            for (int i = 0; i < 16; i++)
            {
                if (listBtn[i].BackColor == Color.Aqua)
                {
                    listBtn[i].BackColor = Color.Gainsboro;
                }
            }
            b15.BackColor = Color.Aqua;
        }

        private void b16_Click(object sender, EventArgs e)
        {
            vitri = 16;
            for (int i = 0; i < 16; i++)
            {
                if (listBtn[i].BackColor == Color.Aqua)
                {
                    listBtn[i].BackColor = Color.Gainsboro;
                }
            }
            b16.BackColor = Color.Aqua;
        }

        
    }
}
