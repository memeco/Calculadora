using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora Básica");
            Console.WriteLine("------------------");

            Console.Write("Escolha a operação desejada: ");
            string operacao = Console.ReadLine();

            Console.Write("Digite o primeiro número: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            switch (operacao.ToLower())
            {
                case "soma":
                    Console.WriteLine($"Resultado da soma: {numero1 + numero2}");
                    break;
                case "subtracao":
                    Console.WriteLine($"Resultado da subtração: {numero1 - numero2}");
                    break;
                case "multiplicacao":
                    Console.WriteLine($"Resultado da multiplicação: {numero1 * numero2}");
                    break;
                case "divisao":
                    if (numero2 != 0)
                    {
                        Console.WriteLine($"Resultado da divisão: {numero1 / numero2}");
                    }
                    else
                    {
                        Console.WriteLine("Erro: Divisão por zero não é permitida.");
                    }
                    break;
                default:
                    Console.WriteLine("Operação inválida. Por favor, tente novamente.");
                    break;
            }

            Console.ReadKey();
        }
    }
}
