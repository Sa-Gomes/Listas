using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite o nome da criança");
        string nome1 = (Console.ReadLine());

        if (nome1 == "Filomena")
        {
            Console.WriteLine("Escola das 07h as 12h");
            Console.WriteLine("Almoço das 12h as 13h");
            Console.WriteLine("Futebol das 14h as 16");
            Console.WriteLine("Dever de Casa das 16h as 18h");
        }
        if (nome1 == "Joselito")
        {
            Console.WriteLine("Escola das 07h as 12h30");
            Console.WriteLine("Almoço das 13h as 14h");
            Console.WriteLine("Natação das 14h as 16");
            Console.WriteLine("Reforço escolar das 16h as 19h");
        }

        

    }
}