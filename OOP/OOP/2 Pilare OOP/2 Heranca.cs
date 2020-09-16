using System;
using System.Collections.Generic;
using System.Text;

namespace OOP._2_Pilare_OOP
{
    public class Funcionario : Pessoa
    {
        public DateTime DataAdmissao { get; set; }

        public string Registro { get; set; }
    }
     
    public class Processo
    {
        public void Execucao()
        {
            var funcionario = new Funcionario()
            {
                Nome = "Luiz Marcelo",
                DataNascimento = Convert.ToDateTime("1998/01/01"),
                DataAdmissao = DateTime.Now,
                Registro = "0123456",
            };

            funcionario.CalcularIdade();
        }
    }
}
