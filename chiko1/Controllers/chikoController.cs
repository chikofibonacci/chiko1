using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace chiko4.Controllers
{
    public class chikoController : Controller
    {
        public string fibonacci(int index)
        {
            if (index <= 0) return $"{"Error"}";
            else if (index == 1) return $"{1}";
            else if (index > 40) return $"{"Error"}";
            else
            {
                int number = index - 1;
                int[] Fib = new int[number + 1];
                Fib[0] = 1;
                Fib[1] = 1;
                for (int i = 2; i <= number; i++)
                {
                    Fib[i] = Fib[i - 2] + Fib[i - 1];
                }
                return $"{Fib[number]}";
            }
        }

        [ActionName("Welcome")]
        public string Hello()
        {
            return "Hello ASP.NET";
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
