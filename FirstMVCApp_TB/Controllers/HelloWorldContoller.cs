using Microsoft.AspNetCore.Mvc;
using FirstMVCApp_TB.Models;

namespace FirstMVCApp_TB.Controllers
{
    public class HelloWorldContoller : Controller
    {
        public static List<Dog> dogs = new List<Dog>();

        public IActionResult Index()
        {
            return View(dogs);
        }

        public IActionResult Create()
        {
            Dog dog = new Dog();
            return View(dog);
        }
        public IActionResult CreateDog(Dog dog)
        {
            dogs.Add(dog);
            return RedirectToAction("Index");
        }
      
        public string Hello()
        {
            return "Hello";
        }
    }
}
