using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NetMVC.Models;

namespace NetMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    public IActionResult Index()
    {
        ViewBag.thongBao = "Du lieu HttpGet";
        return View();
    }
    [HttpPost]
    public IActionResult Index(string FullName, string Email)
    {
        string strOutput = "Hello " + FullName.ToUpper() + "-" + Email;
        ViewBag.thongBao = strOutput;
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
