using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class FluentApiOneToManyRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PublisherId",
                table: "FluentAPİ_Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_FluentAPİ_Books_PublisherId",
                table: "FluentAPİ_Books",
                column: "PublisherId");

            migrationBuilder.AddForeignKey(
                name: "FK_FluentAPİ_Books_FluentAPİ_Publishers_PublisherId",
                table: "FluentAPİ_Books",
                column: "PublisherId",
                principalTable: "FluentAPİ_Publishers",
                principalColumn: "PublisherId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FluentAPİ_Books_FluentAPİ_Publishers_PublisherId",
                table: "FluentAPİ_Books");

            migrationBuilder.DropIndex(
                name: "IX_FluentAPİ_Books_PublisherId",
                table: "FluentAPİ_Books");

            migrationBuilder.DropColumn(
                name: "PublisherId",
                table: "FluentAPİ_Books");
        }
    }
}
