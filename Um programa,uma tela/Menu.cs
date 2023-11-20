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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_Exe1_Click(object sender, EventArgs e)
        {
            Exercicio1 Exe1 = new Exercicio1();
            this.Hide();
            Exe1.Show();
        }

        private void btn_Exe6_Click(object sender, EventArgs e)
        {
            Exercicio6 Exe6 = new Exercicio6();
            this.Hide();
            Exe6.Show();
        }

        private void btn_Exe5_Click(object sender, EventArgs e)
        {
            Exercicio5 Exe5 = new Exercicio5();
            this.Hide();
            Exe5.Show();
        }

        private void btn_Exe2_Click(object sender, EventArgs e)
        {
            Exercicio2 Exe2 = new Exercicio2();
            this.Hide();
            Exe2.Show();
        }

        private void btn_Exe9_Click(object sender, EventArgs e)
        {
            Exercicio9 Exe9 = new Exercicio9();
            this.Hide();
            Exe9.Show();
        }

        private void btn_Exe8_Click(object sender, EventArgs e)
        {
            Exercicio8 Exe8 = new Exercicio8();
            this.Hide();
            Exe8.Show();
        }

        private void btn_Exe3_Click(object sender, EventArgs e)
        {
            Exercicio3 Exe3 = new Exercicio3();
            this.Hide();
            Exe3.Show();
        }

        private void btn_Exe4_Click(object sender, EventArgs e)
        {
            Exercicio4 Exe4 = new Exercicio4();
            this.Hide();
            Exe4.Show();
        }

        private void btn_Exe10_Click(object sender, EventArgs e)
        {
            Exercicio10 Exe10 = new Exercicio10();
            this.Hide();
            Exe10.Show();
        }

        private void btn_Exe7_Click(object sender, EventArgs e)
        {
            Exercicio7 Exe7 = new Exercicio7();
            this.Hide();
            Exe7.Show();
        }
    }
}
