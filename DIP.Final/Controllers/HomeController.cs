using DIP.Final.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DIP.Final.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class HomeController : ControllerBase
    {
        readonly IPetRepository dogRepository;

        public HomeController(IPetRepository dogRepository)
        {
            this.dogRepository = dogRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Pet>> Get()
        {
            //IPetRepository dogRepository = new DogRepository();

            var dogs = dogRepository.GetAll();

            return Ok(dogs);
        }
    }
}