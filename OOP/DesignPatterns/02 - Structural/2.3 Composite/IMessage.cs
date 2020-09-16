using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._02___Structural._2._3_Composite
{
    public interface IMessage
    {
        string Nome { get; set; }

        public void ExibirMensagem(int sub);
    }
}
