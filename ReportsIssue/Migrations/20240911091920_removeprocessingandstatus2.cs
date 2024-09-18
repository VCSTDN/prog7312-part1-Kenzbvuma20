using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReportsIssue.Migrations
{
    /// <inheritdoc />
    public partial class removeprocessingandstatus2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsProcessing",
                table: "ReportIssues");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "ReportIssues");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsProcessing",
                table: "ReportIssues",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "ReportIssues",
                type: "int",
                nullable: true);
        }
    }
}
