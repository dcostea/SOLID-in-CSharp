using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DIP.Final.Models
{
    public class PetRepository : IPetRepository
    {
        public IEnumerable<Pet> GetAll()
        {
            System.Threading.Thread.Sleep(5000); // simulate long time data fetching

            return new List<Pet>
                {
                new Pet { Age = 5, Name = "Tux" },
                new Pet { Age = 3, Name = "Chip" },
                new Pet { Age = 2, Name = "Dale" },
                new Pet { Age = 6, Name = "Tweety" }
            };
        }
    }
}