using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Promact.CustomerSuccess.Platform.Migrations
{
    /// <inheritdoc />
    public partial class Add_Version_History_Model : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuditHistory_Projects_ProjectId",
                table: "AuditHistory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AuditHistory",
                table: "AuditHistory");

            migrationBuilder.RenameTable(
                name: "AuditHistory",
                newName: "AuditHistories");

            migrationBuilder.RenameIndex(
                name: "IX_AuditHistory_ProjectId",
                table: "AuditHistories",
                newName: "IX_AuditHistories_ProjectId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AuditHistories",
                table: "AuditHistories",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "VersionHistories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ProjectId = table.Column<Guid>(type: "uuid", nullable: false),
                    Version = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: true),
                    Change = table.Column<string>(type: "text", nullable: true),
                    ChangeReason = table.Column<string>(type: "text", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    RevisionDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ApprovalDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ApprovedBy = table.Column<string>(type: "text", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VersionHistories", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_AuditHistories_Projects_ProjectId",
                table: "AuditHistories",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuditHistories_Projects_ProjectId",
                table: "AuditHistories");

            migrationBuilder.DropTable(
                name: "VersionHistories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AuditHistories",
                table: "AuditHistories");

            migrationBuilder.RenameTable(
                name: "AuditHistories",
                newName: "AuditHistory");

            migrationBuilder.RenameIndex(
                name: "IX_AuditHistories_ProjectId",
                table: "AuditHistory",
                newName: "IX_AuditHistory_ProjectId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AuditHistory",
                table: "AuditHistory",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AuditHistory_Projects_ProjectId",
                table: "AuditHistory",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
