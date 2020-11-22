using System.Collections.Generic;

namespace DIP.Initial.Models
{
    public interface IPetRepository
    {
        IEnumerable<Pet> GetAll();
    }
}