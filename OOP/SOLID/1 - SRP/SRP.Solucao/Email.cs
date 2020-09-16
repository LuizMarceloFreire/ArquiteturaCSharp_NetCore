using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._1___SRP
{
    public class Email
    {
        public string Endereco { get; set; }

        public bool Validar()
        {
            return Endereco.Contains("@");
        }
    }
}
