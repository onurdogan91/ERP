using Microsoft.AspNetCore.Mvc;
using MyMVCApp.Models;

namespace MyMVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
          DogViewModel dog = new DogViewModel() { Name="Moli",Age=12};
          CatViewModel cat = new CatViewModel() { Name = "Berk", Age = 10 };
          AnimalViewModel animal = new AnimalViewModel(dog, cat);         

            return View(animal);            
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

        

        public IActionResult Hello()
        {
            return View();
        }

    }
}
