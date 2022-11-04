using Microsoft.AspNetCore.Mvc;
using MyMVCApp.Models;
using System.Text.Encodings.Web;

namespace MyMVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {              
            return View();            
        }

        public IActionResult Create()
        {
          var dogVm = new DogViewModel();
            return View(dogVm);
        }

        public IActionResult CreateDog(DogViewModel dogViewModel)
        {
            return RedirectToAction(nameof(Index));
        }



        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }

    }
}
