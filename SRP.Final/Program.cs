using System;
using System.Collections.Generic;
using static System.Console;

namespace ApexCode.SOLID.SRP.Final
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Person
            {
                Name = "John",
                Accounts = new List<Account> { new Account { Balance = 100m } } 
            };

            WriteLine($"{customer.Name} balance is {customer.Accounts[0].Balance}");

            if (customer.Accounts[0].AvailableFunds > 50m)
            {
                customer.Accounts[0].DeductFromBalanceBy(20m);
            }

            WriteLine($"{customer.Name} balance is {customer.Accounts[0].Balance}");


            ReadKey(true);
        }

        public class Person
        {
            public string Name { get; set; }
            public IList<Account> Accounts { get; set; }
        }

        public class Account
        {
            private const decimal MINIMUMREQUIREDBALANCE = 10m;

            public decimal Balance { get; set; }

            public decimal AvailableFunds
            {
                get { return Balance - MINIMUMREQUIREDBALANCE; }
            }

            public void DeductFromBalanceBy(decimal amountToDeduct)
            {
                if (amountToDeduct > Balance)
                    throw new InvalidOperationException("Insufficient funds.");

                Balance -= amountToDeduct;
            }
        }
    }
}
