using System.Collections.Generic;
using static System.Console;

namespace ApexCode.SOLID.OCP.Final
{
    class Program
    {
        static IEnumerable<string> countries;

        static void Main()
        {
            var someCountry = "RO";

            countries = new List<string>
            {
                "UK",
                "DE",
                "FR",
                "RO"
            };

            WriteLine($"{someCountry} is European Union Country: {IsEuropeanUnionCountry(someCountry, countries)}");


            ReadKey(true);
        }

        public static bool IsEuropeanUnionCountry(string country, IEnumerable<string> countries)
        {
            foreach (var c in countries)
            {
                if (c == country)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
