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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Seed Categories
        modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "Politics" },
            new Category { Id = 2, Name = "Economy" },
            new Category { Id = 3, Name = "Sports" },
            new Category { Id = 4, Name = "Culture" }
        );

        // Seed Author
        modelBuilder.Entity<Author>().HasData(
            new Author
            {
                Id = 1,
                Name = "Hossein Jafari Sharami",
                Bio = "Developer",
                ImageUrl = null
            }
        );

        // Seed News — dates are fixed (not DateTime.Now), so migrations stay reproducible
        modelBuilder.Entity<News>().HasData(
            new News
            {
                Id = 1,
                Title = "New Political Developments in the Country",
                Content = "In the latest political news...",
                PublishDate = new DateTime(2026, 2, 1, 10, 0, 0),
                CategoryId = 1,
                AuthorId = 1
            },
            new News
            {
                Id = 2,
                Title = "Exchange Rate Rises in the Market",
                Content = "The dollar reached a new record...",
                PublishDate = new DateTime(2026, 2, 3, 14, 30, 0),
                CategoryId = 2,
                AuthorId = 1
            },
            new News
            {
                Id = 3,
                Title = "National Team Wins Friendly Match",
                Content = "The players shone...",
                PublishDate = new DateTime(2026, 2, 5, 18, 0, 0),
                CategoryId = 3,
                AuthorId = 1
            }
        );
    }
}
