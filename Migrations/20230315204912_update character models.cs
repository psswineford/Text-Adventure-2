using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Text_Adventure_2.Migrations
{
    public partial class updatecharactermodels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrentRoom",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "CurrentRoom",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrentRoom",
                table: "Characters");

            migrationBuilder.AddColumn<int>(
                name: "CurrentRoom",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
