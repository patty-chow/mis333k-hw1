using Microsoft.AspNetCore.Mvc;

namespace Chow_Patty_HW1.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment _environment;
        public HomeController(IWebHostEnvironment environment)
        {
            _environment = environment;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Professional()
        {
            return View();
        }


        public IActionResult Resume()
        {
            string path = _environment.WebRootPath + "/files/PattyChow_Resume.pdf";
            var stream = new FileStream(path, FileMode.Open);
            return File(stream, "application/pdf", "PattyChow_Resume.pdf");
        }
    }
}
