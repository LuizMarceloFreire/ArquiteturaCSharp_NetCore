using System;
using System.Collections.Generic;
using System.Text;

namespace OOP._2_Pilare_OOP
{
    public class AutomacaoCafe
    {
        public void ServirCafe()
        {
            var novoCafe = new Cafeteira();
            novoCafe.Ligar();
            novoCafe.PrepararCafe();
            novoCafe.Desligar();
        }
    }
}
