using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio16calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //lables
        string operadr = "";
        double num1 = 0;
        double num2 = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            //numeo 0
            pantalla.Text = pantalla.Text + "0";
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            //numero 1
            if (pantalla.Text == "0") pantalla.Text = " ";
            pantalla.Text = pantalla.Text + "1";
        }



        private void Btn2_Click(object sender, EventArgs e)
        {
            //numero 2
            if (pantalla.Text == "0") pantalla.Text = " ";
            pantalla.Text = pantalla.Text + "2";
        
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            //numero 3

            if (pantalla.Text == "0") pantalla.Text = " ";
            pantalla.Text = pantalla.Text + "3";
        }







        private void Btn4_Click(object sender, EventArgs e)
        {
            //numero 4
            if (pantalla.Text == "0") pantalla.Text = " ";
            pantalla.Text = pantalla.Text + "4";
        }




        private void Btn5_Click(object sender, EventArgs e)
        {
            //numero 5

            if (pantalla.Text == "0") pantalla.Text = " ";
            pantalla.Text = pantalla.Text + "5";
        }




        private void Btn6_Click(object sender, EventArgs e)
        {
            //numero6

            if (pantalla.Text == "0") pantalla.Text = " ";
            pantalla.Text = pantalla.Text + "6";



        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            //numero 7
            if (pantalla.Text == "0") pantalla.Text = " ";
            pantalla.Text = pantalla.Text + "7";

        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            //numero 8
            if (pantalla.Text == "0") pantalla.Text = " ";
            pantalla.Text = pantalla.Text + "8";

        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            //numero 9
            if (pantalla.Text == "0") pantalla.Text = " ";
            pantalla.Text = pantalla.Text + "9";

        }

        private void Btnlinpiar_Click(object sender, EventArgs e)
        {
            pantalla.Text = "0";
            num1 = 0;
            num2 = 0;
            operadr = "";
            
        }

        private void Btnpunto_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + ",";
        }

        private void Btnsuma_Click(object sender, EventArgs e)
        {
            operadr = "+";
            num1 = Convert.ToDouble(pantalla.Text);
            pantalla.Text = "0";
        }

        private void Btnresta_Click(object sender, EventArgs e)
        {
            operadr = "-";
            num1 = Convert.ToDouble(pantalla.Text);
            pantalla.Text = "0";
        }

        private void Btnmultipicar_Click(object sender, EventArgs e)
        {
            operadr = "*";
            num1 = Convert.ToDouble(pantalla.Text);
            pantalla.Text = "0";
        }

        private void Btndivicion_Click(object sender, EventArgs e)
        {
            operadr = "/";
            num1 = Convert.ToDouble(pantalla.Text);
            pantalla.Text = "0";
        }

        private void Btnigual_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(pantalla.Text);

            switch (operadr)
            {
                case "+":
                    pantalla.Text = $"{num1 + num2}";
                    break;


                case "-":
                    pantalla.Text = $"{num1 - num2}";
                    break;

                case "*":
                    pantalla.Text = $"{num1 * num2}";
                    break;

                case "/":
                    pantalla.Text = $"{num1 / num2}";
                    break;
            }
        }
    }
}


