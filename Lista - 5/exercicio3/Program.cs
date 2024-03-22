using System;
class Program 
{
    static void Main(string[] args)
    {
        int horizontal = int.Parse(Console.ReadLine());
        int vertical = int.Parse(Console.ReadLine());

        for (int linha = 0; linha < horizontal; linha++)
        {
            for (int coluna = 0; coluna < vertical; coluna++)
            {
                System.Console.Write("*");
            }
            System.Console.WriteLine();
        }
    }

}
