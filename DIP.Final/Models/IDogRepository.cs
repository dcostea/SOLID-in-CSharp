using System.Collections.Generic;

namespace DIP.Final.Models
{
    public interface IDogRepository
    {
        IEnumerable<Pet> GetAll();
        Dog GetByName(string name);
        void Insert(Dog dog);
    }
}