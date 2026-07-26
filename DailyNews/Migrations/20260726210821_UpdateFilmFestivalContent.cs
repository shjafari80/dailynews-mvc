using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DailyNews.Migrations
{
    /// <inheritdoc />
    public partial class UpdateFilmFestivalContent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 17,
                column: "Content",
                value: "Organizers revealed the full schedule today, unveiling a lineup that spans more than sixty films from over twenty countries. The festival, now in its twelfth year, has grown steadily from a small local gathering into one of the region's most anticipated cultural events. This year's opening night will feature a much-anticipated drama exploring themes of memory and displacement, followed by a reception where attendees can meet the cast and director. Throughout the week, the festival will host a mix of feature films, documentaries, and short film showcases, with several sessions dedicated entirely to first-time directors. A retrospective section will honor a celebrated filmmaker whose career spans four decades, screening restored prints of several early works alongside newer releases. Panel discussions are scheduled daily, bringing together critics, actors, and industry professionals to talk about everything from independent financing to the future of streaming. The festival has also expanded its educational outreach this year, offering free workshops for students interested in screenwriting and cinematography. Organizers say ticket demand has already exceeded last year's numbers, with several premiere screenings selling out within hours of going on sale. A closing night award ceremony will recognize the best entries across multiple categories, chosen by a jury of respected filmmakers and critics. Local businesses have also reported an uptick in interest tied to the festival, with several restaurants and hotels offering special packages for attendees. Festival organizers hope this year's edition will further cement the city's reputation as a growing hub for independent cinema.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 17,
                column: "Content",
                value: "Organizers revealed the full schedule today...");
        }
    }
}
