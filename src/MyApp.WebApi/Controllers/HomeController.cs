using Microsoft.AspNetCore.Mvc;

namespace MyApp.WebApi.Controllers
{

    public class HomeController : Controller
    {

        public IActionResult Index()
        {

            return View();
        }
    }
}