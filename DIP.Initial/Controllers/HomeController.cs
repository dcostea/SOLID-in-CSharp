using DIP.Initial.Models;
using System.Web.Mvc;

namespace DIP.Initial.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            IPetRepository dogRepository = new DogRepository();
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