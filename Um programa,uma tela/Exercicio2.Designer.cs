
namespace Um_programa_uma_tela
{
    partial class Exercicio2
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
            this.txt_digite = new System.Windows.Forms.TextBox();
            this.btn_Converter = new System.Windows.Forms.Button();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.txt_Result = new System.Windows.Forms.TextBox();
            this.prg_Convertendo = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lbl_01
            // 
            this.lbl_01.AutoSize = true;
            this.lbl_01.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_01.Location = new System.Drawing.Point(52, 27);
            this.lbl_01.Name = "lbl_01";
            this.lbl_01.Size = new System.Drawing.Size(318, 22);
            this.lbl_01.TabIndex = 0;
            this.lbl_01.Text = "Digite um número de 0 à 999:";
            // 
            // txt_digite
            // 
            this.txt_digite.Location = new System.Drawing.Point(77, 62);
            this.txt_digite.Name = "txt_digite";
            this.txt_digite.Size = new System.Drawing.Size(274, 26);
            this.txt_digite.TabIndex = 1;
            this.txt_digite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Converter
            // 
            this.btn_Converter.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Converter.Location = new System.Drawing.Point(77, 94);
            this.btn_Converter.Name = "btn_Converter";
            this.btn_Converter.Size = new System.Drawing.Size(274, 27);
            this.btn_Converter.TabIndex = 2;
            this.btn_Converter.Text = "Converter";
            this.btn_Converter.UseVisualStyleBackColor = false;
            this.btn_Converter.Click += new System.EventHandler(this.btn_Converter_Click);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Limpar.Location = new System.Drawing.Point(166, 274);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(95, 28);
            this.btn_Limpar.TabIndex = 3;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = false;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Voltar.ForeColor = System.Drawing.Color.Blue;
            this.btn_Voltar.Location = new System.Drawing.Point(123, 308);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(190, 25);
            this.btn_Voltar.TabIndex = 4;
            this.btn_Voltar.Text = "Voltar ao Menu";
            this.btn_Voltar.UseVisualStyleBackColor = false;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // txt_Result
            // 
            this.txt_Result.Enabled = false;
            this.txt_Result.Location = new System.Drawing.Point(50, 151);
            this.txt_Result.Name = "txt_Result";
            this.txt_Result.Size = new System.Drawing.Size(320, 26);
            this.txt_Result.TabIndex = 5;
            this.txt_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Result.Visible = false;
            // 
            // prg_Convertendo
            // 
            this.prg_Convertendo.BackColor = System.Drawing.Color.White;
            this.prg_Convertendo.Enabled = false;
            this.prg_Convertendo.ForeColor = System.Drawing.Color.Black;
            this.prg_Convertendo.Location = new System.Drawing.Point(50, 221);
            this.prg_Convertendo.Name = "prg_Convertendo";
            this.prg_Convertendo.Size = new System.Drawing.Size(320, 24);
            this.prg_Convertendo.Step = 50;
            this.prg_Convertendo.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prg_Convertendo.TabIndex = 6;
            this.prg_Convertendo.Visible = false;
            // 
            // Exercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(436, 337);
            this.Controls.Add(this.prg_Convertendo);
            this.Controls.Add(this.txt_Result);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.btn_Converter);
            this.Controls.Add(this.txt_digite);
            this.Controls.Add(this.lbl_01);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Exercicio2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escrito por extenso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_01;
        private System.Windows.Forms.TextBox txt_digite;
        private System.Windows.Forms.Button btn_Converter;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.TextBox txt_Result;
        private System.Windows.Forms.ProgressBar prg_Convertendo;
    }
}