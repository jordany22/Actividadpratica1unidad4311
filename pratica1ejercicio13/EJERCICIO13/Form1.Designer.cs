﻿namespace EJERCICIO13
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.BtnInicial = new System.Windows.Forms.Button();
            this.BtnDetener = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(387, 80);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // BtnInicial
            // 
            this.BtnInicial.Location = new System.Drawing.Point(630, 237);
            this.BtnInicial.Name = "BtnInicial";
            this.BtnInicial.Size = new System.Drawing.Size(75, 23);
            this.BtnInicial.TabIndex = 1;
            this.BtnInicial.Text = "inicial";
            this.BtnInicial.UseVisualStyleBackColor = true;
            this.BtnInicial.Click += new System.EventHandler(this.BtnInicial_Click);
            // 
            // BtnDetener
            // 
            this.BtnDetener.Location = new System.Drawing.Point(323, 228);
            this.BtnDetener.Name = "BtnDetener";
            this.BtnDetener.Size = new System.Drawing.Size(75, 23);
            this.BtnDetener.TabIndex = 2;
            this.BtnDetener.Text = "Detener";
            this.BtnDetener.UseVisualStyleBackColor = true;
            this.BtnDetener.Click += new System.EventHandler(this.BtnDetener_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnDetener);
            this.Controls.Add(this.BtnInicial);
            this.Controls.Add(this.progressBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button BtnInicial;
        private System.Windows.Forms.Button BtnDetener;
        private System.Windows.Forms.Timer timer1;
    }
}

