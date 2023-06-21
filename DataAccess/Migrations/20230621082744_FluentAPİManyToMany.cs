using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class FluentAPİManyToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FluentAPİ_WriterAndBook",
                columns: table => new
                {
                    WriterId = table.Column<int>(type: "int", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FluentAPİ_WriterAndBook", x => new { x.BookId, x.WriterId });
                    table.ForeignKey(
                        name: "FK_FluentAPİ_WriterAndBook_FluentAPİ_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "FluentAPİ_Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FluentAPİ_WriterAndBook_FluentAPİ_Writers_WriterId",
                        column: x => x.WriterId,
                        principalTable: "FluentAPİ_Writers",
                        principalColumn: "WriterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FluentAPİ_WriterAndBook_WriterId",
                table: "FluentAPİ_WriterAndBook",
                column: "WriterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FluentAPİ_WriterAndBook");
        }
    }
}
