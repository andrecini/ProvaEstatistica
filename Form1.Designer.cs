
namespace Probabilidade_Estatistica
{
    partial class Form1
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
            this.btnEsperanca = new System.Windows.Forms.Button();
            this.btnVariancia = new System.Windows.Forms.Button();
            this.btnDesvioPadrao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEsperanca
            // 
            this.btnEsperanca.Location = new System.Drawing.Point(12, 12);
            this.btnEsperanca.Name = "btnEsperanca";
            this.btnEsperanca.Size = new System.Drawing.Size(151, 34);
            this.btnEsperanca.TabIndex = 0;
            this.btnEsperanca.Text = "Esperança";
            this.btnEsperanca.UseVisualStyleBackColor = true;
            this.btnEsperanca.Click += new System.EventHandler(this.btnEsperanca_Click);
            // 
            // btnVariancia
            // 
            this.btnVariancia.Location = new System.Drawing.Point(12, 52);
            this.btnVariancia.Name = "btnVariancia";
            this.btnVariancia.Size = new System.Drawing.Size(151, 34);
            this.btnVariancia.TabIndex = 1;
            this.btnVariancia.Text = "Variância";
            this.btnVariancia.UseVisualStyleBackColor = true;
            // 
            // btnDesvioPadrao
            // 
            this.btnDesvioPadrao.Location = new System.Drawing.Point(12, 92);
            this.btnDesvioPadrao.Name = "btnDesvioPadrao";
            this.btnDesvioPadrao.Size = new System.Drawing.Size(151, 34);
            this.btnDesvioPadrao.TabIndex = 2;
            this.btnDesvioPadrao.Text = "Desvio Padrão";
            this.btnDesvioPadrao.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(174, 140);
            this.Controls.Add(this.btnDesvioPadrao);
            this.Controls.Add(this.btnVariancia);
            this.Controls.Add(this.btnEsperanca);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEsperanca;
        private System.Windows.Forms.Button btnVariancia;
        private System.Windows.Forms.Button btnDesvioPadrao;
    }
}

