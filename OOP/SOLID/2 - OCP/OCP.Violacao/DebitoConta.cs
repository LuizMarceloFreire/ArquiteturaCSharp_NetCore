using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._2___OCP.OCP.Violacao
{
    public class DebitoConta
    {
        public void Debitar(decimal valor, string conta, TipoConta tipoConta)
        {
            if (tipoConta == TipoConta.Corrente)
            {
                //Debita conta corrente
            }
            if (tipoConta == TipoConta.Poupanca)
            {
                //Valida Aniversario da conta
                //Debita Conta Poupança
            }
        }
    }
} 
