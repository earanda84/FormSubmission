using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FormSubmission.Models;

namespace FormSubmission.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost("success")]
    public IActionResult Success(User user)
    {
        if (ModelState.IsValid)
        {
            Console.WriteLine(user.Name);
            Console.WriteLine(user.Lastname);
            Console.WriteLine(user.Age);
            Console.WriteLine(user.Email);
            Console.WriteLine(user.Password);
            return View("Success",user);
        }
        return View("Index");
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
