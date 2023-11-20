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
    public partial class Exercicio2 : Form
    {
        public Exercicio2()
        {
            InitializeComponent();
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txt_digite.Clear();
            txt_Result.Clear();
            txt_Result.Visible = false;
            prg_Convertendo.Visible = false;
        }

        private void btn_Converter_Click(object sender, EventArgs e)
        {                     
            try
            {           
                string N = string.Empty;
                string centena = string.Empty;
                string dezena = string.Empty;
                string unidade = string.Empty;
                string extenso = string.Empty;

                N = Convert.ToString(txt_digite.Text);
                N = N.PadLeft(3, '0');


                if (N[0] != '0')
                {

                    switch (N[0])
                    {

                        case '1': centena = "Cento "; break;
                        case '2': centena = "Duzentos "; break;
                        case '3': centena = "Trezentos "; break;
                        case '4': centena = "Quatrocentos "; break;
                        case '5': centena = "Quinhentos "; break;
                        case '6': centena = "Seiscentos "; break;
                        case '7': centena = "Setecentos "; break;
                        case '8': centena = "Oitocentos "; break;
                        case '9': centena = "Novecentos "; break;

                    }
                    if (N[0] == '1' && N[1] == '0' && N[2] == '0')
                    {
                        centena = "Cem";
                    }                    
                }


                if (N[1] == '1')
                {
                    switch (N.Substring(1))
                    {
                        case "10": dezena = "e Dez"; break;
                        case "11": dezena = "e Onze"; break;
                        case "12": dezena = "e Doze"; break;
                        case "13": dezena = "e Treze"; break;
                        case "14": dezena = "e Quatorze"; break;
                        case "15": dezena = "e Quinze"; break;
                        case "16": dezena = "e Dezesseis"; break;
                        case "17": dezena = "e Dezessete"; break;
                        case "18": dezena = "e Dezoito"; break;
                        case "19": dezena = "e Dezenove"; break;
                    }                   
                }
                else if (N[1] != '0')
                {
                    switch (N[1])
                    {
                        case '2': dezena = "e Vinte "; break;
                        case '3': dezena = "e Trinta "; break;
                        case '4': dezena = "e Quarenta "; break;
                        case '5': dezena = "e Cinquenta "; break;
                        case '6': dezena = "e Sessenta "; break;
                        case '7': dezena = "e Setenta "; break;
                        case '8': dezena = "e Oitenta "; break;
                        case '9': dezena = "e Noventa "; break;
                    }
                }              


                if (N[2] >= '0' && N[1] != '1')
                {
                    switch (N[2])
                    {                     
                        case '1': unidade = "e Um"; break;
                        case '2': unidade = "e Dois"; break;
                        case '3': unidade = "e Três"; break;
                        case '4': unidade = "e Quatro"; break;
                        case '5': unidade = "e Cinco"; break;
                        case '6': unidade = "e Seis"; break;
                        case '7': unidade = "e Sete"; break;
                        case '8': unidade = "e Oito"; break;
                        case '9': unidade = "e Nove"; break;
                    }
                    if (N[0] == '0' && N[1] == '0' && N[2] == '0')
                    {
                        unidade = "Zero";
                    }                                   
                }           

                // CRIAR EXTENSO
                extenso = centena + dezena + unidade;
                // COMANDO DE SAIDA
                if (extenso[0] == 'e')
                {
                    extenso = extenso.Substring(2);
                }
                txt_Result.Text = extenso.ToString();
                txt_Result.Visible = true;

                int N1;
                N1 = int.Parse(txt_digite.Text);

                if (N1 >= 1000)
                {
                    txt_Result.Visible = false;           
                    MessageBox.Show("Informe número entre 0 e 999", "Erro");
                }


                prg_Convertendo.Maximum = 100;
                     for (int i = 0; i <= 100; i++)
                     {
                         prg_Convertendo.Value = i;
                     }
                     prg_Convertendo.Visible = true;
          
            }
            catch(System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }            
        }
    }
}
