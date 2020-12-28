using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Predictions.Persistence.Migrations
{
    public partial class migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    table.ForeignKey(
                        name: "FK_Predictions_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 1, "Planeta", "Centric" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 2, "Planeta", "Ness" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 3, "Planeta", "Endava" });

            migrationBuilder.InsertData(
                table: "Predictions",
                columns: new[] { "Id", "ClosePrice", "CompanyId", "Date", "HighPrice", "LowPrice", "OpenPrice", "Volume" },
                values: new object[] { 1, 110.0, 1, new DateTime(2020, 12, 26, 15, 3, 48, 50, DateTimeKind.Local).AddTicks(2291), 222.0, 33.0, 100.0, 2323L });

            migrationBuilder.InsertData(
                table: "Predictions",
                columns: new[] { "Id", "ClosePrice", "CompanyId", "Date", "HighPrice", "LowPrice", "OpenPrice", "Volume" },
                values: new object[] { 2, 110.0, 2, new DateTime(2020, 12, 26, 15, 3, 48, 53, DateTimeKind.Local).AddTicks(4129), 422.0, 33.0, 100.0, 4321L });

            migrationBuilder.InsertData(
                table: "Predictions",
                columns: new[] { "Id", "ClosePrice", "CompanyId", "Date", "HighPrice", "LowPrice", "OpenPrice", "Volume" },
                values: new object[] { 3, 110.0, 3, new DateTime(2020, 12, 26, 15, 3, 48, 53, DateTimeKind.Local).AddTicks(4277), 5622.0, 100.0, 100.0, 5212L });

            migrationBuilder.CreateIndex(
                name: "IX_Predictions_CompanyId",
                table: "Predictions",
                column: "CompanyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Predictions");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
