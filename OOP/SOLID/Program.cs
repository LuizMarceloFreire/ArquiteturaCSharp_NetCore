using SOLID._2___OCP.OCP.Solucao_Extension_Methods;
using SOLID._3___LSP.LSP.Solucao;
using System;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha a operação");
            Console.WriteLine("1 - OCP");
            Console.WriteLine("2 - LCP");

            var opcao = Console.ReadKey();

            switch (opcao.KeyChar)
            {
                case '1':
                    CaixaEletronico.Operacoes();
                    break;
                case '2':
                    CalculoArea.Calcular();
                    break;
                default:
                    break;
            }
        }
    }
}
