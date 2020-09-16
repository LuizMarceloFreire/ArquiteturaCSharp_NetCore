using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns._02___Structural._2._2___Facade.Domain
{
    public class PagamentoCartaoCreditoService :IPagamento
    {
        private readonly IPagamentoCartaoCreditoFacade _pagamentoCartaoCreditoFacade;
        public PagamentoCartaoCreditoService(IPagamentoCartaoCreditoFacade pagamentoCartaoCreditoFacade)
        {
            _pagamentoCartaoCreditoFacade = pagamentoCartaoCreditoFacade;
        }

        public Pagamento RealizarPagamento(Pedido pedido, Pagamento pagamento)
        {
            pagamento.Valor = pedido.Produtos.Sum(p => p.Valor);
            Console.WriteLine("Iniciando Pagamento via Cartão de Crédito - Valor R$ " + pagamento.Valor);

            if (_pagamentoCartaoCreditoFacade.RealizarPagamento(pedido, pagamento))
            {
                pagamento.Status = "Pago via cartão de crédito";

                return pagamento;
            }

            pagamento.Status = "Cartão de crédito recusado!";

            return pagamento;
        }
    }
}
