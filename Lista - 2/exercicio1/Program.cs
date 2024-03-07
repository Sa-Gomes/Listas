using System;

class Program

{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite o Nome de Usuário:");
        string Nome1 = (Console.ReadLine());

        Console.WriteLine("Digite a Senha:");
        string Senha1 = (Console.ReadLine());

        if (Nome1 == "admin" && Senha1 == "123senha")
        {
            Console.WriteLine("Login realizado com sucesso");
        }
        else
        {
            Console.WriteLine("Credencias Invalidas");
        }
        
    }
}