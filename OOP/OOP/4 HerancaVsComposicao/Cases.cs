using OOP._2_Pilare_OOP;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP._4_HerancaVsComposicao
{
    #region Caso 1
    public class PessoaFisica : Pessoa
    {
        public string Cpf { get; set; }
    }

    public class PessoaFisica2
    {
        public Pessoa Pessoa { get; set; }
        public string Cpf { get; set; }
    }

    public class TesteHerancaComposicao
    {
        public TesteHerancaComposicao()
        {
            var pessoaHeranca = new PessoaFisica
            {
                Nome = "Luiz",
                DataNascimento = DateTime.Now,
                Cpf = "06558149141"
            };

            var pessoaComposcicao = new PessoaFisica2
            {
                Pessoa = new Pessoa
                {
                    Nome = "Luiz",
                    DataNascimento = DateTime.Now,
                },
                Cpf = "06558149141"
            };

            var nomeHeranca = pessoaHeranca.Nome;
            var nomeComposicao = pessoaComposcicao.Pessoa.Nome;
        }
    }

    #endregion

    #region Caso 2 
    public interface IRepositorio<T>
    {
        void Adicionar(T obj);

        void Excluir(T obj);
    }

    public interface IRepositorioPessoa
    {
        void Adicionar(Pessoa obj);
    }

    public class Repositorio<T> : IRepositorio<T>
    {
        public void Adicionar(T obj)
        {
           // Adicionar pessoa
        }

        public void Excluir(T obj)
        {
           // Excluir pessoa
        }
    }

    public class RepositorioHerancaPessoa : Repositorio<Pessoa>, IRepositorioPessoa
    {

    }

    public class RepositorioComposicaoPessoa : IRepositorioPessoa
    {
        private readonly IRepositorio<Pessoa> _repositorioPessoa;

        public RepositorioComposicaoPessoa(IRepositorio<Pessoa> repositorioPessoa)
        {
            _repositorioPessoa = repositorioPessoa;
        }
        public void Adicionar(Pessoa obj)
        {
            _repositorioPessoa.Adicionar(obj);
        }

        //public void Excluir(Pessoa obj)
        //{
        //    _repositorioPessoa.Excluir(obj);
        //}
    }

    public class TesteHerancaComposicao2
    {
        public TesteHerancaComposicao2()
        {
            var repoHeranca = new RepositorioHerancaPessoa();
            repoHeranca.Adicionar(new Pessoa());
            repoHeranca.Excluir(new Pessoa());

            var repoCompo = new RepositorioComposicaoPessoa(new Repositorio<Pessoa>());
            repoCompo.Adicionar(new Pessoa());
            //repoCompo.Excluir(new Pessoa());
        }
    }

    #endregion
}
