using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cinebook.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedCinemaLogoURL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cinemas",
                keyColumn: "cinemaId",
                keyValue: 1,
                column: "cinemaPictureURL",
                value: "https://mgcs.net.in/wp-content/uploads/2022/12/inox-header-logo-e1671447510797-removebg-preview.png");

            migrationBuilder.UpdateData(
                table: "Cinemas",
                keyColumn: "cinemaId",
                keyValue: 2,
                column: "cinemaPictureURL",
                value: "https://media.licdn.com/dms/image/C4E12AQFfOvHNsnX_8Q/article-cover_image-shrink_600_2000/0/1520054403600?e=2147483647&v=beta&t=VVHE6XoMtfIPbzsBUfyTSWuxvMK-jBcVWgNeQ6WWlfM");

            migrationBuilder.UpdateData(
                table: "Cinemas",
                keyColumn: "cinemaId",
                keyValue: 3,
                column: "cinemaPictureURL",
                value: "https://zeevector.com/wp-content/uploads/LOGO/PVR-Cinemas-Logo-PNG-HD.jpg");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cinemas",
                keyColumn: "cinemaId",
                keyValue: 1,
                column: "cinemaPictureURL",
                value: "https://m.media-amazon.com/images/M/MV5BNjE3NDQyOTYyMV5BMl5BanBnXkFtZTcwODcyODU2Mw@@._V1_FMjpg_UX1000_.jpg");

            migrationBuilder.UpdateData(
                table: "Cinemas",
                keyColumn: "cinemaId",
                keyValue: 2,
                column: "cinemaPictureURL",
                value: "https://media.licdn.com/dms/image/C5603AQHadjWvyBiX5g/profile-displayphoto-shrink_800_800/0/1592130902477?e=2147483647&v=beta&t=gtZwZ8XguQLYuQanGqzkJdDh330xW2i1oivtRpF37SM");

            migrationBuilder.UpdateData(
                table: "Cinemas",
                keyColumn: "cinemaId",
                keyValue: 3,
                column: "cinemaPictureURL",
                value: "https://m.media-amazon.com/images/M/MV5BMTY5NzZmMmUtMzNlMS00MDdlLTg1ZTYtZjBkMWE1MDAwYjQ1XkEyXkFqcGdeQXVyMTE0MzQwMjgz._V1_QL75_UX500_CR0,0,500,281_.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movieId",
                keyValue: 1,
                columns: new[] { "endDate", "startDate" },
                values: new object[] { new DateTime(2024, 4, 22, 15, 46, 51, 98, DateTimeKind.Local).AddTicks(1488), new DateTime(2023, 11, 24, 15, 46, 51, 98, DateTimeKind.Local).AddTicks(1465) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movieId",
                keyValue: 2,
                columns: new[] { "endDate", "startDate" },
                values: new object[] { new DateTime(2024, 4, 22, 15, 46, 51, 98, DateTimeKind.Local).AddTicks(1495), new DateTime(2024, 2, 22, 15, 46, 51, 98, DateTimeKind.Local).AddTicks(1494) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movieId",
                keyValue: 3,
                columns: new[] { "endDate", "startDate" },
                values: new object[] { new DateTime(2024, 5, 22, 15, 46, 51, 98, DateTimeKind.Local).AddTicks(1501), new DateTime(2024, 4, 22, 15, 46, 51, 98, DateTimeKind.Local).AddTicks(1500) });
        }
    }
}
