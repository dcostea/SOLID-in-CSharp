using System;
using static System.Console;

namespace ApexCode.SOLID.ISP.Initial
{
    class Program
    {
        static void Main()
        {
            var snow = new Dove();
            snow.Chirp();
            snow.Flap();
            snow.Eat();
            snow.Fly();

            var tux = new Penguin();
            tux.Chirp();
            tux.Flap();
            tux.Eat();

            try
            {
                tux.Fly();
            }
            catch (NotImplementedException ex)
            {
                WriteLine(ex.Message);
            }


            ReadKey(true);
        }
    }

    public interface IBird
    {
        void Chirp();
        void Flap();
        void Eat();
        void Fly();
    }

    public class Dove : IBird
    {
        public void Chirp() { }
        public void Flap() { }
        public void Eat() { }
        public void Fly() { }
    }

    public class Penguin : IBird
    {
        public void Chirp() { }
        public void Flap() { }
        public void Eat() { }
        public void Fly()
        {
            throw new NotImplementedException("Penguins cannot fly!");
        }
    }
}
