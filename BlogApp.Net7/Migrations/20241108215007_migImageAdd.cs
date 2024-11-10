using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogApp.Net7.Migrations
{
    /// <inheritdoc />
    public partial class migImageAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UImage",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PImage",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UImage",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PImage",
                table: "Posts");
        }
    }
}
