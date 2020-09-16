using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._1___SRP.SRP.Solucao
{
    public class Cpf
    {
        public string Numero { get; set; }
        
        public bool Validar()
        {
            return Numero.Length == 11;
        }
    }
}
