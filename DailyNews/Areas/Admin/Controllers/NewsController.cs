using Microsoft.AspNetCore.Mvc;

namespace DailyNews.Areas.Admin.Controllers;

[Area("Admin")]
public class NewsController : Controller
{
    // TODO (Phase 2): wire up NewsDbContext and full CRUD (Index, Create,
    // Edit, Details, Delete) matching the routes referenced in
    // Areas/Admin/Views/News/*.cshtml.
    public IActionResult Index()
    {
        return View();
    }
}
