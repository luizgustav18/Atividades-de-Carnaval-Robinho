using System;
static class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o valor de A:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor de B:");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor de C:");
        int c = int.Parse(Console.ReadLine());

        double r = Math.Pow(a + b, 2);
        double s = Math.Pow(b + c, 2);
        double d = (r + s) / 2;
        Console.WriteLine("O valor de D é: " + d);
    }
}