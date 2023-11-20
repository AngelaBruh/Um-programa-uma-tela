
namespace Um_programa_uma_tela
{
    partial class Exercicio5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exercicio5));
            this.lbl_01 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_02 = new System.Windows.Forms.Label();
            this.lbl_03 = new System.Windows.Forms.Label();
            this.txt_HE = new System.Windows.Forms.TextBox();
            this.txt_HA = new System.Windows.Forms.TextBox();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.txt_Result = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_01
            // 
            this.lbl_01.AutoSize = true;
            this.lbl_01.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_01.Location = new System.Drawing.Point(191, 9);
            this.lbl_01.Name = "lbl_01";
            this.lbl_01.Size = new System.Drawing.Size(378, 18);
            this.lbl_01.TabIndex = 0;
            this.lbl_01.Text = "Pegue aqui sua gratificação de natal:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(661, 184);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_02
            // 
            this.lbl_02.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_02.Location = new System.Drawing.Point(38, 217);
            this.lbl_02.Name = "lbl_02";
            this.lbl_02.Size = new System.Drawing.Size(301, 41);
            this.lbl_02.TabIndex = 2;
            this.lbl_02.Text = "Informe atráves de minutos as horas extras trabalhadas:";
            // 
            // lbl_03
            // 
            this.lbl_03.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_03.Location = new System.Drawing.Point(38, 290);
            this.lbl_03.Name = "lbl_03";
            this.lbl_03.Size = new System.Drawing.Size(324, 46);
            this.lbl_03.TabIndex = 3;
            this.lbl_03.Text = "Informe atráves de minutos as horas ausentes do trabalho:";
            // 
            // txt_HE
            // 
            this.txt_HE.Location = new System.Drawing.Point(41, 261);
            this.txt_HE.Name = "txt_HE";
            this.txt_HE.Size = new System.Drawing.Size(248, 26);
            this.txt_HE.TabIndex = 4;
            this.txt_HE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_HA
            // 
            this.txt_HA.Location = new System.Drawing.Point(41, 328);
            this.txt_HA.Name = "txt_HA";
            this.txt_HA.Size = new System.Drawing.Size(248, 26);
            this.txt_HA.TabIndex = 5;
            this.txt_HA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Limpar.Location = new System.Drawing.Point(107, 360);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(101, 29);
            this.btn_Limpar.TabIndex = 6;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = false;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Voltar.ForeColor = System.Drawing.Color.Blue;
            this.btn_Voltar.Location = new System.Drawing.Point(57, 395);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(203, 26);
            this.btn_Voltar.TabIndex = 7;
            this.btn_Voltar.Text = "Voltar ao Menu";
            this.btn_Voltar.UseVisualStyleBackColor = false;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Calcular.Location = new System.Drawing.Point(408, 220);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(264, 27);
            this.btn_Calcular.TabIndex = 8;
            this.btn_Calcular.Text = "Ver minha gratificação";
            this.btn_Calcular.UseVisualStyleBackColor = false;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // txt_Result
            // 
            this.txt_Result.Enabled = false;
            this.txt_Result.Location = new System.Drawing.Point(368, 253);
            this.txt_Result.Multiline = true;
            this.txt_Result.Name = "txt_Result";
            this.txt_Result.Size = new System.Drawing.Size(334, 203);
            this.txt_Result.TabIndex = 9;
            this.txt_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Exercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(729, 468);
            this.Controls.Add(this.txt_Result);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.txt_HA);
            this.Controls.Add(this.txt_HE);
            this.Controls.Add(this.lbl_03);
            this.Controls.Add(this.lbl_02);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_01);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Exercicio5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gratificação de natal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_01;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_02;
        private System.Windows.Forms.Label lbl_03;
        private System.Windows.Forms.TextBox txt_HE;
        private System.Windows.Forms.TextBox txt_HA;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.TextBox txt_Result;
    }
}