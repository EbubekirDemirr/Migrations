using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class AddPrimaryKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FluentAPİ_Books",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DailyPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ISPN = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FluentAPİ_Books", x => x.BookId);
                });

            migrationBuilder.CreateTable(
                name: "FluentAPİ_BookTypes",
                columns: table => new
                {
                    BookTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FluentAPİ_BookTypes", x => x.BookTypeId);
                });

            migrationBuilder.CreateTable(
                name: "FluentAPİ_Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FluentAPİ_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "FluentAPİ_Publishers",
                columns: table => new
                {
                    PublisherId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PublisherName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FluentAPİ_Publishers", x => x.PublisherId);
                });

            migrationBuilder.CreateTable(
                name: "FluentAPİ_Writers",
                columns: table => new
                {
                    WriterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WriterFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WriterLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WriterBirthDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WriterBirthPlace = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FluentAPİ_Writers", x => x.WriterId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FluentAPİ_Books");

            migrationBuilder.DropTable(
                name: "FluentAPİ_BookTypes");

            migrationBuilder.DropTable(
                name: "FluentAPİ_Categories");

            migrationBuilder.DropTable(
                name: "FluentAPİ_Publishers");

            migrationBuilder.DropTable(
                name: "FluentAPİ_Writers");
        }
    }
}
