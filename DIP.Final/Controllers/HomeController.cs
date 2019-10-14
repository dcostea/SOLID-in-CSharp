using DIP.Final.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DIP.Final.Controllers
{
    public class HomeController : Controller
    {
        IPetRepository dogRepository;

        public HomeController(IPetRepository dogRepository)
        {
            this.dogRepository = dogRepository;
        }

        public ActionResult Index()
        {
            //IPetRepository dogRepository = new DogRepository();

            var dogs = dogRepository.GetAll();

            return View(dogs);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}