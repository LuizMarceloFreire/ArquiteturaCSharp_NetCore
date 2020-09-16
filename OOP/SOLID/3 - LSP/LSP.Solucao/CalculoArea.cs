using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._3___LSP.LSP.Solucao
{
    public class CalculoArea
    {
        private static void ObterAreaParalelograma(Paralelograma paralelograma)
        {
            Console.Clear();
            Console.WriteLine("Calculo da área do Retangulo");
            Console.WriteLine();
            Console.WriteLine(paralelograma.Altura + " * " + paralelograma.Largura);
            Console.WriteLine();
            Console.WriteLine(paralelograma.Area);
            Console.ReadKey();
        }

        public static void Calcular()
        {
            var quadrado = new Quadrado(10, 10);

            var retangulo = new Retangulo(10, 7);

            ObterAreaParalelograma(quadrado);
            ObterAreaParalelograma(retangulo);
        }
    }
}
