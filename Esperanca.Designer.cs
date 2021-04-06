
namespace Probabilidade_Estatistica
{
    partial class Esperanca
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtProb1 = new System.Windows.Forms.MaskedTextBox();
            this.txtProb2 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQtdd = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOp1 = new System.Windows.Forms.MaskedTextBox();
            this.txtOp2 = new System.Windows.Forms.MaskedTextBox();
            this.txtOp3 = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGasto = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOp4 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Probabilidade:";
            // 
            // txtProb1
            // 
            this.txtProb1.Location = new System.Drawing.Point(92, 18);
            this.txtProb1.Name = "txtProb1";
            this.txtProb1.Size = new System.Drawing.Size(24, 20);
            this.txtProb1.TabIndex = 2;
            this.txtProb1.Text = "1";
            this.txtProb1.ValidatingType = typeof(int);
            // 
            // txtProb2
            // 
            this.txtProb2.Location = new System.Drawing.Point(140, 18);
            this.txtProb2.Name = "txtProb2";
            this.txtProb2.Size = new System.Drawing.Size(24, 20);
            this.txtProb2.TabIndex = 3;
            this.txtProb2.Text = "6";
            this.txtProb2.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "/";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantidade:";
            // 
            // txtQtdd
            // 
            this.txtQtdd.Location = new System.Drawing.Point(83, 58);
            this.txtQtdd.Name = "txtQtdd";
            this.txtQtdd.Size = new System.Drawing.Size(24, 20);
            this.txtQtdd.TabIndex = 6;
            this.txtQtdd.Text = "3";
            this.txtQtdd.ValidatingType = typeof(int);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Opção (1A):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Opção (2A):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Opção (3A):";
            // 
            // txtOp1
            // 
            this.txtOp1.Location = new System.Drawing.Point(96, 130);
            this.txtOp1.Name = "txtOp1";
            this.txtOp1.Size = new System.Drawing.Size(52, 20);
            this.txtOp1.TabIndex = 11;
            this.txtOp1.Text = "20";
            this.txtOp1.ValidatingType = typeof(int);
            // 
            // txtOp2
            // 
            this.txtOp2.Location = new System.Drawing.Point(96, 158);
            this.txtOp2.Name = "txtOp2";
            this.txtOp2.Size = new System.Drawing.Size(52, 20);
            this.txtOp2.TabIndex = 12;
            this.txtOp2.Text = "50";
            this.txtOp2.ValidatingType = typeof(int);
            // 
            // txtOp3
            // 
            this.txtOp3.Location = new System.Drawing.Point(96, 187);
            this.txtOp3.Name = "txtOp3";
            this.txtOp3.Size = new System.Drawing.Size(52, 20);
            this.txtOp3.TabIndex = 13;
            this.txtOp3.Text = "80";
            this.txtOp3.ValidatingType = typeof(int);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Gasto:";
            // 
            // txtGasto
            // 
            this.txtGasto.Location = new System.Drawing.Point(83, 96);
            this.txtGasto.Name = "txtGasto";
            this.txtGasto.Size = new System.Drawing.Size(52, 20);
            this.txtGasto.TabIndex = 16;
            this.txtGasto.Text = "20";
            this.txtGasto.ValidatingType = typeof(int);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Opção (0A):";
            // 
            // txtOp4
            // 
            this.txtOp4.Location = new System.Drawing.Point(96, 214);
            this.txtOp4.Name = "txtOp4";
            this.txtOp4.Size = new System.Drawing.Size(52, 20);
            this.txtOp4.TabIndex = 18;
            this.txtOp4.Text = "0";
            this.txtOp4.ValidatingType = typeof(int);
            // 
            // Esperanca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(183, 289);
            this.Controls.Add(this.txtOp4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtGasto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtOp3);
            this.Controls.Add(this.txtOp2);
            this.Controls.Add(this.txtOp1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtQtdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProb2);
            this.Controls.Add(this.txtProb1);
            this.Controls.Add(this.label1);
            this.Name = "Esperanca";
            this.Text = "Esperança";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtProb1;
        private System.Windows.Forms.MaskedTextBox txtProb2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtQtdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtOp1;
        private System.Windows.Forms.MaskedTextBox txtOp2;
        private System.Windows.Forms.MaskedTextBox txtOp3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtGasto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtOp4;
    }
}