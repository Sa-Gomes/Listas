using System;

class Program
{
    static void Main(string[] args)
    {
        
        for (int decrecente = 200, crecente = 0; decrecente >= 0; decrecente -= 4, crecente += 2)
        {
            System.Console.WriteLine(crecente + " - " + decrecente);      
        }    
    }
}
