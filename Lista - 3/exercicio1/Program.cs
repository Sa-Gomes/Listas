using System;
using System.Reflection;
using System.Reflection.Metadata;

class Program 
{
    public static void Main(string[] args)
    {
        const int Moradores = 3;
        double somatorioSalario = 0;
        double SomatorioFilhos = 0;
        double MaiorSalario = 0;

        for (int contador = 1; contador <= Moradores; contador ++)
        {
            System.Console.WriteLine("Dígite o Salário Mensal da Residência " + contador);
            double salario = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Dígite o número de Filhos da Residência " + contador);
            double filhos = double.Parse(Console.ReadLine());

            somatorioSalario = somatorioSalario + salario;
            SomatorioFilhos = SomatorioFilhos + filhos;

            if(salario > MaiorSalario)
            {
                MaiorSalario = salario;
            }           
        }
        double SalarioMedio = somatorioSalario / Moradores;
        double Mediafilhos = SomatorioFilhos / Moradores;

        System.Console.WriteLine("Média salarial: " + Math.Round(SalarioMedio, 2) + " R$ ");
        System.Console.WriteLine("Média do números de filhos por habitantes: " + Math.Round(Mediafilhos));
        System.Console.WriteLine("Maior Salário: " + MaiorSalario + " R$ ");
    }
}