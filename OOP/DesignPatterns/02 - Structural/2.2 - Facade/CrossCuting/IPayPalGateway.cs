using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._02___Structural._2._2___Facade.CrossCuting
{
    public interface IPayPalGateway
    {
        bool CommitTransaction(string cardHashKey, string orderId, decimal amount);
        string GetCardHashKey(string serviceKey, string cartaoCredito);
        string GetPayPalServiceKey(string apiKey, string encriptionKey);
    }
}
