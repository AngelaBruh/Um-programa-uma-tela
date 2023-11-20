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
    public partial class Exercicio1 : Form
    {
        public Exercicio1()
        {
            InitializeComponent();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txt_Peso.Clear();
            txt_Altura.Clear();
            txt_Idade.Clear();
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
            int Idd;
            double PC, Alt, GEB;
            try 
            { 
            Idd = int.Parse(txt_Idade.Text);
            PC = double.Parse(txt_Peso.Text);
            Alt = double.Parse(txt_Altura.Text);

             if(cbo_Genêro.SelectedItem == "Feminino")
                {
                    GEB = 655.1 + (9.56 * PC) + (1.85 * Alt) - (4.67 * Idd);
                    txt_Result.Text = GEB.ToString();
                    txt_Result.Visible = true;
                }
             else if (cbo_Genêro.SelectedItem == "Masculino")
                {
                    GEB = 66.47 + (13.75 * PC) + (5 * Alt) - (6.76 * Idd);
                    txt_Result.Text = GEB.ToString();
                    txt_Result.Visible = true;
                }
             if((Idd < 0) || (PC < 0 ) || (Alt < 0 ))
                {
                    txt_Result.Visible = false;
                    MessageBox.Show(String.Concat("Você digitou um número negativo !", "\r\n", "Tente Novamente !"),"Erro");                    
                }
            }
            catch(System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }           
        }
    }
}
