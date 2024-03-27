using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cinebook.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "actorId", "actorBio", "actorName", "actorPictureURL" },
                values: new object[,]
                {
                    { 1, "Cillian Murphy is an Irish Actor famous for his role in Peaky Blinders and Oppenheimer.", "Cillian Murphy", "https://m.media-amazon.com/images/M/MV5BMDUxY2M1NTQtNzcwNC00ZDljLTk4YjctYzJjZGNiYTc0YTE1XkEyXkFqcGdeQXVyMTY5MDA5MDc3._V1_.jpg" },
                    { 2, "Vicky is an Indian Actor famous for his role in Uri: The Surgical Strike and Sam Bahadur.", "Vicky Kaushal", "https://m.media-amazon.com/images/M/MV5BNGY3Mjc3YmEtZjgwOS00Y2FkLTgzOTAtOTE3MzFhYWVlODgxXkEyXkFqcGdeQXVyMTUzNjEwNjM2._V1_FMjpg_UX1000_.jpg" },
                    { 3, "Allu Arjun is an Indian Actor who works in Telugu cinema famous for his role in Pushpa: The Rise.", "Allu Arjun", "https://m.media-amazon.com/images/M/MV5BZGI4YTQ5ZmEtMzllOC00NjlhLTg2ODMtN2I0MzVkYWQzZDI5L2ltYWdlL2ltYWdlXkEyXkFqcGdeQXVyMTExNDQ2MTI@._V1_.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Cinemas",
                columns: new[] { "cinemaId", "cinemaAddress", "cinemaName", "cinemaPictureURL" },
                values: new object[,]
                {
                    { 1, "3rd Floor, VR Mall, Dumas Road, Magdalla, Near Sunglass Hut, Surat, Gujarat 395007, India", "Inox: VR Mall", "https://m.media-amazon.com/images/M/MV5BNjE3NDQyOTYyMV5BMl5BanBnXkFtZTcwODcyODU2Mw@@._V1_FMjpg_UX1000_.jpg" },
                    { 2, "Rajhans Flamingo Mall, Ambatalavadi, Katargam, Surat, Gujarat 395004, India", "Rajhans Flamingo", "https://media.licdn.com/dms/image/C5603AQHadjWvyBiX5g/profile-displayphoto-shrink_800_800/0/1592130902477?e=2147483647&v=beta&t=gtZwZ8XguQLYuQanGqzkJdDh330xW2i1oivtRpF37SM" },
                    { 3, "3rd Floor, RahulRaj Mall, Dumas Road, Surat, Gujarat 395007, India", "PVR: Rahul Raj Mall", "https://m.media-amazon.com/images/M/MV5BMTY5NzZmMmUtMzNlMS00MDdlLTg1ZTYtZjBkMWE1MDAwYjQ1XkEyXkFqcGdeQXVyMTE0MzQwMjgz._V1_QL75_UX500_CR0,0,500,281_.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Producers",
                columns: new[] { "producerId", "producerBio", "producerName", "producerPictureURL" },
                values: new object[,]
                {
                    { 1, "Christopher is a British and American filmmaker known for his hollywood blockbusters and complex storytelling.", "Christopher Nolan", "https://m.media-amazon.com/images/M/MV5BNjE3NDQyOTYyMV5BMl5BanBnXkFtZTcwODcyODU2Mw@@._V1_FMjpg_UX1000_.jpg" },
                    { 2, "Ronnie Screwvala is an Indian film producer who is the founder of RSVP production company.", "Ronnie Screwvala", "https://media.licdn.com/dms/image/C5603AQHadjWvyBiX5g/profile-displayphoto-shrink_800_800/0/1592130902477?e=2147483647&v=beta&t=gtZwZ8XguQLYuQanGqzkJdDh330xW2i1oivtRpF37SM" },
                    { 3, "Sukumar is an Indian film director and producer who works in Telugu cinema famous for Pushpa: The Rise.", "Sukumar", "https://m.media-amazon.com/images/M/MV5BMTY5NzZmMmUtMzNlMS00MDdlLTg1ZTYtZjBkMWE1MDAwYjQ1XkEyXkFqcGdeQXVyMTE0MzQwMjgz._V1_QL75_UX500_CR0,0,500,281_.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "movieId", "ProducerId", "endDate", "movieCategory", "movieDescription", "movieName", "moviePictureURL", "price", "startDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 4, 22, 15, 46, 51, 98, DateTimeKind.Local).AddTicks(1488), 5, "Oppenheimer is a 2023 epic biographical thriller film which follows the life of J. Robert Oppenheimer, the American theoretical physicist who helped develop the first nuclear weapons during World War II.", "Oppenheimer", "https://m.media-amazon.com/images/M/MV5BMDBmYTZjNjUtN2M1MS00MTQ2LTk2ODgtNzc2M2QyZGE5NTVjXkEyXkFqcGdeQXVyNzAwMjU2MTY@._V1_FMjpg_UX1000_.jpg", 250.0, new DateTime(2023, 11, 24, 15, 46, 51, 98, DateTimeKind.Local).AddTicks(1465) },
                    { 2, 2, new DateTime(2024, 4, 22, 15, 46, 51, 98, DateTimeKind.Local).AddTicks(1495), 2, "Sam Bahadur is a 2023 Indian Hindi-language biographical war drama film based on the life of India's first field marshal, Sam Manekshaw.", "Sam Bahadur", "https://m.media-amazon.com/images/M/MV5BMDBkMGRkMDQtMDFhZC00OWU5LWExZWMtYjBlZjEyYWMwNjI5XkEyXkFqcGdeQXVyMTU0ODI1NTA2._V1_.jpg", 200.0, new DateTime(2024, 2, 22, 15, 46, 51, 98, DateTimeKind.Local).AddTicks(1494) },
                    { 3, 3, new DateTime(2024, 5, 22, 15, 46, 51, 98, DateTimeKind.Local).AddTicks(1501), 1, "Pushpa 2: The Rule is an upcoming Indian Telugu-language action drama film", "Pushpa: The Rule", "https://m.media-amazon.com/images/M/MV5BNGZlNTFlOWMtMzUwNC00ZDdhLTk0MWUtOGZjYzFlOTBmNDdhXkEyXkFqcGdeQXVyMTUyNjIwMDEw._V1_.jpg", 300.0, new DateTime(2024, 4, 22, 15, 46, 51, 98, DateTimeKind.Local).AddTicks(1500) }
                });

            migrationBuilder.InsertData(
                table: "Actors_Movies",
                columns: new[] { "ActorId", "MovieId" },
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "Actors_Movies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "Cinemas_Movies",
                keyColumns: new[] { "CinemaId", "MovieId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Cinemas_Movies",
                keyColumns: new[] { "CinemaId", "MovieId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "Cinemas_Movies",
                keyColumns: new[] { "CinemaId", "MovieId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "Cinemas_Movies",
                keyColumns: new[] { "CinemaId", "MovieId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "Cinemas_Movies",
                keyColumns: new[] { "CinemaId", "MovieId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "Cinemas_Movies",
                keyColumns: new[] { "CinemaId", "MovieId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "Cinemas_Movies",
                keyColumns: new[] { "CinemaId", "MovieId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "Cinemas_Movies",
                keyColumns: new[] { "CinemaId", "MovieId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "Cinemas_Movies",
                keyColumns: new[] { "CinemaId", "MovieId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "actorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "actorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "actorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "cinemaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "cinemaId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "cinemaId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "movieId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "movieId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "movieId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "producerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "producerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "producerId",
                keyValue: 3);
        }
    }
}
