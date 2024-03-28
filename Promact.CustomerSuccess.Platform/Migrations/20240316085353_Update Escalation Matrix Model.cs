using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Promact.CustomerSuccess.Platform.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEscalationMatrixModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EscalationMatrices_Users_CreatorId",
                table: "EscalationMatrices");

            migrationBuilder.DropForeignKey(
                name: "FK_EscalationMatrices_Users_LastModifierId",
                table: "EscalationMatrices");

            migrationBuilder.DropIndex(
                name: "IX_EscalationMatrices_CreatorId",
                table: "EscalationMatrices");

            migrationBuilder.DropIndex(
                name: "IX_EscalationMatrices_LastModifierId",
                table: "EscalationMatrices");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "EscalationMatrices");

            migrationBuilder.RenameColumn(
                name: "ExtraProperties",
                table: "EscalationMatrices",
                newName: "PersonName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PersonName",
                table: "EscalationMatrices",
                newName: "ExtraProperties");

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "EscalationMatrices",
                type: "character varying(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_EscalationMatrices_CreatorId",
                table: "EscalationMatrices",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_EscalationMatrices_LastModifierId",
                table: "EscalationMatrices",
                column: "LastModifierId");

            migrationBuilder.AddForeignKey(
                name: "FK_EscalationMatrices_Users_CreatorId",
                table: "EscalationMatrices",
                column: "CreatorId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EscalationMatrices_Users_LastModifierId",
                table: "EscalationMatrices",
                column: "LastModifierId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
