using System;
using System.Net.Mail;


class Program
{
    public static void Main(string[] args)
    {
        int contador = 1;
        const int TENTATIVAS = 3;
        
        
        while (contador <= TENTATIVAS)
        {
            System.Console.WriteLine("Nome de Usuário");
            string nomeDeUsuario = (Console.ReadLine());

            System.Console.WriteLine("Senha");
            string suaSenha = (Console.ReadLine());

            if(nomeDeUsuario == "admin" && suaSenha == "123senha") 
            {   
                 System.Console.WriteLine("Login realizado com sucesso");
                 break;
            }
            else if(contador <= TENTATIVAS) 
            {
                System.Console.WriteLine("Usuário ou senha incorreta");
                if(TENTATIVAS == contador)
                {
                    System.Console.WriteLine("Sua conta foi bloqueada");
                }
            }
            contador++;
        }
    }
}
