using Microsoft.AspNetCore.Mvc;

namespace GirisSayfaMVC.Controllers
{
    using Models;
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Index(Login model)
        {
            bool durum = ModelState.IsValid;

            if (ModelState.IsValid)
            {
                
            }
            else
            {
                ModelState.AddModelError("Hata", "Lütfen belirtilen alanları doldurunuz...");
            }
            return View();
        }
    }
}
