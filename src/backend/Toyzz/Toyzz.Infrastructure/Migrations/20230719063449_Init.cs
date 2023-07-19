using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Toyzz.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JoinDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HeadPortrait = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "HeadPortrait", "JoinDate", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "", new DateTime(2023, 7, 19, 14, 34, 49, 659, DateTimeKind.Local).AddTicks(2514), "name_1", "http://5000:name_1" },
                    { 2, "", new DateTime(2023, 7, 19, 14, 34, 49, 659, DateTimeKind.Local).AddTicks(2537), "name_2", "http://5000:name_2" },
                    { 3, "", new DateTime(2023, 7, 19, 14, 34, 49, 659, DateTimeKind.Local).AddTicks(2539), "name_3", "http://5000:name_3" },
                    { 4, "", new DateTime(2023, 7, 19, 14, 34, 49, 659, DateTimeKind.Local).AddTicks(2541), "name_4", "http://5000:name_4" },
                    { 5, "", new DateTime(2023, 7, 19, 14, 34, 49, 659, DateTimeKind.Local).AddTicks(2543), "name_5", "http://5000:name_5" },
                    { 6, "", new DateTime(2023, 7, 19, 14, 34, 49, 659, DateTimeKind.Local).AddTicks(2547), "name_6", "http://5000:name_6" },
                    { 7, "", new DateTime(2023, 7, 19, 14, 34, 49, 659, DateTimeKind.Local).AddTicks(2549), "name_7", "http://5000:name_7" },
                    { 8, "", new DateTime(2023, 7, 19, 14, 34, 49, 659, DateTimeKind.Local).AddTicks(2551), "name_8", "http://5000:name_8" },
                    { 9, "", new DateTime(2023, 7, 19, 14, 34, 49, 659, DateTimeKind.Local).AddTicks(2553), "name_9", "http://5000:name_9" },
                    { 10, "", new DateTime(2023, 7, 19, 14, 34, 49, 659, DateTimeKind.Local).AddTicks(2557), "name_10", "http://5000:name_10" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blogs");
        }
    }
}
