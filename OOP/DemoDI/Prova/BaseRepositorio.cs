using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDI.Prova
{
    public abstract class BaseRepositorio<T> : IRepositorio<T> where T : class
    {
        protected DbContext contexto;
        public BaseRepositorio(DbContext contexto) { this.contexto = contexto; }
        public DbContext Contexto
        {
            get { return this.contexto; }
            set { this.contexto = value; }
        }
        public virtual T Alterar(T instancia) { throw new NotImplementedException(); }
        public virtual T Excluir(int id) { throw new NotImplementedException(); }
        public virtual T Incluir(T instancia) { throw new NotImplementedException(); }
        public virtual List<T> Obter() { throw new NotImplementedException(); }
        public virtual T ObterPorId(int id) { throw new NotImplementedException(); }
    }

    public class DbContext
    {
    }

    public interface IRepositorio<T> where T : class
    {
    }

    public interface IBaseRepositorio
    {
        List<Cliente> ObterTodos();

        EstadoPoco Obter(int id);

        void Criar(EstadoPoco poco);

        bool Alterar(EstadoPoco poco);

        bool Excluir(int id);
    }

    public class EstadoPoco
    {
    }
}
