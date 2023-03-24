using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Text_Adventure_2.Migrations
{
    public partial class updatecharacters2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "HasJewel",
                table: "Characters",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HasRing",
                table: "Characters",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HasSword",
                table: "Characters",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HasJewel",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "HasRing",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "HasSword",
                table: "Characters");
        }
    }
}
