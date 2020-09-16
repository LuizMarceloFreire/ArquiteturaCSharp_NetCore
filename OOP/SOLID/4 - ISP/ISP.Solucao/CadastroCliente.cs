using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._4___ISP.ISP.Solucao
{
    public class CadastroCliente : ICadastroCliente
    {
        public void EnviarEmail()
        {
            //ENVIAR EMAIL PARA O CLIENTE
        }

        public void SalvarBanco()
        {
            //INSERT NO BANCO NA TABELA CLIENTE
        }

        public void ValidarDados()
        {
            //VALIDA CPF, EMAIL
        }
    }
}
