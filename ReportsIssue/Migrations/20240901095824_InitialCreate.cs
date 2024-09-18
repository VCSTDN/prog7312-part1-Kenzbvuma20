using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReportsIssue.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MediaAttachments",
                columns: table => new
                {
                    MediaAttachmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MediaAttachments", x => x.MediaAttachmentId);
                });

            migrationBuilder.CreateTable(
                name: "ReportIssues",
                columns: table => new
                {
                    ReportsIssueId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MediaAttachmentId = table.Column<int>(type: "int", nullable: false),
                    EngagementMessage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportIssues", x => x.ReportsIssueId);
                    table.ForeignKey(
                        name: "FK_ReportIssues_MediaAttachments_MediaAttachmentId",
                        column: x => x.MediaAttachmentId,
                        principalTable: "MediaAttachments",
                        principalColumn: "MediaAttachmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReportIssues_MediaAttachmentId",
                table: "ReportIssues",
                column: "MediaAttachmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReportIssues");

            migrationBuilder.DropTable(
                name: "MediaAttachments");
        }
    }
}
