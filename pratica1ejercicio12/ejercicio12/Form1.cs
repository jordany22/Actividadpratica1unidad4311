using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCovertir_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double celsius))
            {
                double fahernhit = (celsius * 9 / 5) + 32;


                lblResultado.Text = $"fahrenhit: {fahernhit}";

                
            }
        }
    }

}



