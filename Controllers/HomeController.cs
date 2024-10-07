using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;


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
    { return View(); }
    public IActionResult forgot()
    {
        return View();
    }
    
}