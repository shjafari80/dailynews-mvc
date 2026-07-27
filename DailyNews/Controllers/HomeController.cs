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

    public async Task<IActionResult> Index(string? query, string? category, string? period)
    {
        var newsQuery = _context.News
            .Include(n => n.Category)
            .Include(n => n.Author)
            .AsQueryable();

        if (!string.IsNullOrWhiteSpace(query))
        {
            newsQuery = newsQuery.Where(n => EF.Functions.Like(n.Title, $"%{query}%"));
        }

        if (!string.IsNullOrWhiteSpace(category) && category != "All")
        {
            newsQuery = newsQuery.Where(n => n.Category.Name == category);
        }

        if (!string.IsNullOrWhiteSpace(period) && period != "all")
        {
            var cutoff = period switch
            {
                "today" => DateTime.Today,
                "week" => DateTime.Today.AddDays(-7),
                "month" => DateTime.Today.AddMonths(-1),
                _ => DateTime.MinValue
            };
            newsQuery = newsQuery.Where(n => n.PublishDate >= cutoff);
        }

        var news = await newsQuery
            .OrderByDescending(n => n.PublishDate)
            .ToListAsync();

        ViewData["SearchQuery"] = query;
        ViewData["SelectedCategory"] = string.IsNullOrWhiteSpace(category) ? "All" : category;
        ViewData["SelectedPeriod"] = string.IsNullOrWhiteSpace(period) ? "all" : period;
        ViewData["Categories"] = await _context.Categories.OrderBy(c => c.Name).ToListAsync();

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
