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
    public partial class FormXe34 : Form
    {
        List<Button> listBtn;
        int vitri = 0;

        public FormXe34()
        {
            InitializeComponent();
        }

        private void FormXe34_Load(object sender, EventArgs e)
        {

        }

        public void LoadData(int mave) {
            listBtn = new List<Button>() { b2, b3, b4, b5, b6, b7, b8, b9, b10, b11, b12, b13, b14, b15, b16 ,b17 , b18,b19,b20,b21,b22,b23,b24,b25,b26,b27,b28,b29,b30,b31,b32,b33,b34};

            DataTable dt = new DataTable();
            dt = DAO.VeBanDAO.Instance.getViTri(mave);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int a = int.Parse(dt.Rows[i][0].ToString());
                for (int j = 0; j < 33; j++)
                {
                    if (int.Parse(listBtn[j].Text.ToString()) == a)
                    {
                        listBtn[j].Enabled = false;
                        listBtn[j].BackColor = Color.Blue;

                    }
                }
            }
        }

        private void b2_Click(object sender, EventArgs e)
        {
            vitri = 2;
            for (int i = 0; i < 33; i++)
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
            for (int i = 0; i < 33; i++)
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
            for (int i = 0; i < 33; i++)
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
            for (int i = 0; i < 33; i++)
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
            for (int i = 0; i < 33; i++)
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
            for (int i = 0; i < 33; i++)
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
            for (int i = 0; i < 33; i++)
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
            for (int i = 0; i < 33; i++)
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
            for (int i = 0; i < 33; i++)
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
            for (int i = 0; i < 33; i++)
            {
                if (listBtn[i].BackColor == Color.Aqua)
                {
                    listBtn[i].BackColor = Color.Gainsboro;
                }
            }
            b11.BackColor = Color.Aqua;
        }

        private void b13_Click(object sender, EventArgs e)
        {
            vitri = 13;
            for (int i = 0; i < 33; i++)
            {
                if (listBtn[i].BackColor == Color.Aqua)
                {
                    listBtn[i].BackColor = Color.Gainsboro;
                }
            }
            b13.BackColor = Color.Aqua;
        }

        private void b12_Click(object sender, EventArgs e)
        {
            vitri = 12;
            for (int i = 0; i < 33; i++)
            {
                if (listBtn[i].BackColor == Color.Aqua)
                {
                    listBtn[i].BackColor = Color.Gainsboro;
                }
            }
            b12.BackColor = Color.Aqua;
        }

        private void b14_Click(object sender, EventArgs e)
        {
            vitri = 14;
            for (int i = 0; i < 33; i++)
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
            for (int i = 0; i < 33; i++)
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
            for (int i = 0; i < 33; i++)
            {
                if (listBtn[i].BackColor == Color.Aqua)
                {
                    listBtn[i].BackColor = Color.Gainsboro;
                }
            }
            b16.BackColor = Color.Aqua;
        }

        private void b17_Click(object sender, EventArgs e)
        {
            vitri = 17;
            for (int i = 0; i < 33; i++)
            {
                if (listBtn[i].BackColor == Color.Aqua)
                {
                    listBtn[i].BackColor = Color.Gainsboro;
                }
            }
            b17.BackColor = Color.Aqua;
        }

        private void b18_Click(object sender, EventArgs e)
        {
            vitri = 18;
            for (int i = 0; i < 33; i++)
            {
                if (listBtn[i].BackColor == Color.Aqua)
                {
                    listBtn[i].BackColor = Color.Gainsboro;
                }
            }
            b18.BackColor = Color.Aqua;
        }

        private void b19_Click(object sender, EventArgs e)
        {
            vitri = 19;
            for (int i = 0; i < 33; i++)
            {
                if (listBtn[i].BackColor == Color.Aqua)
                {
                    listBtn[i].BackColor = Color.Gainsboro;
                }
            }
            b19.BackColor = Color.Aqua;
        }

        private void b20_Click(object sender, EventArgs e)
        {
            vitri = 20;
            for (int i = 0; i < 33; i++)
            {
                if (listBtn[i].BackColor == Color.Aqua)
                {
                    listBtn[i].BackColor = Color.Gainsboro;
                }
            }
            b20.BackColor = Color.Aqua;
        }

        private void b21_Click(object sender, EventArgs e)
        {
            vitri = 21;
            for (int i = 0; i < 33; i++)
            {
                if (listBtn[i].BackColor == Color.Aqua)
                {
                    listBtn[i].BackColor = Color.Gainsboro;
                }
            }
            b21.BackColor = Color.Aqua;
        }

        private void b22_Click(object sender, EventArgs e)
        {
            vitri = 22;
            for (int i = 0; i < 33; i++)
            {
                if (listBtn[i].BackColor == Color.Aqua)
                {
                    listBtn[i].BackColor = Color.Gainsboro;
                }
            }
            b22.BackColor = Color.Aqua;
        }

        private void b23_Click(object sender, EventArgs e)
        {
            vitri = 23;
            for (int i = 0; i < 33; i++)
            {
                if (listBtn[i].BackColor == Color.Aqua)
                {
                    listBtn[i].BackColor = Color.Gainsboro;
                }
            }
            b23.BackColor = Color.Aqua;
        }

        private void b24_Click(object sender, EventArgs e)
        {
            vitri = 24;
            for (int i = 0; i < 33; i++)
            {
                if (listBtn[i].BackColor == Color.Aqua)
                {
                    listBtn[i].BackColor = Color.Gainsboro;
                }
            }
            b24.BackColor = Color.Aqua;
        }

        private void b25_Click(object sender, EventArgs e)
        {
            vitri = 25;
            for (int i = 0; i < 33; i++)
            {
                if (listBtn[i].BackColor == Color.Aqua)
                {
                    listBtn[i].BackColor = Color.Gainsboro;
                }
            }
            b25.BackColor = Color.Aqua;
        }

        private void b26_Click(object sender, EventArgs e)
        {
            vitri = 26;
            for (int i = 0; i < 33; i++)
            {
                if (listBtn[i].BackColor == Color.Aqua)
                {
                    listBtn[i].BackColor = Color.Gainsboro;
                }
            }
            b26.BackColor = Color.Aqua;
        }

        private void b27_Click(object sender, EventArgs e)
        {
            vitri = 27;
            for (int i = 0; i < 33; i++)
            {
                if (listBtn[i].BackColor == Color.Aqua)
                {
                    listBtn[i].BackColor = Color.Gainsboro;
                }
            }
            b27.BackColor = Color.Aqua;
        }

        private void b28_Click(object sender, EventArgs e)
        {
            vitri = 28;
            for (int i = 0; i < 33; i++)
            {
                if (listBtn[i].BackColor == Color.Aqua)
                {
                    listBtn[i].BackColor = Color.Gainsboro;
                }
            }
            b28.BackColor = Color.Aqua;
        }

        private void b29_Click(object sender, EventArgs e)
        {
            vitri = 29;
            for (int i = 0; i < 33; i++)
            {
                if (listBtn[i].BackColor == Color.Aqua)
                {
                    listBtn[i].BackColor = Color.Gainsboro;
                }
            }
            b29.BackColor = Color.Aqua;
        }

        private void b30_Click(object sender, EventArgs e)
        {
            vitri = 30;
            for (int i = 0; i < 33; i++)
            {
                if (listBtn[i].BackColor == Color.Aqua)
                {
                    listBtn[i].BackColor = Color.Gainsboro;
                }
            }
            b30.BackColor = Color.Aqua;
        }

        private void b31_Click(object sender, EventArgs e)
        {
            vitri = 31;
            for (int i = 0; i < 33; i++)
            {
                if (listBtn[i].BackColor == Color.Aqua)
                {
                    listBtn[i].BackColor = Color.Gainsboro;
                }
            }
            b31.BackColor = Color.Aqua;
        }

        private void b32_Click(object sender, EventArgs e)
        {
            vitri = 32;
            for (int i = 0; i < 33; i++)
            {
                if (listBtn[i].BackColor == Color.Aqua)
                {
                    listBtn[i].BackColor = Color.Gainsboro;
                }
            }
            b32.BackColor = Color.Aqua;
        }

        private void b33_Click(object sender, EventArgs e)
        {
            vitri = 33;
            for (int i = 0; i < 33; i++)
            {
                if (listBtn[i].BackColor == Color.Aqua)
                {
                    listBtn[i].BackColor = Color.Gainsboro;
                }
            }
            b33.BackColor = Color.Aqua;
        }

        private void b34_Click(object sender, EventArgs e)
        {
            vitri = 34;
            for (int i = 0; i < 33; i++)
            {
                if (listBtn[i].BackColor == Color.Aqua)
                {
                    listBtn[i].BackColor = Color.Gainsboro;
                }
            }
            b34.BackColor = Color.Aqua;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (vitri == 0)
            {
                MessageBox.Show("Chọn Vị Trí");
            }
            else
            {
                FormThemVeBan.vitri = vitri;
                FormSuaVeBan.vitri = vitri;
                this.Close();
            }
        }
    }
}
