using System.Collections.Generic;
using static System.Console;

namespace ApexCode.SOLID.LSP.Initial
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
                duck.Feed();
                duck.Quack();
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
            // none!!!
        }

        public class Battery { }
    }
}