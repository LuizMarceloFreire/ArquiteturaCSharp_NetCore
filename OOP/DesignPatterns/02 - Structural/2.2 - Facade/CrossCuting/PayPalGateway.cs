using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns._02___Structural._2._2___Facade.CrossCuting
{
    public class PayPalGateway : IPayPalGateway
    {
        public bool CommitTransaction(string cardHashKey, string orderId, decimal amount)
        {
            return new Random().Next(2) == 0;
        }

        public string GetCardHashKey(string serviceKey, string cartaoCredito)
        {
            return new string(Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", 10).Select(x => x[new Random().Next(x.Length)]).ToArray());
        }

        public string GetPayPalServiceKey(string apiKey, string encriptionKey)
        {
            return new string(Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", 10).Select(x => x[new Random().Next(x.Length)]).ToArray());
        }
    }
}
