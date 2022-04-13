using Microsoft.AspNetCore.Mvc;
using ASP.NET_su_MVC.Models;

namespace ASP.NET_su_MVC.Controllers
{
    public class HelloWorldController : Controller
    {
       private static List<SunsViewModel> sunys = new List<SunsViewModel>();
        public IActionResult Index()
        {
           
            return View(sunys);
        }
        public IActionResult Hello()
        {
            return View();
        }

        public IActionResult CreateDog(SunsViewModel sunsModelis)
        {
            sunys.Add(sunsModelis);
            //  return View("Index");
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Create()
        {  
            var sunsVm = new SunsViewModel();
            return View(sunsVm);
        }
    }
}
