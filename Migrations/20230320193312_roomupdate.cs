using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Text_Adventure_2.Migrations
{
    public partial class roomupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Option1Num",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Option1Text",
                table: "Rooms",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Option2Num",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Option2Text",
                table: "Rooms",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Option3Num",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Option3Text",
                table: "Rooms",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Option1Num",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "Option1Text",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "Option2Num",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "Option2Text",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "Option3Num",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "Option3Text",
                table: "Rooms");
        }
    }
}
