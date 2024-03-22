using System;

class Program
{
    static void Main(string[] args)
    {
        for (int contador = 10; contador >= 1; contador--)
        {
            for (int valor = 10; valor >= 1; valor--)
            {
                int resultado = contador * valor;  
                Console.WriteLine(contador + " X " + valor + " = " + resultado);
            }
            System.Console.WriteLine();
        }
    }
}
