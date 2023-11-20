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
    public partial class Exercicio3 : Form
    {
        public Exercicio3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            int n1, n2;                 
            try
            {
                n1 = int.Parse(txt_n1.Text);
                n2 = int.Parse(txt_n2.Text);
                if ((rad_Sim.Checked) && (n1 % n2 == 0))
                {                                      
                    MessageBox.Show("Parabens você acertou ! " + n1 + " e " + n2 + " são multiplos!", "Parabens você acertoooou !!!");                                      
                }
                else if ((n1 % n2 == 0) && (rad_Não.Checked))
                {
                    MessageBox.Show("Você errou ! " + n1 + " e " + n2 + " são multiplos!", "Ops, você errooooou !!!");
                }
                else if ((n1 % n2 > 0) && (rad_Sim.Checked))
                {                   
                        MessageBox.Show("Você errou ! " + n1 + " e " + n2 + " não são multiplos!", "Ops, você errooooou !!!");                                  
                }
                else if ((n1 % n2 > 0) && (rad_Não.Checked))
                {
                    MessageBox.Show("Parabens você acertou ! " + n1 + " e " + n2 + " não são multiplos!", "Parabens você acertoooou !!!");
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
            rad_Sim.Checked = false;
            rad_Não.Checked = false;         
        }
    }
}
