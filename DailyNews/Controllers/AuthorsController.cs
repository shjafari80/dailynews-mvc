using Microsoft.AspNetCore.Mvc;

namespace DailyNews.Controllers;

public class AuthorsController : Controller
{
    // TODO (Phase 2): inject NewsDbContext and load the real authors list.
    public IActionResult Index()
    {
        return View();
    }
}
