using System.Diagnostics;
using infass_Jimenez_A1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace infass_Jimenez_A1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //temp data paras user

        private static List<User> registeredUser = new List<User>();


        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string password)
        {
           User? user = registeredUser.FirstOrDefault(u => u.Email == email && u.Password == password);

            if (user != null)
            {
                return RedirectToAction(nameof(Index));
            }

            ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(string email, string password, string confirmPassword)
        {
           if(password != confirmPassword)
            {
                ModelState.AddModelError(string.Empty, "Passwords do not match.");
                return View();
            }

           registeredUser.Add(
               new User 
               { 
                   Email = email, 
                   Password = password 
               }
           );

            return Content($"Email: {email}\nPassword: {password}\nConfirm Password: {confirmPassword}");

        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
