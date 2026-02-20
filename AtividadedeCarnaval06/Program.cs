using System;
static class Program
{
    static void Main()
    {
        Console.Write("Digite a venda média mensal: ");
        double vendaMedia = double.Parse(Console.ReadLine());

        Console.Write("Digite o preço atual: R$ ");
        double precoAtual = double.Parse(Console.ReadLine());

        double novoPreco = precoAtual;

        if (vendaMedia < 500 && precoAtual < 30.00)
        {
            novoPreco = precoAtual * 1.10;
        }

        else if (vendaMedia >= 500 && precoAtual >= 30.00)
        {
            novoPreco = precoAtual * 0.80;
        }

        Console.WriteLine("O novo preço do produto é: " + novoPreco + "R$");
    }
}