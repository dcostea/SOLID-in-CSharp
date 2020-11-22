using System.Collections.Generic;

namespace DIP.Final.Models
{
    public interface IPetRepository
    {
        IEnumerable<Pet> GetAll();
    }
}