﻿namespace ejercicio10
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
            this.btnmensaje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnmensaje
            // 
            this.btnmensaje.Location = new System.Drawing.Point(292, 100);
            this.btnmensaje.Name = "btnmensaje";
            this.btnmensaje.Size = new System.Drawing.Size(187, 23);
            this.btnmensaje.TabIndex = 0;
            this.btnmensaje.Text = "PRECENTAR MESAJE";
            this.btnmensaje.UseVisualStyleBackColor = true;
            this.btnmensaje.Click += new System.EventHandler(this.btnmensaje_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnmensaje);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnmensaje;
    }
}

