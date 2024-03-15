using System;

class Program
{
    static void Main(string[] args)
    {
        for (int contador = 1; contador <= 10; contador++)
        {
            for (int valor = 1; valor <= 10; valor++)
            {
                int resultado = contador * valor;  
                Console.WriteLine(contador + " X " + valor + " = " + resultado);
            }
            System.Console.WriteLine();
        }
    }
}
