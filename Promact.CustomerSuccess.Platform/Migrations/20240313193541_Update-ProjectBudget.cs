using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Promact.CustomerSuccess.Platform.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProjectBudget : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectBudgets_Users_CreatorId",
                table: "ProjectBudgets");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectBudgets_Users_LastModifierId",
                table: "ProjectBudgets");

            migrationBuilder.DropIndex(
                name: "IX_ProjectBudgets_CreatorId",
                table: "ProjectBudgets");

            migrationBuilder.DropIndex(
                name: "IX_ProjectBudgets_LastModifierId",
                table: "ProjectBudgets");

            migrationBuilder.DropColumn(
                name: "BudgetedCost",
                table: "ProjectBudgets");

            migrationBuilder.DropColumn(
                name: "ContractDuration",
                table: "ProjectBudgets");

            migrationBuilder.DropColumn(
                name: "Currency",
                table: "ProjectBudgets");

            migrationBuilder.AlterColumn<string>(
                name: "Severity",
                table: "RiskProfiles",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<DateTime>(
                name: "ClosureDate",
                table: "RiskProfiles",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Description",
                table: "RiskProfiles",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "RiskProfiles",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClosureDate",
                table: "RiskProfiles");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "RiskProfiles");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "RiskProfiles");

            migrationBuilder.AlterColumn<int>(
                name: "Severity",
                table: "RiskProfiles",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<double>(
                name: "BudgetedCost",
                table: "ProjectBudgets",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "ContractDuration",
                table: "ProjectBudgets",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Currency",
                table: "ProjectBudgets",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectBudgets_CreatorId",
                table: "ProjectBudgets",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectBudgets_LastModifierId",
                table: "ProjectBudgets",
                column: "LastModifierId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectBudgets_Users_CreatorId",
                table: "ProjectBudgets",
                column: "CreatorId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectBudgets_Users_LastModifierId",
                table: "ProjectBudgets",
                column: "LastModifierId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
