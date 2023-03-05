using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Linq.Expressions;
using System.Net.WebSockets;

namespace CalculadoraCsharp
{
    public partial class Calculadora : Form
    {
        decimal result = 0;
        decimal result2 = 0;
        String operacao = "";
        public Calculadora()
        {
            InitializeComponent();
        }

        private void b0_Click(object sender, EventArgs e)
        {
            txtCal.Text = txtCal.Text + "0";
        }

        private void b1_Click(object sender, EventArgs e)
        {
            txtCal.Text = txtCal.Text + "1";
        }

        private void b2_Click(object sender, EventArgs e)
        {
            txtCal.Text = txtCal.Text + "2";
        }

        private void b3_Click(object sender, EventArgs e)
        {
            txtCal.Text = txtCal.Text + "3";
        }

        private void b4_Click(object sender, EventArgs e)
        {
            txtCal.Text = txtCal.Text + "4";
        }

        private void b5_Click(object sender, EventArgs e)
        {
            txtCal.Text = txtCal.Text + "5";
        }

        private void b6_Click(object sender, EventArgs e)
        {
            txtCal.Text = txtCal.Text + "6";
        }

        private void b7_Click(object sender, EventArgs e)
        {
            txtCal.Text = txtCal.Text + "7";
        }

        private void b8_Click(object sender, EventArgs e)
        {
            txtCal.Text = txtCal.Text + "8";
        }

        private void b9_Click(object sender, EventArgs e)
        {
            txtCal.Text = txtCal.Text + "9";
        }

        private void bLimpa_Click(object sender, EventArgs e)
        {
            txtCal.Text = "";
            result = 0;
            result2 = 0;
            op1.Text = "";
            op2.Text = "";  
        }

        private void bPonto_Click(object sender, EventArgs e)
        {
            txtCal.Text = txtCal.Text + ".";
        }

        private void bMulti_Click(object sender, EventArgs e)
        {
            result = decimal.Parse(txtCal.Text, CultureInfo.InvariantCulture);
            txtCal.Text = "";
            String valor = Convert.ToString(result);
            operacao = "*";
            op2.Text = $"{valor} " + "*";
            op1.Text = "*";
        }

        private void bDiv_Click(object sender, EventArgs e)
        {
            result = decimal.Parse(txtCal.Text, CultureInfo.InvariantCulture);
            txtCal.Text = "";
            String valor = Convert.ToString(result);
            operacao = "/";
            op2.Text = $"{valor} " + "/";
            op1.Text = "/";
        }

        private void bMenos_Click(object sender, EventArgs e)
        {
            result = decimal.Parse(txtCal.Text, CultureInfo.InvariantCulture);
            txtCal.Text = "";
            String valor = Convert.ToString(result);
            operacao = "-";
            op2.Text = $"{valor} " + "-";
            op1.Text = "-";
        }

        private void bMais_Click(object sender, EventArgs e)
        {
            result = decimal.Parse(txtCal.Text, CultureInfo.InvariantCulture);
            txtCal.Text = "";
            String valor = Convert.ToString(result);
            operacao = "+";
            op2.Text = $"{valor} " + "+";
            op1.Text = "+";
        }

        private void bResul_Click(object sender, EventArgs e)
        {
            result2 = decimal.Parse(txtCal.Text, CultureInfo.InvariantCulture);

            switch (operacao)
            {
                case "+":
                    txtCal.Text = Convert.ToString(result + result2);
                    break;
                case "-":
                    txtCal.Text = Convert.ToString(result - result2);
                    break;
                case "*":
                    txtCal.Text = Convert.ToString(result * result2);
                    break;
                case "/":
                    txtCal.Text = Convert.ToString(result / result2);
                    break;
            }
        }
    }
}
