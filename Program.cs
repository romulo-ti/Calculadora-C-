using System;
using System.Collections.Generic;
class Program
{
    static List<string> historico = new List<string>();
    public static void Main(string[] args)
    {
        Console.WriteLine("Calculadora Colaborativa Web");
        int opcao;
        do
        {
            double a = 0;
            double b = 0;

            Console.WriteLine("Selecione uma das funções a seguir:");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Potenciação");
            Console.WriteLine("6 - Raiz Quadrada (Informe um novo número)");
            Console.WriteLine("7 - Histórico");
            Console.WriteLine("8 - Limpar console");
            Console.WriteLine("9 - Sair");
            Console.Write("Opção: ");
            opcao = int.Parse(Console.ReadLine());
            if (opcao >= 1 && opcao <= 6)
            {
                Console.Write("Digite o primeiro valor: ");
                a = double.Parse(Console.ReadLine());

                Console.Write("Digite o segundo valor: ");
                b = double.Parse(Console.ReadLine());
            }
            switch (opcao)
            {

                case 1:

                    Console.WriteLine("Resultado: " + Adicao(a, b));
                    string adicao = $"{a} + {b} = {Adicao(a, b)}";
                    historico.Add(adicao);
                    break;
                case 2:
                    Console.WriteLine("Resultado: " + Subtracao(a, b));
                    string subtracao = $"{a} - {b} = {Subtracao(a, b)}";
                    historico.Add(subtracao);
                    break;
                case 3:
                    Console.WriteLine("Resultado: " + Multiplicacao(a, b));
                    string multiplicacao = $"{a} * {b} = {Multiplicacao(a, b)}";
                    historico.Add(multiplicacao);
                    break;
                case 4:
                    if (b == 0)
                        Console.WriteLine("Erro: divisão por zero!");
                    else
                        Console.WriteLine("Resultado: " + Divisao(a, b));
                    string divisao = $"{a} / {b} = {Divisao(a, b)}";
                    historico.Add(divisao);
                    break;
                case 5:
                    Console.WriteLine("Resultado: " + Potencia(a, b));
                    string potencia = $"{a} ^ {b} = {Potencia(a, b)}";
                    historico.Add(potencia);
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
                    string raiz = $"Raiz quadrada de {numeroRaiz} = {RaizQuadrada(numeroRaiz)}";
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
                case 7:
                    Console.WriteLine("HISTORICO");
                    Console.WriteLine("Histórico de Cálculos");
                    if (historico.Count == 0)
                    {
                        Console.WriteLine("Nenhum cálculo realizado ainda.");
                    }
                    else
                    {
                        foreach (var item in historico)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    break;
                case 8:
                    Console.Write("Aperte c para excluir a última operação: ");
                    var tecla = Console.ReadKey(true);
                    if (tecla.KeyChar == 'c' || tecla.KeyChar == 'C')
                    {
                        if (historico.Count == 0)
                        {
                            Console.WriteLine("Nenhum cálculo realizado ainda.");
                        }
                        else
                        {
                            historico.RemoveAt(historico.Count - 1);
                            Console.WriteLine("Foi removido o último resultado do console!");
                        }
                        Console.WriteLine("Histórico atual-------------------------");
                        if (historico.Count == 0)
                        {
                            Console.WriteLine("Nenhum cálculo realizado ainda.");
                        }
                        else
                        {
                            foreach (var item in historico)
                            {
                                Console.WriteLine(item);
                            }
                        }
                        Console.Clear();
                        Console.WriteLine("Console limpo com sucesso!");

                    }
                    else
                    {
                        Console.WriteLine("Outra tecla foi pressionada!");
                    }
                   
                    break;
            }
        } while (opcao != 9);
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
