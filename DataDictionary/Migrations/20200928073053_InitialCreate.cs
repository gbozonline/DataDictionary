using Microsoft.EntityFrameworkCore.Migrations;

namespace DataDictionary.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Applications",
                columns: table => new
                {
                    ApplicationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationName = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Owner = table.Column<string>(nullable: true),
                    SecAppExpert = table.Column<string>(nullable: true),
                    ISContact = table.Column<string>(nullable: true),
                    FileName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applications", x => x.ApplicationId);
                });

            migrationBuilder.CreateTable(
                name: "KeywordDefinitions",
                columns: table => new
                {
                    KeywordDefinitionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KeywordDefinitionName = table.Column<string>(nullable: false),
                    ApplicationId = table.Column<int>(nullable: false),
                    ApplicationName = table.Column<string>(nullable: true),
                    Field1Description = table.Column<string>(nullable: false),
                    Field2Description = table.Column<string>(nullable: true),
                    Field3Description = table.Column<string>(nullable: true),
                    Field4Description = table.Column<string>(nullable: true),
                    Field5Description = table.Column<string>(nullable: true),
                    Field6Description = table.Column<string>(nullable: true),
                    Field7Description = table.Column<string>(nullable: true),
                    Field8Description = table.Column<string>(nullable: true),
                    Field9Description = table.Column<string>(nullable: true),
                    Field10Description = table.Column<string>(nullable: true),
                    Field11Description = table.Column<string>(nullable: true),
                    Field12Description = table.Column<string>(nullable: true),
                    Field13Description = table.Column<string>(nullable: true),
                    Field14Description = table.Column<string>(nullable: true),
                    Field15Description = table.Column<string>(nullable: true),
                    Field16Description = table.Column<string>(nullable: true),
                    Field17Description = table.Column<string>(nullable: true),
                    Field18Description = table.Column<string>(nullable: true),
                    Field19Description = table.Column<string>(nullable: true),
                    Field20Description = table.Column<string>(nullable: true),
                    Field21Description = table.Column<string>(nullable: true),
                    Field22Description = table.Column<string>(nullable: true),
                    Field23Description = table.Column<string>(nullable: true),
                    Field24Description = table.Column<string>(nullable: true),
                    Field25Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KeywordDefinitions", x => x.KeywordDefinitionId);
                    table.ForeignKey(
                        name: "FK_KeywordDefinitions_Applications_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Applications",
                        principalColumn: "ApplicationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Keywords",
                columns: table => new
                {
                    KeywordId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KeywordDefinitionId = table.Column<int>(nullable: false),
                    KeywordDefinitionName = table.Column<string>(nullable: true),
                    Field1 = table.Column<string>(nullable: false),
                    Field2 = table.Column<string>(nullable: true),
                    Field3 = table.Column<string>(nullable: true),
                    Field4 = table.Column<string>(nullable: true),
                    Field5 = table.Column<string>(nullable: true),
                    Field6 = table.Column<string>(nullable: true),
                    Field7 = table.Column<string>(nullable: true),
                    Field8 = table.Column<string>(nullable: true),
                    Field9 = table.Column<string>(nullable: true),
                    Field10 = table.Column<string>(nullable: true),
                    Field11 = table.Column<string>(nullable: true),
                    Field12 = table.Column<string>(nullable: true),
                    Field13 = table.Column<string>(nullable: true),
                    Field14 = table.Column<string>(nullable: true),
                    Field15 = table.Column<string>(nullable: true),
                    Field16 = table.Column<string>(nullable: true),
                    Field17 = table.Column<string>(nullable: true),
                    Field18 = table.Column<string>(nullable: true),
                    Field19 = table.Column<string>(nullable: true),
                    Field20 = table.Column<string>(nullable: true),
                    Field21 = table.Column<string>(nullable: true),
                    Field22 = table.Column<string>(nullable: true),
                    Field23 = table.Column<string>(nullable: true),
                    Field24 = table.Column<string>(nullable: true),
                    Field25 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Keywords", x => x.KeywordId);
                    table.ForeignKey(
                        name: "FK_Keywords_KeywordDefinitions_KeywordDefinitionId",
                        column: x => x.KeywordDefinitionId,
                        principalTable: "KeywordDefinitions",
                        principalColumn: "KeywordDefinitionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KeywordDefinitions_ApplicationId",
                table: "KeywordDefinitions",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Keywords_KeywordDefinitionId",
                table: "Keywords",
                column: "KeywordDefinitionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Keywords");

            migrationBuilder.DropTable(
                name: "KeywordDefinitions");

            migrationBuilder.DropTable(
                name: "Applications");
        }
    }
}
