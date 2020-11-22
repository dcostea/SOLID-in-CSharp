using System.Collections.Generic;

namespace DIP.Initial.Models
{
    public interface IDogRepository
    {
        IEnumerable<Pet> GetAll();
        Dog GetByName(string name);
        void Insert(Dog dog);
    }
}