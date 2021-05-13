using Microsoft.EntityFrameworkCore.Migrations;

namespace FizzBuzzEntity.Migrations
{
    public partial class datamigration_13_05_2021_0316 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SessionId",
                table: "FizzBuzz",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SessionId",
                table: "FizzBuzz");
        }
    }
}
