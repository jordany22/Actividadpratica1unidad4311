﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if
                (comboBox1.SelectedItem.ToString() ==
                "ROJO")
                this.BackColor = Color.Red;
            else if
                (comboBox1.SelectedItem.ToString() ==
                "verde")
                this.BackColor = Color.Green;
            else if
                (comboBox1.SelectedItem.ToString() == 
                "Azul")
                this.BackColor = Color.Blue;
        }
    }
}
