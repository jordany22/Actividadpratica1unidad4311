namespace ejercicio8
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
            this.btn_contar = new System.Windows.Forms.Button();
            this.lblResutado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_contar
            // 
            this.btn_contar.Location = new System.Drawing.Point(335, 57);
            this.btn_contar.Name = "btn_contar";
            this.btn_contar.Size = new System.Drawing.Size(175, 34);
            this.btn_contar.TabIndex = 0;
            this.btn_contar.Text = "Precionar";
            this.btn_contar.UseVisualStyleBackColor = true;
            this.btn_contar.Click += new System.EventHandler(this.btn_contar_Click);
            // 
            // lblResutado
            // 
            this.lblResutado.AutoSize = true;
            this.lblResutado.Location = new System.Drawing.Point(261, 116);
            this.lblResutado.Name = "lblResutado";
            this.lblResutado.Size = new System.Drawing.Size(0, 13);
            this.lblResutado.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResutado);
            this.Controls.Add(this.btn_contar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_contar;
        private System.Windows.Forms.Label lblResutado;
    }
}

