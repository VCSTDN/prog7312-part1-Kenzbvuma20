using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReportsIssue.Migrations
{
    /// <inheritdoc />
    public partial class AddMediaAttachmentFilePath : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MediaAttachmentFilePath",
                table: "ReportIssues",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MediaAttachmentFilePath",
                table: "ReportIssues");
        }
    }
}
