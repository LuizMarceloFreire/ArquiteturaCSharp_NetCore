using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._4___ISP.ISP.Solucao
{
    public interface ICadastroProduto : ICadastro
    {
        void ValidarDados();
    }
}
