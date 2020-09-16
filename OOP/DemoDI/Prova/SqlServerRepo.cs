using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDI.Prova
{
    public class SqlServerRepo<TEntity> : BaseRepositorio<TEntity> where TEntity : class
    {
        public SqlServerRepo(DbContext contexto) : base(contexto) { }
        public override TEntity Alterar(TEntity instancia) { return base.Alterar(instancia); }
        public override TEntity Excluir(int id) { return base.Excluir(id); }
        public override TEntity Incluir(TEntity instancia) { return base.Incluir(instancia); }
        public override List<TEntity> Obter() { return base.Obter(); }
        public override TEntity ObterPorId(int id) { return base.ObterPorId(id); }
    }
}
