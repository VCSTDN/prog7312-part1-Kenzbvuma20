using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReportsIssue.Migrations
{
    /// <inheritdoc />
    public partial class PDFProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PdfFilePath",
                table: "ReportIssues",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PdfFilePath",
                table: "ReportIssues");
        }
    }
}
