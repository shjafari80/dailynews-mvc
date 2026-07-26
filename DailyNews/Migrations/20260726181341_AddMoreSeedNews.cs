using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DailyNews.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreSeedNews : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "AuthorId", "CategoryId", "Content", "ImageUrl", "PublishDate", "Title" },
                values: new object[,]
                {
                    { 4, 1, 1, "Lawmakers spent hours reviewing the proposed budget...", null, new DateTime(2026, 2, 7, 9, 30, 0, 0, DateTimeKind.Unspecified), "Parliament Debates New Budget Proposal" },
                    { 5, 1, 1, "Talks focused on trade and regional stability...", null, new DateTime(2026, 2, 10, 11, 0, 0, 0, DateTimeKind.Unspecified), "Foreign Minister Meets Regional Leaders" },
                    { 6, 1, 1, "The new rules aim to improve transparency...", null, new DateTime(2026, 2, 14, 8, 45, 0, 0, DateTimeKind.Unspecified), "Election Commission Announces New Guidelines" },
                    { 7, 1, 1, "Analysts are divided on what the changes mean...", null, new DateTime(2026, 2, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), "Cabinet Reshuffle Sparks Public Debate" },
                    { 8, 1, 2, "The decision comes amid ongoing inflation concerns...", null, new DateTime(2026, 2, 8, 10, 0, 0, 0, DateTimeKind.Unspecified), "Central Bank Adjusts Interest Rates" },
                    { 9, 1, 2, "Consumer prices rose at their slowest pace since last year...", null, new DateTime(2026, 2, 11, 9, 15, 0, 0, DateTimeKind.Unspecified), "Inflation Slows for Third Straight Month" },
                    { 10, 1, 2, "Investors reacted positively to the latest earnings reports...", null, new DateTime(2026, 2, 15, 17, 30, 0, 0, DateTimeKind.Unspecified), "Stock Market Reaches Record High" },
                    { 11, 1, 2, "New job figures beat analyst expectations...", null, new DateTime(2026, 2, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), "Unemployment Rate Drops to New Low" },
                    { 12, 1, 3, "A last-minute goal secured their place in the final...", null, new DateTime(2026, 2, 9, 20, 0, 0, 0, DateTimeKind.Unspecified), "Local Club Advances to Cup Final" },
                    { 13, 1, 3, "The deal keeps him at the club for another three years...", null, new DateTime(2026, 2, 12, 13, 0, 0, 0, DateTimeKind.Unspecified), "Star Striker Signs New Contract" },
                    { 14, 1, 3, "Thousands took part in this year's event...", null, new DateTime(2026, 2, 16, 7, 0, 0, 0, DateTimeKind.Unspecified), "Marathon Draws Record Number of Runners" },
                    { 15, 1, 3, "The young squad impressed fans throughout the tournament...", null, new DateTime(2026, 2, 20, 19, 0, 0, 0, DateTimeKind.Unspecified), "Youth Team Claims Regional Championship" },
                    { 16, 1, 4, "The exhibition features works from local artists...", null, new DateTime(2026, 2, 6, 10, 0, 0, 0, DateTimeKind.Unspecified), "New Exhibition Opens at City Museum" },
                    { 17, 1, 4, "Organizers revealed the full schedule today...", null, new DateTime(2026, 2, 13, 15, 0, 0, 0, DateTimeKind.Unspecified), "Film Festival Announces This Year's Lineup" },
                    { 18, 1, 4, "The century-old building has been fully restored...", null, new DateTime(2026, 2, 17, 18, 30, 0, 0, DateTimeKind.Unspecified), "Historic Theater Reopens After Renovation" },
                    { 19, 1, 4, "The novel has been praised for its vivid storytelling...", null, new DateTime(2026, 2, 21, 11, 0, 0, 0, DateTimeKind.Unspecified), "Local Author Wins National Book Award" },
                    { 20, 1, 4, "The annual festival celebrated regional musical heritage...", null, new DateTime(2026, 2, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), "Traditional Music Festival Draws Thousands" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 20);
        }
    }
}
