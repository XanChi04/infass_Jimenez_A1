using infass_Jimenez_A1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.Diagnostics;
using System.Text.Json.Serialization;

namespace infass_Jimenez_A1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //kay wala paman database, ari nalang sa nako i store ang created user object sa list
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
            User? user = registeredUser
                .FirstOrDefault(u => u.Email == email && u.Password == password);

            if (user != null)
            {
                return Json(new
                {
                    success = true,
                    message = "Login Successfully!"
                });
            }

            return Json(new
            {
                success = false,
                message = "Invalid email or password."
            });
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user, string confirmPassword)
        {
            Crud crud = new Crud();

            string sql = crud.Insert(
                "User",
                new string[] { "Email", "Age", "Password" },
                new object[]
                {
                    user.Email,
                    user.Age,
                    user.Password
                });

            if (user.Password != confirmPassword)
            {
                return Content("Password did not match!");
            }

            if (registeredUser.Any(u => u.Email == user.Email))
            {
                return Content("Email is already registered.");
            }

            registeredUser.Add(user);

            return Content(sql);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult GetUser()
        {
            Crud crud = new Crud(); //gi tawag ra niya ang crud model

            string query = crud.SelectAll("User"); //iya gi access ang method sulod sa crud model
            //ang sa babaw kay para rana nga mo display ang query sa alert hahaha

            var getUser = registeredUser.ToList(); //ari naka mag add sa user object nimo padung sa list para temporary sya mo store

            return Json(new
                {
                    success = true,
                    message = query, //iya i return ang query paras alert
                    getUser //at the same time, iya sab i return ang user object nga naka store sa list
                } //, JsonRequestBehavior.AllowGet
            );
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
