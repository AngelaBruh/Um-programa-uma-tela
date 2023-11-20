
namespace Um_programa_uma_tela
{
    partial class Exercicio10
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
            this.txt_n1 = new System.Windows.Forms.TextBox();
            this.txt_n2 = new System.Windows.Forms.TextBox();
            this.txt_n3 = new System.Windows.Forms.TextBox();
            this.txt_Result = new System.Windows.Forms.TextBox();
            this.btn_Somar = new System.Windows.Forms.Button();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_n1
            // 
            this.txt_n1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_n1.Location = new System.Drawing.Point(297, 55);
            this.txt_n1.Name = "txt_n1";
            this.txt_n1.Size = new System.Drawing.Size(100, 26);
            this.txt_n1.TabIndex = 0;
            // 
            // txt_n2
            // 
            this.txt_n2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_n2.Location = new System.Drawing.Point(297, 102);
            this.txt_n2.Name = "txt_n2";
            this.txt_n2.Size = new System.Drawing.Size(100, 26);
            this.txt_n2.TabIndex = 1;
            // 
            // txt_n3
            // 
            this.txt_n3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_n3.Location = new System.Drawing.Point(297, 147);
            this.txt_n3.Name = "txt_n3";
            this.txt_n3.Size = new System.Drawing.Size(100, 26);
            this.txt_n3.TabIndex = 2;
            // 
            // txt_Result
            // 
            this.txt_Result.Enabled = false;
            this.txt_Result.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Result.Location = new System.Drawing.Point(17, 235);
            this.txt_Result.Multiline = true;
            this.txt_Result.Name = "txt_Result";
            this.txt_Result.Size = new System.Drawing.Size(489, 130);
            this.txt_Result.TabIndex = 3;
            // 
            // btn_Somar
            // 
            this.btn_Somar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Somar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Somar.Location = new System.Drawing.Point(144, 198);
            this.btn_Somar.Name = "btn_Somar";
            this.btn_Somar.Size = new System.Drawing.Size(82, 31);
            this.btn_Somar.TabIndex = 4;
            this.btn_Somar.Text = "Somar";
            this.btn_Somar.UseVisualStyleBackColor = false;
            this.btn_Somar.Click += new System.EventHandler(this.btn_Somar_Click);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Limpar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpar.Location = new System.Drawing.Point(273, 198);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(83, 31);
            this.btn_Limpar.TabIndex = 5;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = false;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(204, 379);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(103, 18);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Voltar ao Menu";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Informe três números:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Digite o primeiro número:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(122, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Digite o segundo número:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(122, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Digite o terceiro número:";
            // 
            // Exercicio10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(521, 413);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.btn_Somar);
            this.Controls.Add(this.txt_Result);
            this.Controls.Add(this.txt_n3);
            this.Controls.Add(this.txt_n2);
            this.Controls.Add(this.txt_n1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Exercicio10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Soma dos números primos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_n1;
        private System.Windows.Forms.TextBox txt_n2;
        private System.Windows.Forms.TextBox txt_n3;
        private System.Windows.Forms.TextBox txt_Result;
        private System.Windows.Forms.Button btn_Somar;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}