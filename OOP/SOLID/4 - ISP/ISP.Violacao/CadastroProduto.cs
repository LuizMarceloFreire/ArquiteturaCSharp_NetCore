using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._4___ISP.ISP.Violacao
{
    public class CadastroProduto : ICadastro
    {
        public void EnviarEmail()
        {
            throw new NotImplementedException("Esse método não serve pra porra nenhuma.");
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
