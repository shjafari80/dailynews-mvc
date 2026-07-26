using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DailyNews.Models;

namespace DailyNews.Controllers;

public class HomeController : Controller
{
    private readonly NewsDbContext _context;

    public HomeController(NewsDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var news = await _context.News
            .Include(n => n.Category)
            .Include(n => n.Author)
            .OrderByDescending(n => n.PublishDate)
            .ToListAsync();

        return View(news);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult About()
    {
        return View();
    }

    // TODO (#9): load a single article by id from NewsDbContext.
    public IActionResult Details(int id)
    {
        return View();
    }

    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = HttpContext.TraceIdentifier });
    }
}
