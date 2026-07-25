using Microsoft.AspNetCore.Mvc;
using DailyNews.Models;

namespace DailyNews.Controllers;

public class HomeController : Controller
{
    // TODO (Phase 2): inject NewsDbContext and load the latest news here.
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult About()
    {
        return View();
    }

    // TODO (Phase 2): load a single article by id from NewsDbContext.
    public IActionResult Details(int id)
    {
        return View();
    }

    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = HttpContext.TraceIdentifier });
    }
}
