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

    public async Task<IActionResult> Index(string? query)
    {
        var newsQuery = _context.News
            .Include(n => n.Category)
            .Include(n => n.Author)
            .AsQueryable();

        if (!string.IsNullOrWhiteSpace(query))
        {
            newsQuery = newsQuery.Where(n => EF.Functions.Like(n.Title, $"%{query}%"));
        }

        var news = await newsQuery
            .OrderByDescending(n => n.PublishDate)
            .ToListAsync();

        ViewData["SearchQuery"] = query;

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

    public async Task<IActionResult> Details(int id)
    {
        var news = await _context.News
            .Include(n => n.Category)
            .Include(n => n.Author)
            .FirstOrDefaultAsync(n => n.Id == id);

        if (news == null)
        {
            return NotFound();
        }

        var related = await _context.News
            .Include(n => n.Category)
            .Include(n => n.Author)
            .Where(n => n.CategoryId == news.CategoryId && n.Id != news.Id)
            .OrderByDescending(n => n.PublishDate)
            .Take(3)
            .ToListAsync();

        ViewData["RelatedArticles"] = related;

        return View(news);
    }

    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = HttpContext.TraceIdentifier });
    }
}
