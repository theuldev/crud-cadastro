using Microsoft.EntityFrameworkCore.Migrations;



#nullable disable

namespace crud_mvc.Migrations
{
    public partial class moviment_migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Health",
                table: "_Client",
                newName: "MCivil");

            migrationBuilder.AddColumn<string>(
                name: "HealthI",
                table: "_Client",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HealthI",
                table: "_Client");

            migrationBuilder.RenameColumn(
                name: "MCivil",
                table: "_Client",
                newName: "Health");
        }
    }
}
