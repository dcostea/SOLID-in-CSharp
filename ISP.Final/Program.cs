using static System.Console;

namespace ApexCode.SOLID.ISP.Final
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


            ReadKey(true);
        }
    }

    public interface IBird
    {
        void Chirp();
        void Flap();
        void Eat();
    }

    public interface IFlyingBird : IBird
    {
        void Fly();
    }

    public class Dove : IFlyingBird
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
    }
}

