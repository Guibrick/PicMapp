using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace picmapp.Migrations
{
    public partial class AddColumnImagesDestinations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Destinations",
                type: "varbinary(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Destinations");
        }
    }
}
