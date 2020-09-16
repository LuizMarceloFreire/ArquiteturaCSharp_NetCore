using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._02___Structural._2._3_Composite
{
    public class InputFormMessage : IMessage
    {
        public string Nome { get; set; }

        public InputFormMessage(string nome)
        {
            Nome = nome;
        }

        public void ExibirMensagem(int sub)
        {
            Console.WriteLine(new string('-', sub) + Nome);
        }
    }
}
