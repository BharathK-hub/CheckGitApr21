using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssessmentAPI.Migrations
{
    public partial class Weather : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WeatherDetails",
                columns: table => new
                {
                    City = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HighTemp = table.Column<float>(type: "real", nullable: false),
                    LowTemp = table.Column<float>(type: "real", nullable: false),
                    Forecast = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeatherDetails", x => x.City);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WeatherDetails");
        }
    }
}
