using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        double num1 = 0, num2 = 0;
        char operador;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void operacion(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            num1 = Convert.ToDouble(resultado.Text);
            operador = Convert.ToChar(boton.Text);

            resultado.Text = "0";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(resultado.Text);

            if (operador == '+')
            {
                resultado.Text = (num1 + num2).ToString();
                num1 = Convert.ToDouble(resultado.Text);
            }
            else if (operador == '-')
            {
                resultado.Text = (num1 - num2).ToString();
                num1 = Convert.ToDouble(resultado.Text);
            }
            else if (operador == '*')
            {
                resultado.Text = (num1 * num2).ToString();
                num1 = Convert.ToDouble(resultado.Text);
            }
            else if (operador == '/')
            {
                if (resultado.Text != "0")
                {
                    resultado.Text = (num1 / num2).ToString();
                    num1 = Convert.ToDouble(resultado.Text);
                }
                else
                {
                    MessageBox.Show("ERROR Calculo");
                }
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            resultado.Text = "0";
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            operador = '\0';
            resultado.Text = "0";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (!resultado.Text.Contains("."))
            {
                resultado.Text += ".";
            }
        }

        private void agregar(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            if (resultado.Text == "0")
                resultado.Text = "";

            resultado.Text += boton.Text;
        }
    }
}
