using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class FluentApiOneToOneRelationFluentAPİ_BookAndFluentAPİ_BookType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Description",
                table: "FluentAPİ_Books",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FluentAPİ_Books_Description",
                table: "FluentAPİ_Books",
                column: "Description",
                unique: true,
                filter: "[Description] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_FluentAPİ_Books_FluentAPİ_BookTypes_Description",
                table: "FluentAPİ_Books",
                column: "Description",
                principalTable: "FluentAPİ_BookTypes",
                principalColumn: "BookTypeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FluentAPİ_Books_FluentAPİ_BookTypes_Description",
                table: "FluentAPİ_Books");

            migrationBuilder.DropIndex(
                name: "IX_FluentAPİ_Books_Description",
                table: "FluentAPİ_Books");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "FluentAPİ_Books");
        }
    }
}
