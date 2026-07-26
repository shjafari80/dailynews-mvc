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
            // Politics (5)
            new News { Id = 1, Title = "New Political Developments in the Country", Content = "In the latest political news...", PublishDate = new DateTime(2026, 2, 1, 10, 0, 0), CategoryId = 1, AuthorId = 1 },
            new News { Id = 4, Title = "Parliament Debates New Budget Proposal", Content = "Lawmakers spent hours reviewing the proposed budget...", PublishDate = new DateTime(2026, 2, 7, 9, 30, 0), CategoryId = 1, AuthorId = 1 },
            new News { Id = 5, Title = "Foreign Minister Meets Regional Leaders", Content = "Talks focused on trade and regional stability...", PublishDate = new DateTime(2026, 2, 10, 11, 0, 0), CategoryId = 1, AuthorId = 1 },
            new News { Id = 6, Title = "Election Commission Announces New Guidelines", Content = "The new rules aim to improve transparency...", PublishDate = new DateTime(2026, 2, 14, 8, 45, 0), CategoryId = 1, AuthorId = 1 },
            new News { Id = 7, Title = "Cabinet Reshuffle Sparks Public Debate", Content = "Analysts are divided on what the changes mean...", PublishDate = new DateTime(2026, 2, 18, 16, 0, 0), CategoryId = 1, AuthorId = 1 },

            // Economy (5)
            new News { Id = 2, Title = "Exchange Rate Rises in the Market", Content = "The dollar reached a new record...", PublishDate = new DateTime(2026, 2, 3, 14, 30, 0), CategoryId = 2, AuthorId = 1 },
            new News { Id = 8, Title = "Central Bank Adjusts Interest Rates", Content = "The decision comes amid ongoing inflation concerns...", PublishDate = new DateTime(2026, 2, 8, 10, 0, 0), CategoryId = 2, AuthorId = 1 },
            new News { Id = 9, Title = "Inflation Slows for Third Straight Month", Content = "Consumer prices rose at their slowest pace since last year...", PublishDate = new DateTime(2026, 2, 11, 9, 15, 0), CategoryId = 2, AuthorId = 1 },
            new News { Id = 10, Title = "Stock Market Reaches Record High", Content = "Investors reacted positively to the latest earnings reports...", PublishDate = new DateTime(2026, 2, 15, 17, 30, 0), CategoryId = 2, AuthorId = 1 },
            new News { Id = 11, Title = "Unemployment Rate Drops to New Low", Content = "New job figures beat analyst expectations...", PublishDate = new DateTime(2026, 2, 19, 12, 0, 0), CategoryId = 2, AuthorId = 1 },

            // Sports (5)
            new News { Id = 3, Title = "National Team Wins Friendly Match", Content = "The players shone...", PublishDate = new DateTime(2026, 2, 5, 18, 0, 0), CategoryId = 3, AuthorId = 1 },
            new News { Id = 12, Title = "Local Club Advances to Cup Final", Content = "A last-minute goal secured their place in the final...", PublishDate = new DateTime(2026, 2, 9, 20, 0, 0), CategoryId = 3, AuthorId = 1 },
            new News { Id = 13, Title = "Star Striker Signs New Contract", Content = "The deal keeps him at the club for another three years...", PublishDate = new DateTime(2026, 2, 12, 13, 0, 0), CategoryId = 3, AuthorId = 1 },
            new News { Id = 14, Title = "Marathon Draws Record Number of Runners", Content = "Thousands took part in this year's event...", PublishDate = new DateTime(2026, 2, 16, 7, 0, 0), CategoryId = 3, AuthorId = 1 },
            new News { Id = 15, Title = "Youth Team Claims Regional Championship", Content = "The young squad impressed fans throughout the tournament...", PublishDate = new DateTime(2026, 2, 20, 19, 0, 0), CategoryId = 3, AuthorId = 1 },

            // Culture (5)
            new News { Id = 16, Title = "New Exhibition Opens at City Museum", Content = "The exhibition features works from local artists...", PublishDate = new DateTime(2026, 2, 6, 10, 0, 0), CategoryId = 4, AuthorId = 1 },
            new News { Id = 17, Title = "Film Festival Announces This Year's Lineup", Content = "Organizers revealed the full schedule today, unveiling a lineup that spans more than sixty films from over twenty countries. The festival, now in its twelfth year, has grown steadily from a small local gathering into one of the region's most anticipated cultural events. This year's opening night will feature a much-anticipated drama exploring themes of memory and displacement, followed by a reception where attendees can meet the cast and director. Throughout the week, the festival will host a mix of feature films, documentaries, and short film showcases, with several sessions dedicated entirely to first-time directors. A retrospective section will honor a celebrated filmmaker whose career spans four decades, screening restored prints of several early works alongside newer releases. Panel discussions are scheduled daily, bringing together critics, actors, and industry professionals to talk about everything from independent financing to the future of streaming. The festival has also expanded its educational outreach this year, offering free workshops for students interested in screenwriting and cinematography. Organizers say ticket demand has already exceeded last year's numbers, with several premiere screenings selling out within hours of going on sale. A closing night award ceremony will recognize the best entries across multiple categories, chosen by a jury of respected filmmakers and critics. Local businesses have also reported an uptick in interest tied to the festival, with several restaurants and hotels offering special packages for attendees. Festival organizers hope this year's edition will further cement the city's reputation as a growing hub for independent cinema.", PublishDate = new DateTime(2026, 2, 13, 15, 0, 0), CategoryId = 4, AuthorId = 1 },
            new News { Id = 18, Title = "Historic Theater Reopens After Renovation", Content = "The century-old building has been fully restored...", PublishDate = new DateTime(2026, 2, 17, 18, 30, 0), CategoryId = 4, AuthorId = 1 },
            new News { Id = 19, Title = "Local Author Wins National Book Award", Content = "The novel has been praised for its vivid storytelling...", PublishDate = new DateTime(2026, 2, 21, 11, 0, 0), CategoryId = 4, AuthorId = 1 },
            new News { Id = 20, Title = "Traditional Music Festival Draws Thousands", Content = "The annual festival celebrated regional musical heritage...", PublishDate = new DateTime(2026, 2, 24, 16, 0, 0), CategoryId = 4, AuthorId = 1 }
        );
    }
}
