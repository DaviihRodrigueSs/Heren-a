
using Herança.Entities;
using System;

namespace Herança
{
    class program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010, "Bob Draw", 100.0, 500.0);

            Console.WriteLine(account.Balance);

            // não tem como alterar por causa do protected account.Balance = 200.00
        }
    }
}