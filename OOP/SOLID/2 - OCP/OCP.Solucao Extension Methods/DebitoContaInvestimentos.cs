using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._2___OCP.OCP.Solucao_Extension_Methods
{
    public static class DebitoContaInvestimentos
    {
        public static string DebitarContaInvestimentos(this DebitoConta debitoConta)
        {
            return debitoConta.FormatarTransacao();
        }
    }
}
