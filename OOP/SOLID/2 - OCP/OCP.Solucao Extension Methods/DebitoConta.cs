using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOLID._2___OCP.OCP.Solucao_Extension_Methods
{
    public class DebitoConta
    {
        public string NumeroTransacao { get; set; }
        public decimal Valor { get; set; }
        public string NumeroConta { get; set; }

        public string FormatarTransacao()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            NumeroTransacao = new string(Enumerable.Repeat(chars, 15)
                .Select(s => s[random.Next(s.Length)]).ToArray());

            return NumeroTransacao;
        }
    }
}
