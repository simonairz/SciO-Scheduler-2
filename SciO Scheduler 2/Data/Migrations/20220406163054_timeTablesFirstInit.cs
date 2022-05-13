using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SciO_Scheduler_2.Data.Migrations
{
    public partial class timeTablesFirstInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "timeTable",
                columns: table => new
                {
                    venue = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    blockAStartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    blockAEndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    blockBStartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    blockBEndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    blockCStartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    blockCEndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    blockDStartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    blockDEndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    blockEStartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    blockEEndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    blockFStartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    blockFEndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    bridgesStartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    bridgesEndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    gravityVehicleStartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    gravityVehicleEndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    pingPongParachuteStartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    pingPongParachuteEndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    trajectoryStartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    trajectoryEndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    wrightStuffStartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    wrightStuffEndTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_timeTable", x => x.venue);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "timeTable");
        }
    }
}
