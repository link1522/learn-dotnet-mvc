using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HelloMVC.Models;

namespace HelloMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly DotnetMvcContext _dotnetMvcContext;

    public HomeController(
        ILogger<HomeController> logger,
        DotnetMvcContext dotnetMvcContext
    )
    {
        _dotnetMvcContext = dotnetMvcContext;
        _logger = logger;
    }

    public string? Index()
    {
        return _dotnetMvcContext.book.FirstOrDefault()?.name;
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult HelloWorld()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
