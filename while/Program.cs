using System;

namespace senha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a senha: ");
            int senha = int.Parse(Console.ReadLine());

            while (senha == 2002)
            {
                Console.WriteLine(senha);
                Console.Write("Senha correta");
                break;
            }

            if (senha != 2002 )
            Console.WriteLine("Senha Invalida");

        }
    }
}