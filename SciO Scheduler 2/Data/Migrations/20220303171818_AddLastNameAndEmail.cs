using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SciO_Scheduler_2.Data.Migrations
{
    public partial class AddLastNameAndEmail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "Gantt",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "studentLastName",
                table: "Gantt",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "email",
                table: "Gantt");

            migrationBuilder.DropColumn(
                name: "studentLastName",
                table: "Gantt");
        }
    }
}
