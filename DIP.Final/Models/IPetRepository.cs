using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DIP.Final.Models
{
    public interface IPetRepository
    {
        IEnumerable<Pet> GetAll();
    }
}