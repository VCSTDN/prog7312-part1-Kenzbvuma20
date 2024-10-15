using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ReportsIssue.Migrations
{
    /// <inheritdoc />
    public partial class SeedLocalEvents2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LocalEvents",
                keyColumn: "EventId",
                keyValue: 1,
                column: "EventDate",
                value: new DateTime(2024, 10, 10, 22, 22, 12, 286, DateTimeKind.Local).AddTicks(8161));

            migrationBuilder.UpdateData(
                table: "LocalEvents",
                keyColumn: "EventId",
                keyValue: 2,
                column: "EventDate",
                value: new DateTime(2024, 10, 15, 22, 22, 12, 286, DateTimeKind.Local).AddTicks(8183));

            migrationBuilder.UpdateData(
                table: "LocalEvents",
                keyColumn: "EventId",
                keyValue: 3,
                column: "EventDate",
                value: new DateTime(2024, 10, 20, 22, 22, 12, 286, DateTimeKind.Local).AddTicks(8185));

            migrationBuilder.UpdateData(
                table: "LocalEvents",
                keyColumn: "EventId",
                keyValue: 4,
                column: "EventDate",
                value: new DateTime(2024, 10, 15, 22, 22, 12, 286, DateTimeKind.Local).AddTicks(8187));

            migrationBuilder.UpdateData(
                table: "LocalEvents",
                keyColumn: "EventId",
                keyValue: 5,
                column: "EventDate",
                value: new DateTime(2024, 10, 25, 22, 22, 12, 286, DateTimeKind.Local).AddTicks(8189));

            migrationBuilder.InsertData(
                table: "LocalEvents",
                columns: new[] { "EventId", "Category", "Description", "EventDate", "Title" },
                values: new object[,]
                {
                    { 6, "Environment", "Help us plant trees to improve the local environment.", new DateTime(2024, 10, 17, 22, 22, 12, 286, DateTimeKind.Local).AddTicks(8191), "Tree Planting Drive" },
                    { 7, "Public Safety", "Discuss safety measures to improve public safety in your area.", new DateTime(2024, 10, 10, 22, 22, 12, 286, DateTimeKind.Local).AddTicks(8192), "Neighborhood Watch Meeting" },
                    { 8, "Accessibility", "Learn about accessibility issues and how to support an inclusive community.", new DateTime(2024, 10, 23, 22, 22, 12, 286, DateTimeKind.Local).AddTicks(8194), "Accessibility Awareness Workshop" },
                    { 9, "Utilities and Energy", "Learn tips to reduce your energy consumption and save on bills.", new DateTime(2024, 10, 12, 22, 22, 12, 286, DateTimeKind.Local).AddTicks(8196), "Energy Efficiency Seminar" },
                    { 10, "Housing and Buildings", "Join the discussion on future housing developments in the community.", new DateTime(2024, 10, 27, 22, 22, 12, 286, DateTimeKind.Local).AddTicks(8198), "Local Housing Development Discussion" },
                    { 11, "Traffic and Transportation", "Provide your feedback on proposed changes to local bus and train routes.", new DateTime(2024, 10, 14, 22, 22, 12, 286, DateTimeKind.Local).AddTicks(8199), "Public Transport Improvements Feedback" },
                    { 12, "Parks and Recreation", "Help plan the renovation of our local park facilities.", new DateTime(2024, 10, 16, 22, 22, 12, 286, DateTimeKind.Local).AddTicks(8201), "Park Renovation Planning" },
                    { 13, "Noise", "Discuss ways to reduce noise pollution in residential areas.", new DateTime(2024, 10, 21, 22, 22, 12, 286, DateTimeKind.Local).AddTicks(8203), "Noise Reduction Initiative Meeting" },
                    { 14, "Animal Control", "Come and adopt a pet while helping to control the stray animal population.", new DateTime(2024, 10, 19, 22, 22, 12, 286, DateTimeKind.Local).AddTicks(8204), "Stray Animal Adoption Day" },
                    { 15, "Education", "A forum to discuss improvements in local educational facilities and programs.", new DateTime(2024, 10, 13, 22, 22, 12, 286, DateTimeKind.Local).AddTicks(8206), "School Improvement Forum" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LocalEvents",
                keyColumn: "EventId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "LocalEvents",
                keyColumn: "EventId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "LocalEvents",
                keyColumn: "EventId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "LocalEvents",
                keyColumn: "EventId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "LocalEvents",
                keyColumn: "EventId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "LocalEvents",
                keyColumn: "EventId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "LocalEvents",
                keyColumn: "EventId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "LocalEvents",
                keyColumn: "EventId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "LocalEvents",
                keyColumn: "EventId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "LocalEvents",
                keyColumn: "EventId",
                keyValue: 15);

            migrationBuilder.UpdateData(
                table: "LocalEvents",
                keyColumn: "EventId",
                keyValue: 1,
                column: "EventDate",
                value: new DateTime(2024, 10, 8, 23, 34, 38, 402, DateTimeKind.Local).AddTicks(891));

            migrationBuilder.UpdateData(
                table: "LocalEvents",
                keyColumn: "EventId",
                keyValue: 2,
                column: "EventDate",
                value: new DateTime(2024, 10, 13, 23, 34, 38, 402, DateTimeKind.Local).AddTicks(912));

            migrationBuilder.UpdateData(
                table: "LocalEvents",
                keyColumn: "EventId",
                keyValue: 3,
                column: "EventDate",
                value: new DateTime(2024, 10, 18, 23, 34, 38, 402, DateTimeKind.Local).AddTicks(914));

            migrationBuilder.UpdateData(
                table: "LocalEvents",
                keyColumn: "EventId",
                keyValue: 4,
                column: "EventDate",
                value: new DateTime(2024, 10, 13, 23, 34, 38, 402, DateTimeKind.Local).AddTicks(916));

            migrationBuilder.UpdateData(
                table: "LocalEvents",
                keyColumn: "EventId",
                keyValue: 5,
                column: "EventDate",
                value: new DateTime(2024, 10, 23, 23, 34, 38, 402, DateTimeKind.Local).AddTicks(917));
        }
    }
}
