
internal class Program
{
    private static void Main(string[] args)
    {
        // adição - Pamplo
    float a;
    float b;

    Console.WriteLine("primeiro número: ");
    a = float.Parse(Console.ReadLine());
    
    Console.WriteLine("segundo número: ");
    b = float.Parse(Console.ReadLine());

    Console.WriteLine("resultado  " + (a + b));


   // multiplicação - Pamplo
    float c;
    float d;
    
    Console.WriteLine("primeiro número: ");
    c = float.Parse(Console.ReadLine());
    Console.WriteLine("segundo número: ");
    d = float.Parse(Console.ReadLine());

    Console.WriteLine("resultado  " + (c * d));
    }
}
