using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._03___Bahavioral._3._1___Command
{
    public class ExecucaoCommand
    {
        public static void Executar()
        {
            var user = new Usuario();

            user.Adicionar('+', 100);
            Console.ReadKey();
            user.Adicionar('-', 50);
            Console.ReadKey();
            user.Adicionar('*', 10);
            Console.ReadKey();
            user.Adicionar('/', 2);
            Console.ReadKey();

            user.Desfazer(4);
            Console.ReadKey();

            user.Retornar(3);
        }
    }
}
