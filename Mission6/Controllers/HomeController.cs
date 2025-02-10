using Microsoft.AspNetCore.Mvc;
using Mission6.Models;

public class HomeController : Controller
{
    private readonly Mission6DB _context;
    private readonly ILogger<HomeController> _logger;

    public HomeController(Mission6DB temp, ILogger<HomeController> logger)
    {
        _context = temp;
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult About()
    {
        return View();
    }

    [HttpGet]
    public IActionResult NewMovie()
    {
        return View("NewMovie");
    }

    [HttpPost]
    public IActionResult NewMovie(Application response)
    {
        _context.Movies.Add(response);
        _context.SaveChanges();

        return View("Complete", response);
    }
}
