using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite sua altura (ex: 1.80): ");
        double altura = double.Parse(Console.ReadLine());

        Console.WriteLine("Qual é o seu sexo? (M/F): ");
        string sexo = Console.ReadLine().ToUpper();

        double peso;

        if (sexo == "M")
        {
            peso = (72.7 * altura) - 58;
        }
        else
        {
            peso = (62.1 * altura) - 44.7;
        }

        Console.WriteLine("Seu peso ideal seria: " + peso + " kg");
    }
}
