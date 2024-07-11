// Program.cs
using System;

namespace CalculadoraBasica
{
    public class CalculadoraOperations
    {
        public double Soma(double numero1, double numero2)
        {
            return numero1 + numero2;
        }

        public double Subtracao(double numero1, double numero2)
        {
            return numero1 - numero2;
        }

        public double Multiplicacao(double numero1, double numero2)
        {
            return numero1 * numero2;
        }

        public double Divisao(double numero1, double numero2)
        {
            if (numero2 != 0)
            {
                return numero1 / numero2;
            }
            else
            {
                throw new DivideByZeroException("Divisão por zero não é permitida.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Rest of the code...
        }
    }
}
