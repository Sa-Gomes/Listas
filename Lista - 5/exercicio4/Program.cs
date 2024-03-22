using System;
using System.Globalization;

class Program 
{
    static void Main(string[] args)
    { 
        int somatorio = 0;
        int numero = 0;
       
        do
        {
            System.Console.WriteLine("digite um numero");
            numero = int.Parse(Console.ReadLine());
            
            if (numero % 2 == 1)
            {
                somatorio += numero;
            }
        }
        while (numero >= 0);
        System.Console.WriteLine("O somatorio de Impares eh: " + somatorio);
    }
}