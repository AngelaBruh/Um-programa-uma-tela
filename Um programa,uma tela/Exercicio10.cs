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
    public partial class Exercicio10 : Form
    {
        public Exercicio10()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txt_n1.Clear();
            txt_n2.Clear();
            txt_n3.Clear();
            txt_Result.Clear();
        }

        private void btn_Somar_Click(object sender, EventArgs e)
        {
            int n1, n2, n3, contador1 = 0, contador2 = 0, contador3 = 0, Soma;
            try
            {
                n1 = int.Parse(txt_n1.Text);
                n2 = int.Parse(txt_n2.Text);
                n3 = int.Parse(txt_n3.Text);

                for (int i = 1; i <= n1; i++)
                {
                    if (n1 % i == 0)
                        contador1++;
                }            


                for (int i = 1; i <= n2; i++)
                {
                    if (n2 % i == 0)
                        contador2++;
                }              


                for (int i = 1; i <= n3; i++)
                {
                    if (n3 % i == 0)
                        contador3++;
                }
                               

                if((contador1 == 2) & (contador2 == 2) & (contador3 == 2))
                {
                    Soma = n1 + n2 + n3;
                    txt_Result.Text = "Soma total dos números primos: " + Soma;
                }
                if ((contador1 > 2) & (contador2 == 2) & (contador3 == 2))
                {
                    Soma = n2 + n3;
                    txt_Result.Text = "Soma total dos números primos: " + Soma;
                }
                if ((contador1 == 2) & (contador2 > 2) & (contador3 == 2))
                {
                    Soma = n1 + n3;
                    txt_Result.Text = "Soma total dos números primos: " + Soma;
                }
                if ((contador1 == 2) & (contador2 == 2) & (contador3 > 2))
                {
                    Soma = n1 + n2 ;
                    txt_Result.Text = "Soma total dos números primos: " + Soma;
                }


                if ((contador1 == 2) & (contador2 > 2) & (contador3 > 2))
                {                  
                    txt_Result.Text = "Soma total dos números primos: " + n1;
                }
                if ((contador1 > 2) & (contador2 == 2) & (contador3 > 2))
                {                
                    txt_Result.Text = "Soma total dos números primos: " + n2;
                }
                if ((contador1 > 2) & (contador2 > 2) & (contador3 == 2))
                {               
                    txt_Result.Text = "Soma total dos números primos: " + n3;
                }


                if ((contador1 > 2) & (contador2 > 2) & (contador3 > 2))
                {                   
                    txt_Result.Text = "Nenhum dos números informados é primo.";
                }
            }
            catch(System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }
    }
}
