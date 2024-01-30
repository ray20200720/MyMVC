using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyMvc.Models;

namespace MyMvc.Controllers;

public class MovieController : Controller
{
    private readonly ILogger<MovieController> _logger;

    public MovieController(ILogger<MovieController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var list = new List<Movie>();
        list.Add(new Movie { Id = 1, Title = "C#"});
        list.Add(new Movie { Id = 2, Title = "Java"});
        list.Add(new Movie { Id = 3, Title = "JavaScript"});

        ViewBag.List = list;

        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
