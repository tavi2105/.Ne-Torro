using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Predictions.Persistence.Migrations
{
    public partial class PredictionIntialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Predictions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Predictions", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Centric" },
                    { 2, "Ness" },
                    { 3, "Endava" }
                });

            migrationBuilder.InsertData(
                table: "Predictions",
                columns: new[] { "Id", "CompanyId", "Date", "Price" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2020, 12, 3, 23, 46, 36, 488, DateTimeKind.Local).AddTicks(6372), 100.0 },
                    { 2, 2, new DateTime(2020, 12, 3, 23, 46, 36, 490, DateTimeKind.Local).AddTicks(9685), 100.0 },
                    { 3, 3, new DateTime(2020, 12, 3, 23, 46, 36, 490, DateTimeKind.Local).AddTicks(9759), 100.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Predictions");
        }
    }
}
