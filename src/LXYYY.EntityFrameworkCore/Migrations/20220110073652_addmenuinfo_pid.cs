using Microsoft.EntityFrameworkCore.Migrations;

namespace LXYYY.Migrations
{
    public partial class addmenuinfo_pid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LikeType",
                table: "MenuInfo",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PId",
                table: "MenuInfo",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LikeType",
                table: "MenuInfo");

            migrationBuilder.DropColumn(
                name: "PId",
                table: "MenuInfo");
        }
    }
}
