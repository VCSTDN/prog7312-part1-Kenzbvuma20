using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ReportsIssue.Migrations
{
    /// <inheritdoc />
    public partial class SeedLocalEventsCorrect : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "LocalEvents",
                columns: new[] { "EventId", "Category", "Description", "EventDate", "Title" },
                values: new object[,]
                {
                    { 1, "Roads", "Join us to clean up the local park.", new DateTime(2024, 10, 8, 23, 34, 38, 402, DateTimeKind.Local).AddTicks(891), "Community Cleanup" },
                    { 2, "Other", "A talk on the latest trends in technology.", new DateTime(2024, 10, 13, 23, 34, 38, 402, DateTimeKind.Local).AddTicks(912), "Tech Talk" },
                    { 3, "Sanitation", "Discover tips and resources for a healthier lifestyle.", new DateTime(2024, 10, 18, 23, 34, 38, 402, DateTimeKind.Local).AddTicks(914), "Health and Wellness Fair" },
                    { 4, "Sanitation", "Join your neighbors to clean up local parks and streets.", new DateTime(2024, 10, 13, 23, 34, 38, 402, DateTimeKind.Local).AddTicks(916), "Community Cleanup Day" },
                    { 5, "Roads", "A discussion on improving road safety and addressing local concerns.", new DateTime(2024, 10, 23, 23, 34, 38, 402, DateTimeKind.Local).AddTicks(917), "Public Road Safety Forum" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LocalEvents",
                keyColumn: "EventId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LocalEvents",
                keyColumn: "EventId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LocalEvents",
                keyColumn: "EventId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LocalEvents",
                keyColumn: "EventId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "LocalEvents",
                keyColumn: "EventId",
                keyValue: 5);
        }
    }
}
