using System;

class Program 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite o valor da Base do Triangulo");
        double base1 = double.Parse(Console.ReadLine());

         Console.WriteLine("Digite o valor da Altura do Triangulo");
        double altura = double.Parse(Console.ReadLine());

        int numero1 = 2; 

        double resultado = (base1 * altura) / numero1;
        Console.WriteLine("À área do triangulo eh:" + resultado);

        bool MaiorQue = resultado >= 20;

        Console.WriteLine("O  valor é maior que 20?" + MaiorQue);
    }
}