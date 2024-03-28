using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Promact.CustomerSuccess.Platform.Migrations
{
    /// <inheritdoc />
    public partial class Update_Sprint_Model : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DocumentVersions_Users_CreatorId",
                table: "DocumentVersions");

            migrationBuilder.DropForeignKey(
                name: "FK_DocumentVersions_Users_LastModifierId",
                table: "DocumentVersions");

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

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectResources_Users_CreatorId",
                table: "ProjectResources");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectResources_Users_LastModifierId",
                table: "ProjectResources");

            migrationBuilder.DropForeignKey(
                name: "FK_RemediationStep_Users_CreatorId",
                table: "RemediationStep");

            migrationBuilder.DropForeignKey(
                name: "FK_RemediationStep_Users_LastModifierId",
                table: "RemediationStep");

            migrationBuilder.DropForeignKey(
                name: "FK_RiskProfiles_Users_CreatorId",
                table: "RiskProfiles");

            migrationBuilder.DropForeignKey(
                name: "FK_RiskProfiles_Users_LastModifierId",
                table: "RiskProfiles");

            migrationBuilder.DropForeignKey(
                name: "FK_Sprints_Users_CreatorId",
                table: "Sprints");

            migrationBuilder.DropForeignKey(
                name: "FK_Sprints_Users_LastModifierId",
                table: "Sprints");

            migrationBuilder.DropIndex(
                name: "IX_Sprints_CreatorId",
                table: "Sprints");

            migrationBuilder.DropIndex(
                name: "IX_Sprints_LastModifierId",
                table: "Sprints");

            migrationBuilder.DropIndex(
                name: "IX_RiskProfiles_CreatorId",
                table: "RiskProfiles");

            migrationBuilder.DropIndex(
                name: "IX_RiskProfiles_LastModifierId",
                table: "RiskProfiles");

            migrationBuilder.DropIndex(
                name: "IX_RemediationStep_CreatorId",
                table: "RemediationStep");

            migrationBuilder.DropIndex(
                name: "IX_RemediationStep_LastModifierId",
                table: "RemediationStep");

            migrationBuilder.DropIndex(
                name: "IX_ProjectResources_CreatorId",
                table: "ProjectResources");

            migrationBuilder.DropIndex(
                name: "IX_ProjectResources_LastModifierId",
                table: "ProjectResources");

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
                name: "IX_DocumentVersions_CreatorId",
                table: "DocumentVersions");

            migrationBuilder.DropIndex(
                name: "IX_DocumentVersions_LastModifierId",
                table: "DocumentVersions");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Sprints");

            migrationBuilder.DropColumn(
                name: "ExtraProperties",
                table: "Sprints");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "RiskProfiles");

            migrationBuilder.DropColumn(
                name: "ExtraProperties",
                table: "RiskProfiles");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "RemediationStep");

            migrationBuilder.DropColumn(
                name: "ExtraProperties",
                table: "RemediationStep");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "ProjectResources");

            migrationBuilder.DropColumn(
                name: "ExtraProperties",
                table: "ProjectResources");

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
                table: "DocumentVersions");

            migrationBuilder.DropColumn(
                name: "ExtraProperties",
                table: "DocumentVersions");

            migrationBuilder.CreateTable(
                name: "Stakeholders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Contact = table.Column<string>(type: "text", nullable: false),
                    ProjectId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stakeholders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stakeholders_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Stakeholders_ProjectId",
                table: "Stakeholders",
                column: "ProjectId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stakeholders");

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Sprints",
                type: "character varying(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ExtraProperties",
                table: "Sprints",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "RiskProfiles",
                type: "character varying(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ExtraProperties",
                table: "RiskProfiles",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "RemediationStep",
                type: "character varying(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ExtraProperties",
                table: "RemediationStep",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "ProjectResources",
                type: "character varying(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ExtraProperties",
                table: "ProjectResources",
                type: "text",
                nullable: false,
                defaultValue: "");

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
                name: "IX_Sprints_CreatorId",
                table: "Sprints",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Sprints_LastModifierId",
                table: "Sprints",
                column: "LastModifierId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskProfiles_CreatorId",
                table: "RiskProfiles",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskProfiles_LastModifierId",
                table: "RiskProfiles",
                column: "LastModifierId");

            migrationBuilder.CreateIndex(
                name: "IX_RemediationStep_CreatorId",
                table: "RemediationStep",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_RemediationStep_LastModifierId",
                table: "RemediationStep",
                column: "LastModifierId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectResources_CreatorId",
                table: "ProjectResources",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectResources_LastModifierId",
                table: "ProjectResources",
                column: "LastModifierId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectResources_Users_CreatorId",
                table: "ProjectResources",
                column: "CreatorId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectResources_Users_LastModifierId",
                table: "ProjectResources",
                column: "LastModifierId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RemediationStep_Users_CreatorId",
                table: "RemediationStep",
                column: "CreatorId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RemediationStep_Users_LastModifierId",
                table: "RemediationStep",
                column: "LastModifierId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RiskProfiles_Users_CreatorId",
                table: "RiskProfiles",
                column: "CreatorId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RiskProfiles_Users_LastModifierId",
                table: "RiskProfiles",
                column: "LastModifierId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sprints_Users_CreatorId",
                table: "Sprints",
                column: "CreatorId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sprints_Users_LastModifierId",
                table: "Sprints",
                column: "LastModifierId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
