using System;

namespace CalculadoraWeb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora Colaborativa Web");

            Console.Write("Digite o primeiro valor: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Selecione uma das funções a seguir:");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Potenciação");
            Console.WriteLine("6 - Raiz Quadrada (Informe um novo número)");

            Console.Write("Opção: ");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Resultado: " + Adicao(a, b));
                    break;
                case 2:
                    Console.WriteLine("Resultado: " + Subtracao(a, b));
                    break;
                case 3:
                    Console.WriteLine("Resultado: " + Multiplicacao(a, b));
                    break;
                case 4:
                    if (b == 0)
                        Console.WriteLine("Erro: divisão por zero!");
                    else
                        Console.WriteLine("Resultado: " + Divisao(a, b));
                    break;
                case 5:
                    Console.WriteLine("Resultado: " + Potencia(a, b));
                    break;
                case 6:
                    Console.Write("Informe o número para calcular a raiz quadrada: ");
                    string entrada = Console.ReadLine();
                    if (double.TryParse(entrada, out double numeroRaiz))
                    {
                        double resultado = RaizQuadrada(numeroRaiz);
                        if (!double.IsNaN(resultado))
                        {
                            Console.WriteLine($"A raiz quadrada de {numeroRaiz} é {resultado}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Erro: entrada inválida. Digite um número válido.");
                    }
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }

        public static double Adicao(double a, double b) => a + b;
        public static double Subtracao(double a, double b) => a - b;
        public static double Multiplicacao(double a, double b) => a * b;
        public static double Divisao(double a, double b) => a / b;
        public static double Potencia(double a, double b) => Math.Pow(a, b);

        public static double RaizQuadrada(double numero)
        {
            if (numero >= 0)
            {
                return Math.Sqrt(numero);
            }
            else
            {
                Console.WriteLine("Erro: número negativo não possui raiz quadrada real.");
                return double.NaN;
            }
        }
    }
}
