using Microsoft.EntityFrameworkCore.Migrations;

namespace PixelartCreator.Infrastructure.Migrations
{
    public partial class AddPixelartName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Pixelarts",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Pixelarts");
        }
    }
}
