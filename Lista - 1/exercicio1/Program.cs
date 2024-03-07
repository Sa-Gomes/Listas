using System;

class Program 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite à 1º Nota");
        double nota1 = double.Parse(Console.ReadLine());

         Console.WriteLine("Digite à 2º Nota");
        double nota2 = double.Parse(Console.ReadLine());

         Console.WriteLine("Digite à 3º Nota");
        double nota3 = double.Parse(Console.ReadLine());

         Console.WriteLine("Digite à 4º Nota");
        double nota4 = double.Parse(Console.ReadLine());

        double numero1 = 4.0;

        double Media = (nota1 + nota2 + nota3 + nota4) / numero1;
        Console.WriteLine("À média do aluno eh:" + Media);
    }
}