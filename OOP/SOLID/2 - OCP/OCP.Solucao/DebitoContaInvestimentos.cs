using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._2___OCP.OCP.Solucao
{
    public class DebitoContaInvestimentos : DebitoConta
    {
        public override string Debitar(decimal valor, string conta)
        {
            return FormatarTransacao();
        }
    }
}
