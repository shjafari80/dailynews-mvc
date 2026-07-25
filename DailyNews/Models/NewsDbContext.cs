using Microsoft.EntityFrameworkCore;

namespace DailyNews.Models;

public class NewsDbContext : DbContext
{
    public NewsDbContext(DbContextOptions<NewsDbContext> options)
        : base(options)
    {
    }

    public DbSet<News> News { get; set; } = null!;
    public DbSet<Category> Categories { get; set; } = null!;
    public DbSet<Author> Authors { get; set; } = null!;

    // TODO (Phase 2): configure entity properties (OnModelCreating) and
    // seed data - 1 author, 3 news articles, 4 categories.
}
