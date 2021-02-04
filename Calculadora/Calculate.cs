using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Calculate
    {
        private double valor1, valor2, resultado;

        public Calculate(double valor1Num, double valor2Num)
        {
            valor1 = valor1Num;
            valor2 = valor2Num;
        }
        public double Soma()
        {
            resultado = valor1 + valor2;
            return resultado;
        }

        public double Subtracao()
        {
            resultado = valor1 - valor2;
            return resultado;
        }

        public double Multiplicacao()
        {
            resultado = valor1 * valor2;
            return resultado;
        }

        public double Divisao()
        {
            resultado = valor1 / valor2;
            return resultado;
        }
    }
}
