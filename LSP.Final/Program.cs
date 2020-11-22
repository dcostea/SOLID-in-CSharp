using System;
using System.Collections.Generic;
using static System.Console;

namespace ApexCode.SOLID.LSP.Final
{
    class Program
    {
        static void Main()
        {
            var ducks = new List<Duck>
            {
                new PekinDuck { },
                new BatteryPoweredDuck(new BatteryPoweredDuck.Battery()) { }
            };

            foreach (var duck in ducks)
            {
                if (duck is BatteryPoweredDuck) // code smell (LSP violation)
                {
                    var batteryPoweredDuck = duck as BatteryPoweredDuck;

                    batteryPoweredDuck.Quack();
                }
                else
                {
                    var pekinDuck = duck as PekinDuck;

                    pekinDuck.Feed();
                    pekinDuck.Quack();
                }
            }


            ReadKey(true);
        }
    }

    public class Duck
    {
        public void Quack()
        {
            WriteLine("quack quack");
        }

        public virtual void Feed()
        {
            WriteLine("yum yum");
        }
    }

    public class PekinDuck : Duck
    {
        public override void Feed()
        {
            WriteLine("pekin: yum yum");
        }
    }

    public class BatteryPoweredDuck : Duck
    {
        public BatteryPoweredDuck(Battery battery) { }

        public override void Feed()
        {
            throw new NotSupportedException();
        }

        public class Battery { }
    }
}