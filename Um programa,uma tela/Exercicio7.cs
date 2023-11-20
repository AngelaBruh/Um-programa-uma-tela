using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Um_programa_uma_tela
{
    public partial class Exercicio7 : Form
    {
        public Exercicio7()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            int n1, n2, n3, n4, n5, n6, R;
            try
            {
                n1 = int.Parse(txt_n1.Text);
                n2 = int.Parse(txt_n2.Text);
                n3 = int.Parse(txt_n3.Text);
                n4 = int.Parse(txt_n4.Text);
                n5 = int.Parse(txt_n5.Text);
                n6 = int.Parse(txt_n6.Text);

                if (n1 > 0 & n2 > 0 & n3 > 0 & n4 > 0 & n5 > 0 & n6 > 0)
                {
                    R = n1 + n2 + n3 + n4 + n5 + n6;
                    txt_Result.Text = "Total: " + R;
                }
                if (n1 < 0 & n2 > 0 & n3 > 0 & n4 > 0 & n5 > 0 & n6 > 0)
                {
                    R = (n2 + n3 + n4 + n5 + n6) / 6;
                    txt_Result.Text = "Media dos números positivos: " + R;
                }
                if (n1 > 0 & n2 < 0 & n3 > 0 & n4 > 0 & n5 > 0 & n6 > 0)
                {
                    R = (n1 + n3 + n4 + n5 + n6) / 6;
                    txt_Result.Text = "Media dos números positivos: " + R;
                }
                if (n1 > 0 & n2 > 0 & n3 < 0 & n4 > 0 & n5 > 0 & n6 > 0)
                {
                    R = (n1 + n2 + n4 + n5 + n6) / 6;
                    txt_Result.Text = "Media dos números positivos: " + R;
                }
                if (n1 > 0 & n2 > 0 & n3 > 0 & n4 < 0 & n5 > 0 & n6 > 0)
                {
                    R = (n1 + n2 + n3 + n5 + n6) / 6;
                    txt_Result.Text = "Media dos números positivos: " + R;
                }
                if (n1 > 0 & n2 > 0 & n3 > 0 & n4 > 0 & n5 < 0 & n6 > 0)
                {
                    R = (n1 + n2 + n3 + n4 + n6) / 6;
                    txt_Result.Text = "Media dos números positivos: " + R;
                }
                if (n1 > 0 & n2 > 0 & n3 > 0 & n4 > 0 & n5 > 0 & n6 < 0)
                {
                    R = (n1 + n2 + n3 + n4 + n5) / 6;
                    txt_Result.Text = "Media dos números positivos: " + R;
                }

                if (n1 < 0 & n2 < 0 & n3 < 0 & n4 < 0 & n5 < 0 & n6 < 0)
                {
                    MessageBox.Show("Digite somente um número negativo!", "Erro");
                }
            }
            catch(System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }        
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            txt_n1.Clear();
            txt_n2.Clear();
            txt_n3.Clear();
            txt_n4.Clear();
            txt_n5.Clear();
            txt_n6.Clear();
            txt_Result.Clear();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Telado7 instruções = new Telado7();
            this.Hide();
            instruções.Show();
        }
    }
}
