﻿namespace JogoDesktop
{
    partial class Pergunta2
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
            this.btnProxima = new System.Windows.Forms.Button();
            this.rdbResposta4 = new System.Windows.Forms.RadioButton();
            this.rdbResposta3 = new System.Windows.Forms.RadioButton();
            this.rdbResposta2 = new System.Windows.Forms.RadioButton();
            this.rdbResposta1 = new System.Windows.Forms.RadioButton();
            this.lblPergunta2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnProxima
            // 
            this.btnProxima.Location = new System.Drawing.Point(242, 296);
            this.btnProxima.Name = "btnProxima";
            this.btnProxima.Size = new System.Drawing.Size(143, 45);
            this.btnProxima.TabIndex = 11;
            this.btnProxima.Text = "Próxima pergunta";
            this.btnProxima.UseVisualStyleBackColor = true;
            this.btnProxima.Click += new System.EventHandler(this.btnProxima_Click);
            // 
            // rdbResposta4
            // 
            this.rdbResposta4.AutoSize = true;
            this.rdbResposta4.Location = new System.Drawing.Point(66, 219);
            this.rdbResposta4.Name = "rdbResposta4";
            this.rdbResposta4.Size = new System.Drawing.Size(37, 17);
            this.rdbResposta4.TabIndex = 10;
            this.rdbResposta4.TabStop = true;
            this.rdbResposta4.Text = "12";
            this.rdbResposta4.UseVisualStyleBackColor = true;
            // 
            // rdbResposta3
            // 
            this.rdbResposta3.AutoSize = true;
            this.rdbResposta3.Location = new System.Drawing.Point(66, 183);
            this.rdbResposta3.Name = "rdbResposta3";
            this.rdbResposta3.Size = new System.Drawing.Size(31, 17);
            this.rdbResposta3.TabIndex = 9;
            this.rdbResposta3.TabStop = true;
            this.rdbResposta3.Text = "8";
            this.rdbResposta3.UseVisualStyleBackColor = true;
            // 
            // rdbResposta2
            // 
            this.rdbResposta2.AutoSize = true;
            this.rdbResposta2.Location = new System.Drawing.Point(66, 149);
            this.rdbResposta2.Name = "rdbResposta2";
            this.rdbResposta2.Size = new System.Drawing.Size(31, 17);
            this.rdbResposta2.TabIndex = 8;
            this.rdbResposta2.TabStop = true;
            this.rdbResposta2.Text = "6";
            this.rdbResposta2.UseVisualStyleBackColor = true;
            // 
            // rdbResposta1
            // 
            this.rdbResposta1.AutoSize = true;
            this.rdbResposta1.Location = new System.Drawing.Point(66, 115);
            this.rdbResposta1.Name = "rdbResposta1";
            this.rdbResposta1.Size = new System.Drawing.Size(31, 17);
            this.rdbResposta1.TabIndex = 7;
            this.rdbResposta1.TabStop = true;
            this.rdbResposta1.Text = "2";
            this.rdbResposta1.UseVisualStyleBackColor = true;
            // 
            // lblPergunta2
            // 
            this.lblPergunta2.AutoSize = true;
            this.lblPergunta2.Location = new System.Drawing.Point(63, 46);
            this.lblPergunta2.Name = "lblPergunta2";
            this.lblPergunta2.Size = new System.Drawing.Size(122, 13);
            this.lblPergunta2.TabIndex = 6;
            this.lblPergunta2.Text = "2) Quanto é meia duzia?";
            // 
            // Pergunta2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 386);
            this.Controls.Add(this.btnProxima);
            this.Controls.Add(this.rdbResposta4);
            this.Controls.Add(this.rdbResposta3);
            this.Controls.Add(this.rdbResposta2);
            this.Controls.Add(this.rdbResposta1);
            this.Controls.Add(this.lblPergunta2);
            this.Name = "Pergunta2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pergunta2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProxima;
        private System.Windows.Forms.RadioButton rdbResposta4;
        private System.Windows.Forms.RadioButton rdbResposta3;
        private System.Windows.Forms.RadioButton rdbResposta2;
        private System.Windows.Forms.RadioButton rdbResposta1;
        private System.Windows.Forms.Label lblPergunta2;
    }
}