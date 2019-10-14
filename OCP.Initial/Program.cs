using static System.Console;

namespace ApexCode.SOLID.OCP.Initial
{
    class Program
    {
        static void Main(string[] args)
        {
            var someCountry = "RO";
            WriteLine($"{someCountry} is European Union Country: {IsEuropeanUnionCountry(someCountry)}");

            ReadKey(true);
        }

        public static bool IsEuropeanUnionCountry(string country)
        {
            switch (country)
            {
                case "UK":
                    return true;
                case "DE":
                    return true;
                case "FR":
                    return true;
                //case "RO":
                //    return true;

                default:
                    return false;
            }
        }
    }
}
