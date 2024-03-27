using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cinebook.Migrations
{
    /// <inheritdoc />
    public partial class Fifth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cinemas_Movies");

            migrationBuilder.AddColumn<int>(
                name: "CinemaId",
                table: "Movies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movieId",
                keyValue: 1,
                columns: new[] { "CinemaId", "endDate", "startDate" },
                values: new object[] { 2, new DateTime(2024, 4, 25, 1, 28, 19, 825, DateTimeKind.Local).AddTicks(6634), new DateTime(2023, 11, 27, 1, 28, 19, 825, DateTimeKind.Local).AddTicks(6613) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movieId",
                keyValue: 2,
                columns: new[] { "CinemaId", "endDate", "startDate" },
                values: new object[] { 3, new DateTime(2024, 4, 25, 1, 28, 19, 825, DateTimeKind.Local).AddTicks(6645), new DateTime(2024, 2, 25, 1, 28, 19, 825, DateTimeKind.Local).AddTicks(6643) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movieId",
                keyValue: 3,
                columns: new[] { "CinemaId", "endDate", "startDate" },
                values: new object[] { 1, new DateTime(2024, 5, 25, 1, 28, 19, 825, DateTimeKind.Local).AddTicks(6652), new DateTime(2024, 4, 25, 1, 28, 19, 825, DateTimeKind.Local).AddTicks(6650) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movieId",
                keyValue: 4,
                columns: new[] { "CinemaId", "endDate", "startDate" },
                values: new object[] { 3, new DateTime(2024, 4, 25, 1, 28, 19, 825, DateTimeKind.Local).AddTicks(6659), new DateTime(2023, 11, 27, 1, 28, 19, 825, DateTimeKind.Local).AddTicks(6657) });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_CinemaId",
                table: "Movies",
                column: "CinemaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Cinemas_CinemaId",
                table: "Movies",
                column: "CinemaId",
                principalTable: "Cinemas",
                principalColumn: "cinemaId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Cinemas_CinemaId",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_CinemaId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "CinemaId",
                table: "Movies");

            migrationBuilder.CreateTable(
                name: "Cinemas_Movies",
                columns: table => new
                {
                    CinemaId = table.Column<int>(type: "int", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cinemas_Movies", x => new { x.CinemaId, x.MovieId });
                    table.ForeignKey(
                        name: "FK_Cinemas_Movies_Cinemas_CinemaId",
                        column: x => x.CinemaId,
                        principalTable: "Cinemas",
                        principalColumn: "cinemaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cinemas_Movies_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "movieId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cinemas_Movies",
                columns: new[] { "CinemaId", "MovieId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 3, 1 },
                    { 3, 2 },
                    { 3, 3 }
                });

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

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "movieId",
                keyValue: 4,
                columns: new[] { "endDate", "startDate" },
                values: new object[] { new DateTime(2024, 4, 24, 23, 54, 5, 51, DateTimeKind.Local).AddTicks(1135), new DateTime(2023, 11, 26, 23, 54, 5, 51, DateTimeKind.Local).AddTicks(1134) });

            migrationBuilder.CreateIndex(
                name: "IX_Cinemas_Movies_MovieId",
                table: "Cinemas_Movies",
                column: "MovieId");
        }
    }
}
