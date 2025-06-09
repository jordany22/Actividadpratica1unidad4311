using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAcertar_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                lblMostrarOpcion.Text = "selecionaste: Opcion 1";
            else if (radioButton2.Checked)
                lblMostrarOpcion.Text = "selecionaste: Opcion 2";
            else if (radioButton3.Checked)
                lblMostrarOpcion.Text = "selecionaste: Opcion 3";
            else
                lblMostrarOpcion.Text = "No selecionaste niguna Opcion";
                

        }
    }
}
