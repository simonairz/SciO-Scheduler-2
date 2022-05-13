using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SciO_Scheduler_2.Data.Migrations
{
    public partial class allEvents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "studentEvents",
                table: "Gantt",
                newName: "studentEventsSelf");

            migrationBuilder.AddColumn<string>(
                name: "studentEventsA",
                table: "Gantt",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "studentEventsB",
                table: "Gantt",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "studentEventsC",
                table: "Gantt",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "studentEventsD",
                table: "Gantt",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "studentEventsE",
                table: "Gantt",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "studentEventsF",
                table: "Gantt",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "studentEventsA",
                table: "Gantt");

            migrationBuilder.DropColumn(
                name: "studentEventsB",
                table: "Gantt");

            migrationBuilder.DropColumn(
                name: "studentEventsC",
                table: "Gantt");

            migrationBuilder.DropColumn(
                name: "studentEventsD",
                table: "Gantt");

            migrationBuilder.DropColumn(
                name: "studentEventsE",
                table: "Gantt");

            migrationBuilder.DropColumn(
                name: "studentEventsF",
                table: "Gantt");

            migrationBuilder.RenameColumn(
                name: "studentEventsSelf",
                table: "Gantt",
                newName: "studentEvents");
        }
    }
}
