using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DIP.Final.Models
{
    public class DogRepository : IPetRepository
    {
        public IEnumerable<Pet> GetAll()
        {
            System.Threading.Thread.Sleep(5000); // simulate long time data fetching

            return new List<Dog>
                {
                new Dog { Age = 5, Name = "Rex" },
                new Dog { Age = 3, Name = "Spot" },
                new Dog { Age = 2, Name = "Skip" },
                new Dog { Age = 6, Name = "Lucky" }
            };
        }
    }
}