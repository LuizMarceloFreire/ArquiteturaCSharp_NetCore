using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._02___Structural._2._3_Composite
{
    public class ExecucaoComposite
    {
        public static void Executar()
        {
            var validacaoCadastro = new Mensagem("O cadastro não foi realizado!");

            var usuarioFormErro = new Mensagem("O usuário informou um nome inválido.");

            var tamanhoNomeForm = new InputFormMessage("O nome precisa possuir mais de 2 caracteres.");
            var nomeVazioForm = new InputFormMessage("O nome não pode possuir números.");

            usuarioFormErro.AdicionarFilha(tamanhoNomeForm);
            usuarioFormErro.AdicionarFilha(nomeVazioForm);

            validacaoCadastro.AdicionarFilha(usuarioFormErro);

            var domainUsuarioErro = new Mensagem("Problemas ao processar o cadastro de usuário.");

            var cpfUsuarioDomain = new DomainMessage("O CPF informado já está em uso!");
            var emailUsuarioDomain = new DomainMessage("O E-mail informado já está em uso!");

            domainUsuarioErro.AdicionarFilha(cpfUsuarioDomain);
            domainUsuarioErro.AdicionarFilha(emailUsuarioDomain);

            validacaoCadastro.AdicionarFilha(domainUsuarioErro);

            validacaoCadastro.ExibirMensagem(2);
        }
    }
}
