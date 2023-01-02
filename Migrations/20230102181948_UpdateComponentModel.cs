using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebProgramlama.Migrations
{
    public partial class UpdateComponentModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Picture",
                table: "Components");

            migrationBuilder.AddColumn<string>(
                name: "PictureUrl",
                table: "Components",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PictureUrl",
                table: "Components");

            migrationBuilder.AddColumn<byte[]>(
                name: "Picture",
                table: "Components",
                type: "varbinary(max)",
                nullable: true);
        }
    }
}
