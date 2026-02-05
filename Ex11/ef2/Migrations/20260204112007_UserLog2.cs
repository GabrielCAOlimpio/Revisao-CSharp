using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ef2.Migrations
{
    /// <inheritdoc />
    public partial class UserLog2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_userLogs_CreatedAt",
                table: "userLogs",
                column: "CreatedAt");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_userLogs_CreatedAt",
                table: "userLogs");
        }
    }
}
