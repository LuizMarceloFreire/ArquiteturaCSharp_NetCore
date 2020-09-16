using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._4___ISP.ISP.Violacao
{
    public class CadastroCliente : ICadastro
    {
        public void EnviarEmail()
        {
            // ENVIAR E-MAIL PARA O CLIENTE
        }

        public void SalvarBanco()
        {
            // INSERT NA TABELA CLIENTE
        }

        public void ValidarDados()
        {
            //VALIDA CPF, EMAIL
        }
    }
}
