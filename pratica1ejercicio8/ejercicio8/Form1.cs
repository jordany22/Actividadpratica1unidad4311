﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio8
{
    public partial class Form1 : Form
        
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btn_contar_Click(object sender, EventArgs e)

        {
            int contador = 0;
            contador++;

            lblResutado.Text = "contador: " +
                contador.ToString();
        }
    }
}
