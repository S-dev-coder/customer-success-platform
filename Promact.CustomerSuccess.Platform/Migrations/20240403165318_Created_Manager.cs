using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Promact.CustomerSuccess.Platform.Migrations
{
    /// <inheritdoc />
    public partial class Created_Manager : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Manager",
                table: "Projects",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Manager",
                table: "Projects");
        }
    }
}
