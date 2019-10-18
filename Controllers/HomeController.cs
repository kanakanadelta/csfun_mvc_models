using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestMvc.Models;

namespace TestMvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string lorem = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Dolore, deserunt cumque ducimus accusamus ab natus recusandae quo accusantium voluptates, incidunt, libero ad veritatis eligendi doloremque fuga. Nisi nesciunt quis aut totam fuga voluptate sapiente quibusdam quam minus sed, molestiae debitis facere ipsam quidem placeat. Minus nesciunt ipsam cupiditate distinctio ullam.";
            return View("Index", lorem);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet("names")]
        public IActionResult Names()
        {
            string[] names = new string[]
            {
                "Bimmy",
                "Jimmy",
                "Lee",
                "Kunio"
            };
            return View(names);
        }
        [HttpGet("numbers")]
        public IActionResult Numbers()
        {
            int[] numbers = new int[]
            {
                6,6,6,9,4,2,0
            };
            return View(numbers);
        }

        [HttpGet("user")]
        public IActionResult UserView()
        {
            
            User user = new User()
            {
                FirstName = "Dude",
                LastName = "McGuy"
            };
            return View(user);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
