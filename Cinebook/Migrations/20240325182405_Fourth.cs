using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cinebook.Migrations
{
    /// <inheritdoc />
    public partial class Fourth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movieId",
                keyValue: 1,
                columns: new[] { "endDate", "startDate" },
                values: new object[] { new DateTime(2024, 4, 24, 23, 54, 5, 51, DateTimeKind.Local).AddTicks(1116), new DateTime(2023, 11, 26, 23, 54, 5, 51, DateTimeKind.Local).AddTicks(1094) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movieId",
                keyValue: 2,
                columns: new[] { "endDate", "startDate" },
                values: new object[] { new DateTime(2024, 4, 24, 23, 54, 5, 51, DateTimeKind.Local).AddTicks(1123), new DateTime(2024, 2, 24, 23, 54, 5, 51, DateTimeKind.Local).AddTicks(1122) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movieId",
                keyValue: 3,
                columns: new[] { "endDate", "startDate" },
                values: new object[] { new DateTime(2024, 5, 24, 23, 54, 5, 51, DateTimeKind.Local).AddTicks(1130), new DateTime(2024, 4, 24, 23, 54, 5, 51, DateTimeKind.Local).AddTicks(1128) });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "movieId", "ProducerId", "endDate", "movieCategory", "movieDescription", "movieName", "moviePictureURL", "price", "startDate" },
                values: new object[] { 4, 1, new DateTime(2024, 4, 24, 23, 54, 5, 51, DateTimeKind.Local).AddTicks(1135), 5, "Oppenheimer is a 2023 epic biographical thriller film which follows the life of J. Robert Oppenheimer, the American theoretical physicist who helped develop the first nuclear weapons during World War II.", "Oppenheimer", "https://m.media-amazon.com/images/M/MV5BMDBmYTZjNjUtN2M1MS00MTQ2LTk2ODgtNzc2M2QyZGE5NTVjXkEyXkFqcGdeQXVyNzAwMjU2MTY@._V1_FMjpg_UX1000_.jpg", 250.0, new DateTime(2023, 11, 26, 23, 54, 5, 51, DateTimeKind.Local).AddTicks(1134) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "movieId",
                keyValue: 4);

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
    }
}
