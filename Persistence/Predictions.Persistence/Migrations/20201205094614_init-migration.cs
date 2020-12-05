using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Predictions.Persistence.Migrations
{
    public partial class initmigration : Migration
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
                    OpenPrice = table.Column<double>(type: "float", nullable: false),
                    ClosePrice = table.Column<double>(type: "float", nullable: false),
                    HighPrice = table.Column<double>(type: "float", nullable: false),
                    LowPrice = table.Column<double>(type: "float", nullable: false),
                    Volume = table.Column<long>(type: "bigint", nullable: false),
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
                columns: new[] { "Id", "ClosePrice", "CompanyId", "Date", "HighPrice", "LowPrice", "OpenPrice", "Volume" },
                values: new object[,]
                {
                    { 1, 110.0, 1, new DateTime(2020, 12, 5, 11, 46, 13, 756, DateTimeKind.Local).AddTicks(4382), 222.0, 33.0, 100.0, 2323L },
                    { 2, 110.0, 2, new DateTime(2020, 12, 5, 11, 46, 13, 758, DateTimeKind.Local).AddTicks(812), 422.0, 33.0, 100.0, 4321L },
                    { 3, 110.0, 3, new DateTime(2020, 12, 5, 11, 46, 13, 758, DateTimeKind.Local).AddTicks(839), 5622.0, 100.0, 100.0, 5212L }
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
