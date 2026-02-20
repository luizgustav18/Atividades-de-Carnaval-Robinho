using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite x1 e y1:");
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite x2 e y2:");
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());

        double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

        Console.WriteLine("a distncia dos pontos é: "+ d);
    }
}