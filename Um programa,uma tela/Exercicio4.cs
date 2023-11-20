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
    public partial class Exercicio4 : Form
    {
        public Exercicio4()
        {
            InitializeComponent();
        }     

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }

        private void btn_Img1_Click(object sender, EventArgs e)
        {
            int n1, n2, n3, P, S, T;
            try
            {
                n1 = int.Parse(txt_n1.Text);
                n2 = int.Parse(txt_n2.Text);
                n3 = int.Parse(txt_n3.Text);

                if (n1 < n2 && n1 < n3)
                {
                    P = n1;
                    if (n2 < n3)
                    {
                        S = n2;
                        T = n3;
                    }
                    else
                    {
                        S = n3;
                        T = n2;
                    }
                    MessageBox.Show(String.Concat(P, "\r\n", S, "\r\n", T), "Ordem crescente:");
                }


                if (n2 < n3 && n2 < n1)
                {
                    P = n2;
                    if (n1 < n3)
                    {
                        S = n1;
                        T = n3;
                    }
                    else
                    {
                        S = n3;
                        T = n1;
                    }
                    MessageBox.Show(String.Concat(P, "\r\n", S, "\r\n", T), "Ordem crescente:");
                }


                if (n3 < n1 && n3 < n2)
                {
                    P = n3;
                    if (n2 < n1)
                    {
                        S = n2;
                        T = n1;
                    }
                    else
                    {
                        S = n1;
                        T = n2;
                    }
                    MessageBox.Show(String.Concat(P, "\r\n", S, "\r\n", T), "Ordem crescente:");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txt_n1.Clear();
            txt_n2.Clear();
            txt_n3.Clear();    
        }

        private void btn_Img2_Click(object sender, EventArgs e)
        {
            int n1, n2, n3, P, S, T;
            try
            {
                n1 = int.Parse(txt_n1.Text);
                n2 = int.Parse(txt_n2.Text);
                n3 = int.Parse(txt_n3.Text);

                if (n1 > n2 && n1 > n3)
                {
                    P = n1;
                    if (n2 > n3)
                    {
                        S = n2;
                        T = n3;
                    }
                    else
                    {
                        S = n3;
                        T = n2;
                    }
                    MessageBox.Show(String.Concat(P, "\r\n", S, "\r\n", T), "Ordem decrescente:");
                }


                if (n2 > n3 && n2 > n1)
                {
                    P = n2;
                    if (n1 > n3)
                    {
                        S = n1;
                        T = n3;
                    }
                    else
                    {
                        S = n3;
                        T = n1;
                    }
                    MessageBox.Show(String.Concat(P, "\r\n", S, "\r\n", T), "Ordem decrescente:");
                }


                if (n3 > n1 && n3 > n2)
                {
                    P = n3;
                    if (n2 > n1)
                    {
                        S = n2;
                        T = n1;
                    }
                    else
                    {
                        S = n1;
                        T = n2;
                    }
                    MessageBox.Show(String.Concat(P, "\r\n", S, "\r\n", T), "Ordem decrescente:");
                }
            }
            catch(System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }
    }
}
