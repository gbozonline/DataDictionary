using Microsoft.EntityFrameworkCore.Migrations;

namespace DataDictionary.Migrations
{
    public partial class PreventCascadeDelete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KeywordDefinitions_Applications_ApplicationId",
                table: "KeywordDefinitions");

            migrationBuilder.DropForeignKey(
                name: "FK_Keywords_KeywordDefinitions_KeywordDefinitionId",
                table: "Keywords");

            migrationBuilder.AddColumn<int>(
                name: "KeywordDefinitionId1",
                table: "Keywords",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ApplicationId1",
                table: "KeywordDefinitions",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Keywords_KeywordDefinitionId1",
                table: "Keywords",
                column: "KeywordDefinitionId1");

            migrationBuilder.CreateIndex(
                name: "IX_KeywordDefinitions_ApplicationId1",
                table: "KeywordDefinitions",
                column: "ApplicationId1");

            migrationBuilder.AddForeignKey(
                name: "FK_KeywordDefinitions_Applications_ApplicationId",
                table: "KeywordDefinitions",
                column: "ApplicationId",
                principalTable: "Applications",
                principalColumn: "ApplicationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_KeywordDefinitions_Applications_ApplicationId1",
                table: "KeywordDefinitions",
                column: "ApplicationId1",
                principalTable: "Applications",
                principalColumn: "ApplicationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Keywords_KeywordDefinitions_KeywordDefinitionId",
                table: "Keywords",
                column: "KeywordDefinitionId",
                principalTable: "KeywordDefinitions",
                principalColumn: "KeywordDefinitionId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Keywords_KeywordDefinitions_KeywordDefinitionId1",
                table: "Keywords",
                column: "KeywordDefinitionId1",
                principalTable: "KeywordDefinitions",
                principalColumn: "KeywordDefinitionId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KeywordDefinitions_Applications_ApplicationId",
                table: "KeywordDefinitions");

            migrationBuilder.DropForeignKey(
                name: "FK_KeywordDefinitions_Applications_ApplicationId1",
                table: "KeywordDefinitions");

            migrationBuilder.DropForeignKey(
                name: "FK_Keywords_KeywordDefinitions_KeywordDefinitionId",
                table: "Keywords");

            migrationBuilder.DropForeignKey(
                name: "FK_Keywords_KeywordDefinitions_KeywordDefinitionId1",
                table: "Keywords");

            migrationBuilder.DropIndex(
                name: "IX_Keywords_KeywordDefinitionId1",
                table: "Keywords");

            migrationBuilder.DropIndex(
                name: "IX_KeywordDefinitions_ApplicationId1",
                table: "KeywordDefinitions");

            migrationBuilder.DropColumn(
                name: "KeywordDefinitionId1",
                table: "Keywords");

            migrationBuilder.DropColumn(
                name: "ApplicationId1",
                table: "KeywordDefinitions");

            migrationBuilder.AddForeignKey(
                name: "FK_KeywordDefinitions_Applications_ApplicationId",
                table: "KeywordDefinitions",
                column: "ApplicationId",
                principalTable: "Applications",
                principalColumn: "ApplicationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Keywords_KeywordDefinitions_KeywordDefinitionId",
                table: "Keywords",
                column: "KeywordDefinitionId",
                principalTable: "KeywordDefinitions",
                principalColumn: "KeywordDefinitionId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
