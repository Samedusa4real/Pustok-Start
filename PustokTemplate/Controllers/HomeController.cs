using Microsoft.AspNetCore.Mvc;
using PustokTemplate.Models;
using System.Diagnostics;

namespace PustokTemplate.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }


    }
}