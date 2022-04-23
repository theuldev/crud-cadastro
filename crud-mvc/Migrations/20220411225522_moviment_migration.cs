using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace crud_mvc.Migrations
{
    public partial class moviment_migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CPF",
                table: "_Client",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Career",
                table: "_Client",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Details",
                table: "_Client",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "_Client",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "_Client",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Health",
                table: "_Client",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "_Client",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RG",
                table: "_Client",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Service",
                table: "_Client",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CPF",
                table: "_Client");

            migrationBuilder.DropColumn(
                name: "Career",
                table: "_Client");

            migrationBuilder.DropColumn(
                name: "Details",
                table: "_Client");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "_Client");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "_Client");

            migrationBuilder.DropColumn(
                name: "Health",
                table: "_Client");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "_Client");

            migrationBuilder.DropColumn(
                name: "RG",
                table: "_Client");

            migrationBuilder.DropColumn(
                name: "Service",
                table: "_Client");
        }
    }
}
