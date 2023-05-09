using Microsoft.EntityFrameworkCore.Migrations;

namespace GymManger.DataAccess.Migrations
{
    public partial class id : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CytiId",
                table: "Members");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CytiId",
                table: "Members",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
