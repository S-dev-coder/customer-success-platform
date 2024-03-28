using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Promact.CustomerSuccess.Platform.Migrations
{
    /// <inheritdoc />
    public partial class AddClientFeedback : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EscalationMatrices_Users_ApplicationUserId",
                table: "EscalationMatrices");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_ProjectBudgets_BudgetId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_BudgetId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_EscalationMatrices_ApplicationUserId",
                table: "EscalationMatrices");

            migrationBuilder.DropColumn(
                name: "BudgetId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "EscalationMatrices");

            migrationBuilder.RenameColumn(
                name: "FeedbackDate",
                table: "ClientFeedbacks",
                newName: "DateReceived");

            migrationBuilder.RenameColumn(
                name: "Details",
                table: "ClientFeedbacks",
                newName: "DetailedFeedback");

            migrationBuilder.AddColumn<Guid>(
                name: "ProjectId",
                table: "ProjectBudgets",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "ActionTaken",
                table: "ClientFeedbacks",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "ClosureDate",
                table: "ClientFeedbacks",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProjectBudgets_ProjectId",
                table: "ProjectBudgets",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectBudgets_Projects_ProjectId",
                table: "ProjectBudgets",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectBudgets_Projects_ProjectId",
                table: "ProjectBudgets");

            migrationBuilder.DropIndex(
                name: "IX_ProjectBudgets_ProjectId",
                table: "ProjectBudgets");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "ProjectBudgets");

            migrationBuilder.DropColumn(
                name: "ActionTaken",
                table: "ClientFeedbacks");

            migrationBuilder.DropColumn(
                name: "ClosureDate",
                table: "ClientFeedbacks");

            migrationBuilder.RenameColumn(
                name: "DetailedFeedback",
                table: "ClientFeedbacks",
                newName: "Details");

            migrationBuilder.RenameColumn(
                name: "DateReceived",
                table: "ClientFeedbacks",
                newName: "FeedbackDate");

            migrationBuilder.AddColumn<Guid>(
                name: "BudgetId",
                table: "Projects",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ApplicationUserId",
                table: "EscalationMatrices",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Projects_BudgetId",
                table: "Projects",
                column: "BudgetId");

            migrationBuilder.CreateIndex(
                name: "IX_EscalationMatrices_ApplicationUserId",
                table: "EscalationMatrices",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_EscalationMatrices_Users_ApplicationUserId",
                table: "EscalationMatrices",
                column: "ApplicationUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_ProjectBudgets_BudgetId",
                table: "Projects",
                column: "BudgetId",
                principalTable: "ProjectBudgets",
                principalColumn: "Id");
        }
    }
}
