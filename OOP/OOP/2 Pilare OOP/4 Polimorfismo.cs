using System;
using System.Collections.Generic;
using System.Text;

namespace OOP._2_Pilare_OOP
{
    public class Cafeteira : Eletrodomestico
    {
        public Cafeteira(string nome, int voltagem) : base(nome, voltagem) { }

        public Cafeteira() : base("Padrao", 220) { }

        private static void AquecerAgua() { }

        private static void MoerGraos() { }

        public void PrepararCafe()
        {
            Testar();
            AquecerAgua();
            MoerGraos();
        }

        public override void Ligar()
        {
            //
        }

        public override void Desligar()
        {
            //
        }
    }
}
