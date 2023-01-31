using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace picmapp.Migrations
{
    public partial class DropColumnImagesDestinations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Destinations");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Destinations",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
