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
    public partial class Exercicio8 : Form
    {
        public Exercicio8()
        {
            InitializeComponent();
        }
        
        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }

        private void btn_X_Click(object sender, EventArgs e)
        {
            try
            {
                const double C = 2.00;
                const double R = 2.50;
                const double S = 1.50;
                int Total;               
                
                 if((nud_C.Value > 0) || (nud_R.Value > 0) || (nud_S.Value > 0 ) )  
                  {
                     Total = (int)((int)nud_C.Value * C) + (int)((int)nud_R.Value * R) + (int)((int)nud_S.Value * S);
                     MessageBox.Show(String.Concat("Total do pedido: " + Total + " reais", "\r\n", "Aguarde até que seu pedido esteja pronto!"));                  
                  }                   
                else if ((nud_C.Value == 0) && (nud_R.Value == 0) && (nud_S.Value == 0))
                {
                    MessageBox.Show("Porfavor, escolha ao menos um item para finalizar o pedido!");
                }
            }
            catch(System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }

        }
    }
}
