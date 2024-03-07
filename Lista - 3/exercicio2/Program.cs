using System;

class Program
{
    public static void Main(string[] args)
    {
        double somatorio = 0;

        Console.WriteLine("Seja bem vindo(a)");
        Console.WriteLine("Por favor digite a quantidade de produtos");
        double quantidadedeprodutos = double.Parse(Console.ReadLine());

        int contador = 1;
        while (contador <= quantidadedeprodutos)
        {
            Console.WriteLine("Digite o valor do produto");
            double preco = double.Parse(Console.ReadLine());

            somatorio = somatorio + preco;

            contador++;
        }
        if (somatorio >= 150)
        {
            System.Console.WriteLine("Parbéns! Voçê ganhou frete gratis em sua compra no valor de " + "R$ " + somatorio);
        }
        else
        {
            System.Console.WriteLine("O valor deu " + "R$ " + somatorio);
        }
    }

}


