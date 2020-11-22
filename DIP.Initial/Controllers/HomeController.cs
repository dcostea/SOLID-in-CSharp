using DIP.Initial.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DIP.Initial.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Pet>> GetAll()
        {
            IDogRepository dogRepository = new DogRepository();
            var dogs = dogRepository.GetAll();

            return Ok(dogs);
        }

        [HttpGet("name")]
        public ActionResult<IEnumerable<Pet>> GetByName(string name)
        {
            IDogRepository dogRepository = new DogRepository();
            var dogs = dogRepository.GetByName(name);

            return Ok(dogs);
        }

        [HttpPost]
        public ActionResult Post(Dog dog)
        {
            IDogRepository dogRepository = new DogRepository();
            dogRepository.Insert(dog);

            return Created($"/{dog.Name}", dog);
        }
    }
}