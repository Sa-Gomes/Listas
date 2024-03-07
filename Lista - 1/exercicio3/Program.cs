using System;

class Program 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite o Valor em Centavos e Converta em Real");
        int centavos1 = int.Parse(Console.ReadLine());

        int Real = centavos1 / 100;
        int centavos = centavos1 % 100;

        Console.WriteLine("O Valor em Real é:" + Real + " Reais " + centavos + " Centavos");
    }
}