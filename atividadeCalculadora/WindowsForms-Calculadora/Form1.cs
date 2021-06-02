using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Calculadora
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "9";
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += ".";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txt_resultado.Text, CultureInfo.InvariantCulture);

            if(operacao == "SOMA")
            {
                txt_resultado.Text = Convert.ToString(valor1 + valor2);
            } else if(operacao == "SUB")
            {
                txt_resultado.Text = Convert.ToString(valor1 - valor2);
            } else if (operacao == "MULT")
            {
                txt_resultado.Text = Convert.ToString(valor1 * valor2);
            } else
            {
                txt_resultado.Text = Convert.ToString(valor1 / valor2);
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (txt_resultado.Text != "")
            { 
                valor1 = decimal.Parse(txt_resultado.Text, CultureInfo.InvariantCulture);
                txt_resultado.Text = "";
                operacao = "SUB";
                lbl_operacao.Text = "-";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar o calculo");
            }
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            if (txt_resultado.Text != "")
            { 
                valor1 = decimal.Parse(txt_resultado.Text, CultureInfo.InvariantCulture);
                txt_resultado.Text = "";
                operacao = "MULT";
                lbl_operacao.Text = "*";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar o calculo");
            }
        }

        private void btnSom_Click(object sender, EventArgs e)
        {
            if (txt_resultado.Text != "")
            { 
                valor1 = decimal.Parse(txt_resultado.Text, CultureInfo.InvariantCulture);
                txt_resultado.Text = "";
                operacao = "SOMA";
                lbl_operacao.Text = "+";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar o calculo");
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txt_resultado.Text = "";
            lbl_operacao.Text = "";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txt_resultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            lbl_operacao.Text = "";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if(txt_resultado.Text != "")
            { 
                valor1 = decimal.Parse(txt_resultado.Text, CultureInfo.InvariantCulture);
                txt_resultado.Text = "";
                operacao = "DIV";
                lbl_operacao.Text = "/";
            } 
            else
            {
                MessageBox.Show("Informe um valor para efetuar o calculo");
            }
        }
    }

}
