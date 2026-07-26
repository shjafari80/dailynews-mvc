using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DailyNews.Models;

namespace DailyNews.Controllers;

public class AuthorsController : Controller
{
    private readonly NewsDbContext _context;

    public AuthorsController(NewsDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var authors = await _context.Authors.ToListAsync();
        return View(authors);
    }
}
