﻿namespace JogoDesktop
{
    partial class Pergunta1
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
            this.lblPergunta = new System.Windows.Forms.Label();
            this.rdbResposta1 = new System.Windows.Forms.RadioButton();
            this.rdbResposta2 = new System.Windows.Forms.RadioButton();
            this.rdbResposta3 = new System.Windows.Forms.RadioButton();
            this.rdbResposta4 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPergunta
            // 
            this.lblPergunta.AutoSize = true;
            this.lblPergunta.Location = new System.Drawing.Point(77, 55);
            this.lblPergunta.Name = "lblPergunta";
            this.lblPergunta.Size = new System.Drawing.Size(219, 13);
            this.lblPergunta.TabIndex = 0;
            this.lblPergunta.Text = "Qual é a cor do cavalo branco de napoleão?";
            this.lblPergunta.Click += new System.EventHandler(this.label1_Click);
            // 
            // rdbResposta1
            // 
            this.rdbResposta1.AutoSize = true;
            this.rdbResposta1.Location = new System.Drawing.Point(80, 124);
            this.rdbResposta1.Name = "rdbResposta1";
            this.rdbResposta1.Size = new System.Drawing.Size(86, 17);
            this.rdbResposta1.TabIndex = 1;
            this.rdbResposta1.TabStop = true;
            this.rdbResposta1.Text = "Azul Marinho";
            this.rdbResposta1.UseVisualStyleBackColor = true;
            // 
            // rdbResposta2
            // 
            this.rdbResposta2.AutoSize = true;
            this.rdbResposta2.Location = new System.Drawing.Point(80, 158);
            this.rdbResposta2.Name = "rdbResposta2";
            this.rdbResposta2.Size = new System.Drawing.Size(90, 17);
            this.rdbResposta2.TabIndex = 2;
            this.rdbResposta2.TabStop = true;
            this.rdbResposta2.Text = "Rosa Choque";
            this.rdbResposta2.UseVisualStyleBackColor = true;
            // 
            // rdbResposta3
            // 
            this.rdbResposta3.AutoSize = true;
            this.rdbResposta3.Location = new System.Drawing.Point(80, 192);
            this.rdbResposta3.Name = "rdbResposta3";
            this.rdbResposta3.Size = new System.Drawing.Size(59, 17);
            this.rdbResposta3.TabIndex = 3;
            this.rdbResposta3.TabStop = true;
            this.rdbResposta3.Text = "Branco";
            this.rdbResposta3.UseVisualStyleBackColor = true;
            this.rdbResposta3.CheckedChanged += new System.EventHandler(this.rdbResposta3_CheckedChanged);
            // 
            // rdbResposta4
            // 
            this.rdbResposta4.AutoSize = true;
            this.rdbResposta4.Location = new System.Drawing.Point(80, 228);
            this.rdbResposta4.Name = "rdbResposta4";
            this.rdbResposta4.Size = new System.Drawing.Size(62, 17);
            this.rdbResposta4.TabIndex = 4;
            this.rdbResposta4.TabStop = true;
            this.rdbResposta4.Text = "Azul BB";
            this.rdbResposta4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 45);
            this.button1.TabIndex = 5;
            this.button1.Text = "Próxima pergunta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pergunta1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 362);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rdbResposta4);
            this.Controls.Add(this.rdbResposta3);
            this.Controls.Add(this.rdbResposta2);
            this.Controls.Add(this.rdbResposta1);
            this.Controls.Add(this.lblPergunta);
            this.Name = "Pergunta1";
            this.Text = "Pergunta1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPergunta;
        private System.Windows.Forms.RadioButton rdbResposta1;
        private System.Windows.Forms.RadioButton rdbResposta2;
        private System.Windows.Forms.RadioButton rdbResposta3;
        private System.Windows.Forms.RadioButton rdbResposta4;
        private System.Windows.Forms.Button button1;
    }
}