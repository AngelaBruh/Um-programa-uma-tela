
namespace Um_programa_uma_tela
{
    partial class Exercicio6
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
            this.lbl_01 = new System.Windows.Forms.Label();
            this.rad_Manha = new System.Windows.Forms.RadioButton();
            this.rad_Tarde = new System.Windows.Forms.RadioButton();
            this.rad_Noite = new System.Windows.Forms.RadioButton();
            this.lbl_02 = new System.Windows.Forms.Label();
            this.txt_Entra = new System.Windows.Forms.TextBox();
            this.lbl_03 = new System.Windows.Forms.Label();
            this.txt_Result = new System.Windows.Forms.TextBox();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.rad_Madrugada = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lbl_01
            // 
            this.lbl_01.AutoSize = true;
            this.lbl_01.Location = new System.Drawing.Point(47, 9);
            this.lbl_01.Name = "lbl_01";
            this.lbl_01.Size = new System.Drawing.Size(362, 22);
            this.lbl_01.TabIndex = 0;
            this.lbl_01.Text = "Selecione o periodo de trabalho:";
            // 
            // rad_Manha
            // 
            this.rad_Manha.AutoSize = true;
            this.rad_Manha.Location = new System.Drawing.Point(51, 34);
            this.rad_Manha.Name = "rad_Manha";
            this.rad_Manha.Size = new System.Drawing.Size(83, 26);
            this.rad_Manha.TabIndex = 1;
            this.rad_Manha.TabStop = true;
            this.rad_Manha.Text = "Manhã";
            this.rad_Manha.UseVisualStyleBackColor = true;
            // 
            // rad_Tarde
            // 
            this.rad_Tarde.AutoSize = true;
            this.rad_Tarde.Location = new System.Drawing.Point(51, 66);
            this.rad_Tarde.Name = "rad_Tarde";
            this.rad_Tarde.Size = new System.Drawing.Size(83, 26);
            this.rad_Tarde.TabIndex = 2;
            this.rad_Tarde.TabStop = true;
            this.rad_Tarde.Text = "Tarde";
            this.rad_Tarde.UseVisualStyleBackColor = true;
            // 
            // rad_Noite
            // 
            this.rad_Noite.AutoSize = true;
            this.rad_Noite.Location = new System.Drawing.Point(51, 98);
            this.rad_Noite.Name = "rad_Noite";
            this.rad_Noite.Size = new System.Drawing.Size(83, 26);
            this.rad_Noite.TabIndex = 3;
            this.rad_Noite.TabStop = true;
            this.rad_Noite.Text = "Noite";
            this.rad_Noite.UseVisualStyleBackColor = true;
            // 
            // lbl_02
            // 
            this.lbl_02.AutoSize = true;
            this.lbl_02.Location = new System.Drawing.Point(48, 159);
            this.lbl_02.Name = "lbl_02";
            this.lbl_02.Size = new System.Drawing.Size(329, 22);
            this.lbl_02.TabIndex = 4;
            this.lbl_02.Text = "Informe o horário de entrada:";
            // 
            // txt_Entra
            // 
            this.txt_Entra.Location = new System.Drawing.Point(51, 184);
            this.txt_Entra.Name = "txt_Entra";
            this.txt_Entra.Size = new System.Drawing.Size(315, 29);
            this.txt_Entra.TabIndex = 5;
            this.txt_Entra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_03
            // 
            this.lbl_03.AutoSize = true;
            this.lbl_03.Location = new System.Drawing.Point(48, 216);
            this.lbl_03.Name = "lbl_03";
            this.lbl_03.Size = new System.Drawing.Size(318, 22);
            this.lbl_03.TabIndex = 6;
            this.lbl_03.Text = "O horário de saída será as :";
            // 
            // txt_Result
            // 
            this.txt_Result.Enabled = false;
            this.txt_Result.Location = new System.Drawing.Point(51, 241);
            this.txt_Result.Name = "txt_Result";
            this.txt_Result.Size = new System.Drawing.Size(314, 29);
            this.txt_Result.TabIndex = 7;
            this.txt_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Result.Visible = false;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Calcular.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calcular.Location = new System.Drawing.Point(127, 276);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(156, 50);
            this.btn_Calcular.TabIndex = 8;
            this.btn_Calcular.Text = "Visualizar Horário";
            this.btn_Calcular.UseVisualStyleBackColor = false;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Limpar.Location = new System.Drawing.Point(160, 344);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(85, 30);
            this.btn_Limpar.TabIndex = 9;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = false;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Voltar.ForeColor = System.Drawing.Color.Blue;
            this.btn_Voltar.Location = new System.Drawing.Point(109, 405);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(194, 29);
            this.btn_Voltar.TabIndex = 10;
            this.btn_Voltar.Text = "Voltar ao Menu";
            this.btn_Voltar.UseVisualStyleBackColor = false;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // rad_Madrugada
            // 
            this.rad_Madrugada.AutoSize = true;
            this.rad_Madrugada.Location = new System.Drawing.Point(51, 130);
            this.rad_Madrugada.Name = "rad_Madrugada";
            this.rad_Madrugada.Size = new System.Drawing.Size(127, 26);
            this.rad_Madrugada.TabIndex = 11;
            this.rad_Madrugada.TabStop = true;
            this.rad_Madrugada.Text = "Madrugada";
            this.rad_Madrugada.UseVisualStyleBackColor = true;
            // 
            // Exercicio6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(437, 461);
            this.Controls.Add(this.rad_Madrugada);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.txt_Result);
            this.Controls.Add(this.lbl_03);
            this.Controls.Add(this.txt_Entra);
            this.Controls.Add(this.lbl_02);
            this.Controls.Add(this.rad_Noite);
            this.Controls.Add(this.rad_Tarde);
            this.Controls.Add(this.rad_Manha);
            this.Controls.Add(this.lbl_01);
            this.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Exercicio6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Horário de Saída";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_01;
        private System.Windows.Forms.RadioButton rad_Manha;
        private System.Windows.Forms.RadioButton rad_Tarde;
        private System.Windows.Forms.RadioButton rad_Noite;
        private System.Windows.Forms.Label lbl_02;
        private System.Windows.Forms.TextBox txt_Entra;
        private System.Windows.Forms.Label lbl_03;
        private System.Windows.Forms.TextBox txt_Result;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.RadioButton rad_Madrugada;
    }
}