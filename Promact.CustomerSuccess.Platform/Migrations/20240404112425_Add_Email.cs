using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Promact.CustomerSuccess.Platform.Migrations
{
    /// <inheritdoc />
    public partial class Add_Email : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "PhaseMilestones",
                type: "character varying(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ExtraProperties",
                table: "PhaseMilestones",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<double>(
                name: "Duration",
                table: "MeetingMinutes",
                type: "double precision",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "MeetingMinutes",
                type: "character varying(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ExtraProperties",
                table: "MeetingMinutes",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "EscalationMatrices",
                type: "character varying(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ExtraProperties",
                table: "EscalationMatrices",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "DocumentVersions",
                type: "character varying(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ExtraProperties",
                table: "DocumentVersions",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_PhaseMilestones_CreatorId",
                table: "PhaseMilestones",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_PhaseMilestones_LastModifierId",
                table: "PhaseMilestones",
                column: "LastModifierId");

            migrationBuilder.CreateIndex(
                name: "IX_MeetingMinutes_CreatorId",
                table: "MeetingMinutes",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_MeetingMinutes_LastModifierId",
                table: "MeetingMinutes",
                column: "LastModifierId");

            migrationBuilder.CreateIndex(
                name: "IX_EscalationMatrices_CreatorId",
                table: "EscalationMatrices",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_EscalationMatrices_LastModifierId",
                table: "EscalationMatrices",
                column: "LastModifierId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentVersions_CreatorId",
                table: "DocumentVersions",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentVersions_LastModifierId",
                table: "DocumentVersions",
                column: "LastModifierId");

            migrationBuilder.AddForeignKey(
                name: "FK_DocumentVersions_Users_CreatorId",
                table: "DocumentVersions",
                column: "CreatorId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DocumentVersions_Users_LastModifierId",
                table: "DocumentVersions",
                column: "LastModifierId",
                principalTable: "Users",
                principalColumn: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_MeetingMinutes_Users_CreatorId",
                table: "MeetingMinutes",
                column: "CreatorId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MeetingMinutes_Users_LastModifierId",
                table: "MeetingMinutes",
                column: "LastModifierId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PhaseMilestones_Users_CreatorId",
                table: "PhaseMilestones",
                column: "CreatorId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PhaseMilestones_Users_LastModifierId",
                table: "PhaseMilestones",
                column: "LastModifierId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DocumentVersions_Users_CreatorId",
                table: "DocumentVersions");

            migrationBuilder.DropForeignKey(
                name: "FK_DocumentVersions_Users_LastModifierId",
                table: "DocumentVersions");

            migrationBuilder.DropForeignKey(
                name: "FK_EscalationMatrices_Users_CreatorId",
                table: "EscalationMatrices");

            migrationBuilder.DropForeignKey(
                name: "FK_EscalationMatrices_Users_LastModifierId",
                table: "EscalationMatrices");

            migrationBuilder.DropForeignKey(
                name: "FK_MeetingMinutes_Users_CreatorId",
                table: "MeetingMinutes");

            migrationBuilder.DropForeignKey(
                name: "FK_MeetingMinutes_Users_LastModifierId",
                table: "MeetingMinutes");

            migrationBuilder.DropForeignKey(
                name: "FK_PhaseMilestones_Users_CreatorId",
                table: "PhaseMilestones");

            migrationBuilder.DropForeignKey(
                name: "FK_PhaseMilestones_Users_LastModifierId",
                table: "PhaseMilestones");

            migrationBuilder.DropIndex(
                name: "IX_PhaseMilestones_CreatorId",
                table: "PhaseMilestones");

            migrationBuilder.DropIndex(
                name: "IX_PhaseMilestones_LastModifierId",
                table: "PhaseMilestones");

            migrationBuilder.DropIndex(
                name: "IX_MeetingMinutes_CreatorId",
                table: "MeetingMinutes");

            migrationBuilder.DropIndex(
                name: "IX_MeetingMinutes_LastModifierId",
                table: "MeetingMinutes");

            migrationBuilder.DropIndex(
                name: "IX_EscalationMatrices_CreatorId",
                table: "EscalationMatrices");

            migrationBuilder.DropIndex(
                name: "IX_EscalationMatrices_LastModifierId",
                table: "EscalationMatrices");

            migrationBuilder.DropIndex(
                name: "IX_DocumentVersions_CreatorId",
                table: "DocumentVersions");

            migrationBuilder.DropIndex(
                name: "IX_DocumentVersions_LastModifierId",
                table: "DocumentVersions");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "PhaseMilestones");

            migrationBuilder.DropColumn(
                name: "ExtraProperties",
                table: "PhaseMilestones");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "MeetingMinutes");

            migrationBuilder.DropColumn(
                name: "ExtraProperties",
                table: "MeetingMinutes");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "EscalationMatrices");

            migrationBuilder.DropColumn(
                name: "ExtraProperties",
                table: "EscalationMatrices");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "DocumentVersions");

            migrationBuilder.DropColumn(
                name: "ExtraProperties",
                table: "DocumentVersions");

            migrationBuilder.AlterColumn<int>(
                name: "Duration",
                table: "MeetingMinutes",
                type: "integer",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision");
        }
    }
}
