using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._02___Structural._2._2___Facade.Domain
{
    public class Pagamento
    {
        public string Status { get; set; }
        public decimal Valor { get; set; }
        public MeioPagamento MeioPagamento { get; set; }
        public string CartaoCredito { get; set; }
        public string LinhaDigitavelBoleto { get; set; }
        public string ConfirmacaoTransferencia { get; set; }
    }
}
