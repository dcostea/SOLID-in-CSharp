using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DIP.Initial.Models
{
    public interface IPetRepository
    {
        IEnumerable<Pet> GetAll();
    }
}