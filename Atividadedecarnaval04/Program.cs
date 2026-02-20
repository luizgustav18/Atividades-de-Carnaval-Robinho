using System;
static class Program
{
    static void Main()
    {
        double s = 0;
        double numerador = 1;

        for (int denominador = 1; denominador <= 50; denominador++)
        {
            s += numerador / denominador;
            numerador += 2;
        }

        Console.WriteLine("O valor final de S é: "+s);
    }
}