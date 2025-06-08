namespace ejercicio3
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
            this.txtEntrda = new System.Windows.Forms.TextBox();
            this.btnMostrarTexto = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEntrda
            // 
            this.txtEntrda.Location = new System.Drawing.Point(386, 53);
            this.txtEntrda.Name = "txtEntrda";
            this.txtEntrda.Size = new System.Drawing.Size(100, 20);
            this.txtEntrda.TabIndex = 1;
            this.txtEntrda.Text = "HOLA ESTUDIANTES";
            // 
            // btnMostrarTexto
            // 
            this.btnMostrarTexto.Location = new System.Drawing.Point(591, 160);
            this.btnMostrarTexto.Name = "btnMostrarTexto";
            this.btnMostrarTexto.Size = new System.Drawing.Size(75, 23);
            this.btnMostrarTexto.TabIndex = 2;
            this.btnMostrarTexto.Text = "Mostra texto";
            this.btnMostrarTexto.UseVisualStyleBackColor = true;
            this.btnMostrarTexto.Click += new System.EventHandler(this.btnMostrarTexto_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(357, 187);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnMostrarTexto);
            this.Controls.Add(this.txtEntrda);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEntrda;
        private System.Windows.Forms.Button btnMostrarTexto;
        private System.Windows.Forms.Label lblResultado;
    }
}

