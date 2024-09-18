using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReportsIssue.Migrations
{
    /// <inheritdoc />
    public partial class AddProgressProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Progress",
                table: "ReportIssues",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Progress",
                table: "ReportIssues");
        }
    }
}
