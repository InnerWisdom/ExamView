using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DatabaseImplement.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Passs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    reisId = table.Column<int>(nullable: false),
                    name = table.Column<string>(nullable: true),
                    numPlace = table.Column<decimal>(nullable: false),
                    date = table.Column<DateTime>(nullable: false),
                    grazdanstvo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reiss",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date = table.Column<DateTime>(nullable: false),
                    company = table.Column<string>(nullable: true),
                    PasssId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reiss", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reiss_Passs_PasssId",
                        column: x => x.PasssId,
                        principalTable: "Passs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reiss_PasssId",
                table: "Reiss",
                column: "PasssId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reiss");

            migrationBuilder.DropTable(
                name: "Passs");
        }
    }
}
