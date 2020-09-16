using System;
using System.Collections.Generic;
using System.Text;

namespace OOP._1_Classe_x_Objeto
{
    public class Casa
    {
        public int TamanhoM2 { get; set; }
        public int Andares { get; set; }
        public decimal Valor { get; set; }
        public int NumeroVagas { get; set; }
    }

    public class Objeto
    {
        public Objeto()
        {
            var casa = new Casa
            {
                TamanhoM2 = 100,
                Andares = 3,
                Valor = 100000,
                NumeroVagas = 3
            };
        }
    }
}
