using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Ewms.Models;

namespace Ewms.Controllers;

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
     
    public IActionResult Alljobs()
    {
        return View();
    }

    public IActionResult Activejobs()
    {
        return View();
    }

    public IActionResult Machine()
    {
        return View();
    }

    public IActionResult Quantity()
    {
        return View();
    }

    public IActionResult Requests()
    {
        return View();
    }

    public IActionResult Myjobs()
    {
        return View();
    }

    public IActionResult Startjob()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

