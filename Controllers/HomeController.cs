using System.Data.Common;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BCrypt;
using BCrypt.Net;

namespace Test.Controllers;

public class HomeController : Controller
{
    private readonly Context db;
    private readonly IWebHostEnvironment _env;
    private readonly string salt = "@salt999999999985";

    public string UserName { get; private set; }

    private string password;

    public HomeController(Context _db, IWebHostEnvironment env)
    {
        db = _db;
        _env = env;
    }
    [HttpGet]

    public IActionResult Register()
    {
        return View();

    }
    [HttpPost]
    public IActionResult Register(Users users)
    {
        Users newuser = new Users()
        {
            Address = users.Address
           ,
            password = BCrypt.Net.BCrypt.HashPassword(users.password + salt)
           ,
            Name = users.Name
           ,
            Family = users.Family
           ,
            UserName = users.UserName
           ,
            PhonUmber = users.PhonUmber

        };
        db.Users.Add(newuser);
        db.SaveChanges();


        return RedirectToAction("Register", "Home");

    }

    public IActionResult Privacy()
    {
        return View();
    }
    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Login(Users users)
    {
        Users newuser = new Users()
        {

            password = BCrypt.Net.BCrypt.HashPassword(users.password + salt)

           ,
            UserName = users.UserName

        };
        db.Users.Add(newuser);
        db.SaveChanges();

        return RedirectToAction("Login", "Home");
    }
    public IActionResult forgot()
    {
        return View();
    }

}