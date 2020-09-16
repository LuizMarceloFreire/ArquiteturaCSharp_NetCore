using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDI.Prova
{
    public class Cliente
    {
        private string cpf;

        private string nome;
        public string CPF { get; set; }
        public string Nome { get; set; }
        public Cliente(string cpf, string nome)
        {
            this.CPF = cpf;
            this.Nome = nome;
        }
        public new string ToString()
        { return string.Format("Nome: {0}, CPF: {1}", this.nome, this.cpf); }
    }
}
