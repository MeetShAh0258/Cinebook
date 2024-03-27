using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cinebook.Migrations
{
    /// <inheritdoc />
    public partial class Third : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movieId",
                keyValue: 1,
                columns: new[] { "endDate", "startDate" },
                values: new object[] { new DateTime(2024, 4, 24, 22, 29, 8, 802, DateTimeKind.Local).AddTicks(1021), new DateTime(2023, 11, 26, 22, 29, 8, 802, DateTimeKind.Local).AddTicks(998) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movieId",
                keyValue: 2,
                columns: new[] { "endDate", "startDate" },
                values: new object[] { new DateTime(2024, 4, 24, 22, 29, 8, 802, DateTimeKind.Local).AddTicks(1028), new DateTime(2024, 2, 24, 22, 29, 8, 802, DateTimeKind.Local).AddTicks(1027) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movieId",
                keyValue: 3,
                columns: new[] { "endDate", "startDate" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 29, 8, 802, DateTimeKind.Local).AddTicks(1034), new DateTime(2024, 4, 24, 22, 29, 8, 802, DateTimeKind.Local).AddTicks(1033) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movieId",
                keyValue: 1,
                columns: new[] { "endDate", "startDate" },
                values: new object[] { new DateTime(2024, 4, 24, 22, 28, 0, 749, DateTimeKind.Local).AddTicks(47), new DateTime(2023, 11, 26, 22, 28, 0, 749, DateTimeKind.Local).AddTicks(26) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movieId",
                keyValue: 2,
                columns: new[] { "endDate", "startDate" },
                values: new object[] { new DateTime(2024, 4, 24, 22, 28, 0, 749, DateTimeKind.Local).AddTicks(54), new DateTime(2024, 2, 24, 22, 28, 0, 749, DateTimeKind.Local).AddTicks(52) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movieId",
                keyValue: 3,
                columns: new[] { "endDate", "startDate" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 28, 0, 749, DateTimeKind.Local).AddTicks(60), new DateTime(2024, 4, 24, 22, 28, 0, 749, DateTimeKind.Local).AddTicks(58) });
        }
    }
}
