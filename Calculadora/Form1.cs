using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        char operacao;
        double numDigitado1, numDigitado2, resultado;

        public Form1()
        {
            InitializeComponent();
        }

        public void txbPanel_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            txbPanel.Text += 0.ToString();
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            txbPanel.Text += 1.ToString();
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            txbPanel.Text += 2.ToString();
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            txbPanel.Text += 3.ToString();
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            txbPanel.Text += 4.ToString();
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            txbPanel.Text += 5.ToString();
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            txbPanel.Text += 6.ToString();
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            txbPanel.Text += 7.ToString();
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            txbPanel.Text += 8.ToString();
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            txbPanel.Text += 9.ToString();
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            txbPanel.Text += ",";
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            numDigitado1 = double.Parse(txbPanel.Text);
            operacao = '-';
            txbPanel.Text += "-";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            numDigitado1 = double.Parse(txbPanel.Text);
            operacao = '*';
            txbPanel.Text += "*";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            numDigitado1 = double.Parse(txbPanel.Text);
            operacao = '/';
            txbPanel.Text += "/";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            numDigitado1 = double.Parse(txbPanel.Text);
            operacao = '+';
            txbPanel.Text += "+";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            numDigitado2 = double.Parse(txbPanel.Text.Split(operacao)[1]);
            Calculate calculo = new Calculate(numDigitado1, numDigitado2);

            switch (operacao)
            {
                case '+':
                    resultado = calculo.Soma();
                    break;
                case '-':
                    resultado = calculo.Subtracao();
                    break;
                case '*':
                    resultado = calculo.Multiplicacao();
                    break;
                case '/':
                    resultado = calculo.Divisao();
                    break;
            }

            txbPanel.Text = resultado.ToString();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            numDigitado1 = 0;
            numDigitado2 = 0;
            operacao = '0';
        }
    }
}
