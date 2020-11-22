using System.Collections.Generic;
using System.Linq;

namespace DIP.Initial.Models
{
    public class DogRepository : IDogRepository
    {
        public static List<Dog> Dogs { get; set; }

        static DogRepository()
        {
            Dogs = new List<Dog>
            {
                new Dog(5, "Rex", "roll"),
                new Dog(3, "Spot", "jump"),
                new Dog(4, "Skip", "laugh"),
                new Dog(7, "Lucky", "slide"),
            };
        }

        public IEnumerable<Pet> GetAll()
        {
            System.Threading.Thread.Sleep(5000); // simulate long time data fetching

            return Dogs;
        }

        public Dog GetByName(string name)
        {
            var dog = Dogs.Single(d => d.Name == name);

            return dog;
        }

        public void Insert(Dog dog)
        {
            Dogs.Add(dog);
        }
    }
}