using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._3___LSP.LSP.Solucao
{
    public class Quadrado : Paralelograma
    {
        public Quadrado(int altura, int largura) : base(altura, largura)
        {
            if (largura != altura)
                throw new ArgumentException("Os dois lados do quadrado precisam ser iguais");
        }
    }
}
