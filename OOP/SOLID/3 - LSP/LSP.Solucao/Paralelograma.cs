using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._3___LSP.LSP.Solucao
{
    public abstract class Paralelograma
    {
        protected Paralelograma(int altura, int largura)
        {
            Altura = altura;
            Largura = largura;
        }

        public int Altura { get; private set; }
        public int Largura { get; private set; }
        public double Area { get { return Altura * Largura; } }
    }
}
