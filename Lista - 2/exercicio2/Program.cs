using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite a 1º Nota:");
        double nota1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a 2º Nota:");
        double nota2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a 3º Nota:");
        double nota3 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a 4º Nota:");
        double nota4 = double.Parse(Console.ReadLine());

        double numero1 = 4.0;

        double Media = (nota1 + nota2 + nota3 + nota4) / numero1;

        bool Aprovado = Media >= 5.0;
        bool Recuperacao = Media < 5.0 && Media >= 3.0;
        bool Reprovado = Media < 3.0;

        if (Aprovado)
        {
            Console.WriteLine("Aluno Aprovado");

        }
        if (Recuperacao)
        {
            Console.WriteLine("Aluno em Recuperação");

        }
        if (Reprovado)
        {
            Console.WriteLine("Aluno Reprovado");

        }

    }
}