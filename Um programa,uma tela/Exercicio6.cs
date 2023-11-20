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
    public partial class Exercicio6 : Form
    {
        public Exercicio6()
        {
            InitializeComponent();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txt_Entra.Clear();
            txt_Result.Clear();
            txt_Result.Visible = false;
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            int H, R;
            try
            {
                H = int.Parse(txt_Entra.Text);
                
                if(rad_Manha.Checked)
                {
                    if((H >= 6 ) && (H <= 12))
                    {
                        R = H + 6;
                        txt_Result.Text = R.ToString();
                        txt_Result.Visible = true;
                    }
                    else
                    {
                        txt_Result.Text = " Informe um horário válido !";
                        txt_Result.Visible = true;
                    }
                    if (H < 0)
                    {
                        txt_Result.Visible = false;
                        MessageBox.Show(String.Concat("Você digitou um número negativo!", "\r\n", "Tente Novamente!"), "Erro");
                    }
                }
                else if(rad_Tarde.Checked)
                {
                    if((H >= 13) && (H <= 17))
                    {
                        R = H + 6;
                        txt_Result.Text = R.ToString();
                        txt_Result.Visible = true;
                    }
                    else
                    {
                        txt_Result.Text = " Informe um horário válido !";
                        txt_Result.Visible = true;
                    }
                    if (H < 0)
                    {
                        txt_Result.Visible = false;
                        MessageBox.Show(String.Concat("Você digitou um número negativo!", "\r\n", "Tente Novamente!"), "Erro");
                    }
                }
                else if(rad_Noite.Checked)
                {
                    if(H == 18)
                    {
                        txt_Result.Text = " 0 Meia Noite";
                        txt_Result.Visible = true;
                    }
                    else if((H  >=  19) && (H <= 23))
                    {
                        R = H - 18;
                        txt_Result.Text = R.ToString();
                        txt_Result.Visible = true;
                    }   
                    else
                    {
                        txt_Result.Text = " Informe um horário válido!";
                        txt_Result.Visible = true;
                    }
                    if (H < 0)
                    {
                        txt_Result.Visible = false;
                        MessageBox.Show(String.Concat("Você digitou um número negativo!", "\r\n", "Tente Novamente!"), "Erro");
                    }
                }
                else if(rad_Madrugada.Checked)
                {
                    if((H >= 0) && (H <= 5))
                    {
                        R = H + 6;
                        txt_Result.Text = R.ToString();
                        txt_Result.Visible = true;
                    }
                    else
                    {
                        txt_Result.Text = " Informe um horário válido!";
                        txt_Result.Visible = true;
                    }
                    if(H < 0)
                    {
                        txt_Result.Visible = false;
                        MessageBox.Show(String.Concat("Você digitou um número negativo!", "\r\n", "Tente Novamente!"), "Erro");
                    }
                }                
            }
            catch(System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
               

        }
    }
}
