using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnmensaje_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola, soy jordany calcaño y mi matriculas es LR-2024-01060");
        }
    }
}
