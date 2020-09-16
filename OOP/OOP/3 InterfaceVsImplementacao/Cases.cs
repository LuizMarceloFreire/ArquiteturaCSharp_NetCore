using System;
using System.Collections.Generic;
using System.Text;

namespace OOP._3_InterfaceVsImplementacao
{
    public interface IRepositorio
    {
        void Adicionar();
    }
    public class Repositorio : IRepositorio
    {
        public void Adicionar()
        {
            // Adiciona Item
        }
    }
    public class RepositorioFake : IRepositorio
    {
        public void Adicionar()
        {
            // Adiciona Item
        }
    }
    public class UsoImplementacao
    {
        public void Processo()
        {
            var repositorio = new Repositorio();
            repositorio.Adicionar();
        }
    }
    public class UsoAbastracao
    {
        private readonly IRepositorio _repositorio;

        public UsoAbastracao(IRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public void Processo()
        {
            _repositorio.Adicionar();
        }
    }
    public class TesteInterfaceImplementacao
    {
        public TesteInterfaceImplementacao()
        {
            var repoImp = new UsoImplementacao();
            repoImp.Processo();

            var repoAbs = new UsoAbastracao(new Repositorio());
            repoAbs.Processo();

            var repoAbsFake = new UsoAbastracao(new RepositorioFake());
            repoAbsFake.Processo();
        }
    }
}
