using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

//[assembly: InternalsVisibleTo("ProjetoB")]
namespace ProjetoA
{
    public class Publica
    {
        public void TestePublico() { }

        private void TestePrivado() { }

        internal void TesteInternal() { }

        protected void TesteProtegido() { }

        private protected void TestePrivadoProtegido() { }

        protected internal void TesteProtegidoInterno() { }

    }

    public sealed class Selada { }

    class Privada { }

    internal class Interna { }

    abstract class Abstrata { }

    #region Testes

    class TesteClasses 
    {
        public TesteClasses()
        {
            var publica = new Publica();
            var privada = new Privada();
            var interna = new Interna();
            //var abstrata = new Abstrata(); não tem como!!!
        }
    }

    //class TesteSelada : Selada { }

    class TesteModificador1 
    {
        public TesteModificador1()
        {
            var publica = new Publica();

            publica.TestePublico();
            publica.TesteInternal();
            publica.TesteProtegidoInterno();
            //publica.TesteProtegido();
            //publica.TestePrivadoProtegido();
            //publica.TestePrivado();
        }
    }

    class TesteModificador2 : Publica
    {
        public TesteModificador2()
        {
            TestePublico();
            TesteInternal();
            TesteProtegido();
            TesteProtegidoInterno();
            TestePrivadoProtegido();
            //TestePrivado();
        }
    }

    #endregion
}
