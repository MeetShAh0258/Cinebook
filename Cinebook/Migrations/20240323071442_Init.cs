using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cinebook.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    actorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    actorPictureURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    actorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    actorBio = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.actorId);
                });

            migrationBuilder.CreateTable(
                name: "Cinemas",
                columns: table => new
                {
                    cinemaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cinemaPictureURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cinemaName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cinemaAddress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cinemas", x => x.cinemaId);
                });

            migrationBuilder.CreateTable(
                name: "Producers",
                columns: table => new
                {
                    producerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    producerPictureURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    producerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    producerBio = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producers", x => x.producerId);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    movieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    moviePictureURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    movieName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    movieDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<double>(type: "float", nullable: false),
                    startDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    endDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    movieCategory = table.Column<int>(type: "int", nullable: false),
                    ProducerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.movieId);
                    table.ForeignKey(
                        name: "FK_Movies_Producers_ProducerId",
                        column: x => x.ProducerId,
                        principalTable: "Producers",
                        principalColumn: "producerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Actors_Movies",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    ActorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors_Movies", x => new { x.ActorId, x.MovieId });
                    table.ForeignKey(
                        name: "FK_Actors_Movies_Actors_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actors",
                        principalColumn: "actorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Actors_Movies_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "movieId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cinemas_Movies",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    CinemaId = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_Actors_Movies_MovieId",
                table: "Actors_Movies",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Cinemas_Movies_MovieId",
                table: "Cinemas_Movies",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_ProducerId",
                table: "Movies",
                column: "ProducerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Actors_Movies");

            migrationBuilder.DropTable(
                name: "Cinemas_Movies");

            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.DropTable(
                name: "Cinemas");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Producers");
        }
    }
}
