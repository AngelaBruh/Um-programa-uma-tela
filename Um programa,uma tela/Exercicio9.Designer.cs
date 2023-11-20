
namespace Um_programa_uma_tela
{
    partial class Exercicio9
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
            this.txt_Digite = new System.Windows.Forms.TextBox();
            this.txt_Result = new System.Windows.Forms.TextBox();
            this.btn_Somar = new System.Windows.Forms.Button();
            this.lbl_01 = new System.Windows.Forms.Label();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.lbl_02 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Digite
            // 
            this.txt_Digite.Location = new System.Drawing.Point(35, 43);
            this.txt_Digite.Name = "txt_Digite";
            this.txt_Digite.Size = new System.Drawing.Size(180, 29);
            this.txt_Digite.TabIndex = 0;
            this.txt_Digite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Digite.MouseLeave += new System.EventHandler(this.txt_Digite_MouseLeave);
            this.txt_Digite.MouseHover += new System.EventHandler(this.txt_Digite_MouseHover);
            // 
            // txt_Result
            // 
            this.txt_Result.Enabled = false;
            this.txt_Result.Location = new System.Drawing.Point(35, 133);
            this.txt_Result.Name = "txt_Result";
            this.txt_Result.Size = new System.Drawing.Size(180, 29);
            this.txt_Result.TabIndex = 1;
            // 
            // btn_Somar
            // 
            this.btn_Somar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Somar.Location = new System.Drawing.Point(52, 78);
            this.btn_Somar.Name = "btn_Somar";
            this.btn_Somar.Size = new System.Drawing.Size(147, 32);
            this.btn_Somar.TabIndex = 2;
            this.btn_Somar.Text = "Somar";
            this.btn_Somar.UseVisualStyleBackColor = false;
            this.btn_Somar.Click += new System.EventHandler(this.btn_Somar_Click);
            this.btn_Somar.MouseLeave += new System.EventHandler(this.btn_Somar_MouseLeave);
            this.btn_Somar.MouseHover += new System.EventHandler(this.btn_Somar_MouseHover);
            // 
            // lbl_01
            // 
            this.lbl_01.AutoSize = true;
            this.lbl_01.Location = new System.Drawing.Point(31, 18);
            this.lbl_01.Name = "lbl_01";
            this.lbl_01.Size = new System.Drawing.Size(197, 22);
            this.lbl_01.TabIndex = 3;
            this.lbl_01.Text = "Digite um número:";
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Limpar.Location = new System.Drawing.Point(72, 168);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(102, 30);
            this.btn_Limpar.TabIndex = 4;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = false;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
          
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Voltar.ForeColor = System.Drawing.Color.Blue;
            this.btn_Voltar.Location = new System.Drawing.Point(33, 367);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(193, 28);
            this.btn_Voltar.TabIndex = 5;
            this.btn_Voltar.Text = "Voltar ao Menu";
            this.btn_Voltar.UseVisualStyleBackColor = false;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            this.btn_Voltar.MouseLeave += new System.EventHandler(this.btn_Voltar_MouseLeave);
            this.btn_Voltar.MouseHover += new System.EventHandler(this.btn_Voltar_MouseHover);
            // 
            // lbl_02
            // 
            this.lbl_02.Location = new System.Drawing.Point(12, 208);
            this.lbl_02.Name = "lbl_02";
            this.lbl_02.Size = new System.Drawing.Size(261, 143);
            this.lbl_02.TabIndex = 6;
            this.lbl_02.Text = "Este programa irá retornar a soma de todos os primeiros números inteiros até o nú" +
    "mero informado.      Ex: 3 : 1 + 2 + 3 = 6";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 410);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(267, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.LinkColor = System.Drawing.Color.Lime;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            this.toolStripStatusLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // Exercicio9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(267, 432);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lbl_02);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.lbl_01);
            this.Controls.Add(this.btn_Somar);
            this.Controls.Add(this.txt_Result);
            this.Controls.Add(this.txt_Digite);
            this.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Exercicio9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Soma dos primeiros números inteiros";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Digite;
        private System.Windows.Forms.TextBox txt_Result;
        private System.Windows.Forms.Button btn_Somar;
        private System.Windows.Forms.Label lbl_01;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.Label lbl_02;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}