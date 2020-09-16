using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._01___Creational._1._3___Singleton
{
    public class ExecucaoSingleton
    {
        public static void Executar()
        {
            var b1 = LoadBalance.GetLoadBalance();
            var b2 = LoadBalance.GetLoadBalance();
            var b3 = LoadBalance.GetLoadBalance();
            var b4 = LoadBalance.GetLoadBalance();

            if (b1 == b2 && b2 == b3 && b3 == b4)
            {
                Console.WriteLine("Mesma instância\n");
            }

            var balancer = LoadBalance.GetLoadBalance();

            for (var i = 0; i < 15; i++)
            {
                var serverName = balancer.NextServer.Name;
                Console.WriteLine("Disparando request para: " + serverName);
            }
        }
    }
}
