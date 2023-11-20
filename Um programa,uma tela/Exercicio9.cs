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
    public partial class Exercicio9 : Form
    {
        public Exercicio9()
        {
            InitializeComponent();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txt_Digite.Clear();
            txt_Result.Clear();           
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }

        private void txt_Digite_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Digite um número";
        }

        private void txt_Digite_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = " ";
        }

        private void btn_Voltar_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Clique para voltar ao Menu.";
        }

        private void btn_Voltar_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = " ";
        }

        private void btn_Somar_Click(object sender, EventArgs e)
        {
            try
            { 
                 int i, N, Soma;
                 N = int.Parse(txt_Digite.Text);
                 Soma = 0;           
                           
                i = 1;
                while (i <= N)
                {
                    Soma = Soma + i;
                    txt_Result.Text = Soma.ToString();
                    i++;
                }
                if (N<0)
                {
                    MessageBox.Show(String.Concat("Você digitou um número negativo !", "\r\n", " Tente Novamente !"),"Erro");
                }
            }                     
            catch(System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }       

        private void btn_Somar_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Clique para realizar a operação";
        }

        private void btn_Somar_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = " ";
        }
    }
}
