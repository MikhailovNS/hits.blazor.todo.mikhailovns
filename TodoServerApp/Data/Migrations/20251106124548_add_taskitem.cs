using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TodoServerApp.Migrations
{
    /// <inheritdoc />
    public partial class add_taskitem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TaskItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FinishDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskItems", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TaskItems",
                columns: new[] { "Id", "CreatedDate", "Description", "FinishDate", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 11, 6, 17, 45, 48, 44, DateTimeKind.Local).AddTicks(2614), "Описание задачи 1", null, "задача 1" },
                    { 2, new DateTime(2025, 11, 6, 17, 45, 48, 44, DateTimeKind.Local).AddTicks(2630), "Описание задачи 2", null, "задача 2" },
                    { 3, new DateTime(2025, 11, 6, 17, 45, 48, 44, DateTimeKind.Local).AddTicks(2632), "Описание задачи 3", null, "задача 3" },
                    { 4, new DateTime(2025, 11, 6, 17, 45, 48, 44, DateTimeKind.Local).AddTicks(2633), "Описание задачи 4", null, "задача 4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TaskItems");
        }
    }
}
