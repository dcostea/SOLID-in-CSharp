using static System.Console;

namespace ApexCode.SOLID.OCP.Initial
{
    class Program
    {
        static void Main()
        {
            var someCountry = "RO";
            WriteLine($"{someCountry} is European Union Country: {IsEuropeanUnionCountry(someCountry)}");

            ReadKey(true);
        }

        public static bool IsEuropeanUnionCountry(string country)
        {
            return country switch
            {
                "UK" => true,
                "DE" => true,
                "FR" => true,
                //case "RO":
                //    return true;
                _ => false,
            };
        }
    }
}
