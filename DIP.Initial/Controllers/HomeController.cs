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
        public ActionResult<IEnumerable<Pet>> Get()
        {
            IPetRepository dogRepository = new DogRepository();
            var dogs = dogRepository.GetAll();

            return Ok(dogs);
        }
    }
}