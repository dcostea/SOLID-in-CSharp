using System;
using static System.Console;

namespace ApexCode.SOLID.SRP.Initial
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Person
            {
                Name = "John",
                Balance = 100m
            };

            WriteLine($"{customer.Name} balance is {customer.Balance}");

            if (customer.AvailableFunds > 50m)
            {
                customer.DeductFromBalanceBy(20m);
            }

            WriteLine($"{customer.Name} balance is {customer.Balance}");


            ReadKey(true);
        }

        public class Person
        {
            private const decimal MINIMUMREQUIREDBALANCE = 10m;

            public string Name { get; set; }
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
