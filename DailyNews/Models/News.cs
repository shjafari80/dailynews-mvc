namespace DailyNews.Models;

public class News
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public DateTime PublishDate { get; set; }
    public string? ImageUrl { get; set; }

    public int CategoryId { get; set; }
    public Category Category { get; set; } = null!;

    public int AuthorId { get; set; }
    public Author Author { get; set; } = null!;
}
