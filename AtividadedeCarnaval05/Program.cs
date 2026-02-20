using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Digite a quantidade de horas extras: ");
        double horasExtras = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite seu salário: ");
        double salario = double.Parse(Console.ReadLine());

        double horasalario = salario / 160;
        double horaExtraValor = horasalario * 1.5;
        double salarioFinal = salario + (horasExtras * horaExtraValor);

        Console.WriteLine("Total de horas extras remuneradas: "+horaExtraValor+"R$");
        Console.WriteLine("Total de salário do mês: "+ salarioFinal+"R$");
    }
}