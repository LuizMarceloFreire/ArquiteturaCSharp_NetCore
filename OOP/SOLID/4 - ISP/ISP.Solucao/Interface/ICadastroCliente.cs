using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._4___ISP.ISP.Solucao
{
    public interface ICadastroCliente : ICadastro
    {
        void ValidarDados();
        void EnviarEmail();
    }
}
