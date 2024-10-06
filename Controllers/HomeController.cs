using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Test.Models;

namespace Test.Controllers;

public class HomeController : Controller
{
    

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

   public IActionResult Login()
   { return View();}
}
