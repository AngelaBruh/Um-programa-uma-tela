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
    public partial class Exercicio5 : Form
    {
        public Exercicio5()
        {
            InitializeComponent();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txt_HA.Clear();
            txt_HE.Clear();
            txt_Result.Clear();
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            int HA, HE, H;
            double C1, C2;
            try
            {
                HA = int.Parse(txt_HA.Text);
                HE = int.Parse(txt_HE.Text);

                H = (HE) - (2 / 3 * (HA));
                C1 = HE / 60;
                C2 = HA / 60;
                
                if(H > 2400)
                {
                    txt_Result.Text = String.Concat(Math.Truncate(C1) + " Horas extras trabalhadas.", "\r\n", Math.Truncate(C2) +
                        " Horas ausentes.", "\r\n", " Sua gratificação será de R$500,00.");
                }
                else if((H >= 1801) && (H <= 2400))
                {
                    txt_Result.Text = String.Concat(Math.Truncate(C1) + " Horas extras trabalhadas.", "\r\n", Math.Truncate(C2) +
                        " Horas ausentes.", "\r\n", " Sua gratificação será de R$400,00.");
                }
                else if((H >= 1201) && (H <= 1800))                
                {
                    txt_Result.Text = String.Concat(Math.Truncate(C1) + " Horas extras trabalhadas.", "\r\n", Math.Truncate(C2) +
                        " Horas ausentes.", "\r\n", " Sua gratificação será de R$300,00.");
                }
                else if((H >= 600) && (H <= 1200))
                {
                    txt_Result.Text = String.Concat(Math.Truncate(C1) + " Horas extras trabalhadas.", "\r\n", Math.Truncate(C2) +
                        " Horas ausentes.", "\r\n", " Sua gratificação será de R$200,00.");
                }
                else if(H <= 600)
                {
                    txt_Result.Text = String.Concat(Math.Truncate(C1) + " Horas extras trabalhadas.", "\r\n", Math.Truncate(C2) +
                        " Horas ausentes.", "\r\n", " Sua gratificação será de R$100,00.");
                }
                if((HE < 0) || (HA < 0))
                {
                   txt_Result.Text = (String.Concat("Você digitou um número negativo!", "\r\n", "Tente Novamente!"));
                }
            }
            catch(System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }
    }
}
