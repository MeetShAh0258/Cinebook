﻿// <auto-generated />
using System;
using Cinebook.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Cinebook.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240325182405_Fourth")]
    partial class Fourth
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Cinebook.Models.Actor", b =>
                {
                    b.Property<int>("actorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("actorId"));

                    b.Property<string>("actorBio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("actorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("actorPictureURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("actorId");

                    b.ToTable("Actors");

                    b.HasData(
                        new
                        {
                            actorId = 1,
                            actorBio = "Cillian Murphy is an Irish Actor famous for his role in Peaky Blinders and Oppenheimer.",
                            actorName = "Cillian Murphy",
                            actorPictureURL = "https://m.media-amazon.com/images/M/MV5BMDUxY2M1NTQtNzcwNC00ZDljLTk4YjctYzJjZGNiYTc0YTE1XkEyXkFqcGdeQXVyMTY5MDA5MDc3._V1_.jpg"
                        },
                        new
                        {
                            actorId = 2,
                            actorBio = "Vicky is an Indian Actor famous for his role in Uri: The Surgical Strike and Sam Bahadur.",
                            actorName = "Vicky Kaushal",
                            actorPictureURL = "https://m.media-amazon.com/images/M/MV5BNGY3Mjc3YmEtZjgwOS00Y2FkLTgzOTAtOTE3MzFhYWVlODgxXkEyXkFqcGdeQXVyMTUzNjEwNjM2._V1_FMjpg_UX1000_.jpg"
                        },
                        new
                        {
                            actorId = 3,
                            actorBio = "Allu Arjun is an Indian Actor who works in Telugu cinema famous for his role in Pushpa: The Rise.",
                            actorName = "Allu Arjun",
                            actorPictureURL = "https://m.media-amazon.com/images/M/MV5BZGI4YTQ5ZmEtMzllOC00NjlhLTg2ODMtN2I0MzVkYWQzZDI5L2ltYWdlL2ltYWdlXkEyXkFqcGdeQXVyMTExNDQ2MTI@._V1_.jpg"
                        });
                });

            modelBuilder.Entity("Cinebook.Models.Actor_Movie", b =>
                {
                    b.Property<int>("ActorId")
                        .HasColumnType("int");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.HasKey("ActorId", "MovieId");

                    b.HasIndex("MovieId");

                    b.ToTable("Actors_Movies");

                    b.HasData(
                        new
                        {
                            ActorId = 1,
                            MovieId = 1
                        },
                        new
                        {
                            ActorId = 2,
                            MovieId = 1
                        },
                        new
                        {
                            ActorId = 3,
                            MovieId = 1
                        },
                        new
                        {
                            ActorId = 1,
                            MovieId = 2
                        },
                        new
                        {
                            ActorId = 2,
                            MovieId = 2
                        },
                        new
                        {
                            ActorId = 3,
                            MovieId = 2
                        },
                        new
                        {
                            ActorId = 1,
                            MovieId = 3
                        },
                        new
                        {
                            ActorId = 2,
                            MovieId = 3
                        },
                        new
                        {
                            ActorId = 3,
                            MovieId = 3
                        });
                });

            modelBuilder.Entity("Cinebook.Models.Cinema", b =>
                {
                    b.Property<int>("cinemaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("cinemaId"));

                    b.Property<string>("cinemaAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cinemaName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cinemaPictureURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("cinemaId");

                    b.ToTable("Cinemas");

                    b.HasData(
                        new
                        {
                            cinemaId = 1,
                            cinemaAddress = "3rd Floor, VR Mall, Dumas Road, Magdalla, Near Sunglass Hut, Surat, Gujarat 395007, India",
                            cinemaName = "Inox: VR Mall",
                            cinemaPictureURL = "https://mgcs.net.in/wp-content/uploads/2022/12/inox-header-logo-e1671447510797-removebg-preview.png"
                        },
                        new
                        {
                            cinemaId = 2,
                            cinemaAddress = "Rajhans Flamingo Mall, Ambatalavadi, Katargam, Surat, Gujarat 395004, India",
                            cinemaName = "Rajhans Flamingo",
                            cinemaPictureURL = "https://media.licdn.com/dms/image/C4E12AQFfOvHNsnX_8Q/article-cover_image-shrink_600_2000/0/1520054403600?e=2147483647&v=beta&t=VVHE6XoMtfIPbzsBUfyTSWuxvMK-jBcVWgNeQ6WWlfM"
                        },
                        new
                        {
                            cinemaId = 3,
                            cinemaAddress = "3rd Floor, RahulRaj Mall, Dumas Road, Surat, Gujarat 395007, India",
                            cinemaName = "PVR: Rahul Raj Mall",
                            cinemaPictureURL = "https://zeevector.com/wp-content/uploads/LOGO/PVR-Cinemas-Logo-PNG-HD.jpg"
                        });
                });

            modelBuilder.Entity("Cinebook.Models.Cinema_Movie", b =>
                {
                    b.Property<int>("CinemaId")
                        .HasColumnType("int");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.HasKey("CinemaId", "MovieId");

                    b.HasIndex("MovieId");

                    b.ToTable("Cinemas_Movies");

                    b.HasData(
                        new
                        {
                            CinemaId = 1,
                            MovieId = 1
                        },
                        new
                        {
                            CinemaId = 2,
                            MovieId = 1
                        },
                        new
                        {
                            CinemaId = 3,
                            MovieId = 1
                        },
                        new
                        {
                            CinemaId = 1,
                            MovieId = 2
                        },
                        new
                        {
                            CinemaId = 2,
                            MovieId = 2
                        },
                        new
                        {
                            CinemaId = 3,
                            MovieId = 2
                        },
                        new
                        {
                            CinemaId = 1,
                            MovieId = 3
                        },
                        new
                        {
                            CinemaId = 2,
                            MovieId = 3
                        },
                        new
                        {
                            CinemaId = 3,
                            MovieId = 3
                        });
                });

            modelBuilder.Entity("Cinebook.Models.Movie", b =>
                {
                    b.Property<int>("movieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("movieId"));

                    b.Property<int>("ProducerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("endDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("movieCategory")
                        .HasColumnType("int");

                    b.Property<string>("movieDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("movieName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("moviePictureURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("price")
                        .HasColumnType("float");

                    b.Property<DateTime>("startDate")
                        .HasColumnType("datetime2");

                    b.HasKey("movieId");

                    b.HasIndex("ProducerId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            movieId = 1,
                            ProducerId = 1,
                            endDate = new DateTime(2024, 4, 24, 23, 54, 5, 51, DateTimeKind.Local).AddTicks(1116),
                            movieCategory = 5,
                            movieDescription = "Oppenheimer is a 2023 epic biographical thriller film which follows the life of J. Robert Oppenheimer, the American theoretical physicist who helped develop the first nuclear weapons during World War II.",
                            movieName = "Oppenheimer",
                            moviePictureURL = "https://m.media-amazon.com/images/M/MV5BMDBmYTZjNjUtN2M1MS00MTQ2LTk2ODgtNzc2M2QyZGE5NTVjXkEyXkFqcGdeQXVyNzAwMjU2MTY@._V1_FMjpg_UX1000_.jpg",
                            price = 250.0,
                            startDate = new DateTime(2023, 11, 26, 23, 54, 5, 51, DateTimeKind.Local).AddTicks(1094)
                        },
                        new
                        {
                            movieId = 2,
                            ProducerId = 2,
                            endDate = new DateTime(2024, 4, 24, 23, 54, 5, 51, DateTimeKind.Local).AddTicks(1123),
                            movieCategory = 2,
                            movieDescription = "Sam Bahadur is a 2023 Indian Hindi-language biographical war drama film based on the life of India's first field marshal, Sam Manekshaw.",
                            movieName = "Sam Bahadur",
                            moviePictureURL = "https://m.media-amazon.com/images/M/MV5BMDBkMGRkMDQtMDFhZC00OWU5LWExZWMtYjBlZjEyYWMwNjI5XkEyXkFqcGdeQXVyMTU0ODI1NTA2._V1_.jpg",
                            price = 200.0,
                            startDate = new DateTime(2024, 2, 24, 23, 54, 5, 51, DateTimeKind.Local).AddTicks(1122)
                        },
                        new
                        {
                            movieId = 3,
                            ProducerId = 3,
                            endDate = new DateTime(2024, 5, 24, 23, 54, 5, 51, DateTimeKind.Local).AddTicks(1130),
                            movieCategory = 1,
                            movieDescription = "Pushpa 2: The Rule is an upcoming Indian Telugu-language action drama film",
                            movieName = "Pushpa: The Rule",
                            moviePictureURL = "https://m.media-amazon.com/images/M/MV5BNGZlNTFlOWMtMzUwNC00ZDdhLTk0MWUtOGZjYzFlOTBmNDdhXkEyXkFqcGdeQXVyMTUyNjIwMDEw._V1_.jpg",
                            price = 300.0,
                            startDate = new DateTime(2024, 4, 24, 23, 54, 5, 51, DateTimeKind.Local).AddTicks(1128)
                        },
                        new
                        {
                            movieId = 4,
                            ProducerId = 1,
                            endDate = new DateTime(2024, 4, 24, 23, 54, 5, 51, DateTimeKind.Local).AddTicks(1135),
                            movieCategory = 5,
                            movieDescription = "Oppenheimer is a 2023 epic biographical thriller film which follows the life of J. Robert Oppenheimer, the American theoretical physicist who helped develop the first nuclear weapons during World War II.",
                            movieName = "Oppenheimer",
                            moviePictureURL = "https://m.media-amazon.com/images/M/MV5BMDBmYTZjNjUtN2M1MS00MTQ2LTk2ODgtNzc2M2QyZGE5NTVjXkEyXkFqcGdeQXVyNzAwMjU2MTY@._V1_FMjpg_UX1000_.jpg",
                            price = 250.0,
                            startDate = new DateTime(2023, 11, 26, 23, 54, 5, 51, DateTimeKind.Local).AddTicks(1134)
                        });
                });

            modelBuilder.Entity("Cinebook.Models.Producer", b =>
                {
                    b.Property<int>("producerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("producerId"));

                    b.Property<string>("producerBio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("producerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("producerPictureURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("producerId");

                    b.ToTable("Producers");

                    b.HasData(
                        new
                        {
                            producerId = 1,
                            producerBio = "Christopher is a British and American filmmaker known for his hollywood blockbusters and complex storytelling.",
                            producerName = "Christopher Nolan",
                            producerPictureURL = "https://m.media-amazon.com/images/M/MV5BNjE3NDQyOTYyMV5BMl5BanBnXkFtZTcwODcyODU2Mw@@._V1_FMjpg_UX1000_.jpg"
                        },
                        new
                        {
                            producerId = 2,
                            producerBio = "Ronnie Screwvala is an Indian film producer who is the founder of RSVP production company.",
                            producerName = "Ronnie Screwvala",
                            producerPictureURL = "https://media.licdn.com/dms/image/C5603AQHadjWvyBiX5g/profile-displayphoto-shrink_800_800/0/1592130902477?e=2147483647&v=beta&t=gtZwZ8XguQLYuQanGqzkJdDh330xW2i1oivtRpF37SM"
                        },
                        new
                        {
                            producerId = 3,
                            producerBio = "Sukumar is an Indian film director and producer who works in Telugu cinema famous for Pushpa: The Rise.",
                            producerName = "Sukumar",
                            producerPictureURL = "https://m.media-amazon.com/images/M/MV5BMTY5NzZmMmUtMzNlMS00MDdlLTg1ZTYtZjBkMWE1MDAwYjQ1XkEyXkFqcGdeQXVyMTE0MzQwMjgz._V1_QL75_UX500_CR0,0,500,281_.jpg"
                        });
                });

            modelBuilder.Entity("Cinebook.Models.Actor_Movie", b =>
                {
                    b.HasOne("Cinebook.Models.Actor", "Actor")
                        .WithMany("Actors_Movies")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cinebook.Models.Movie", "Movie")
                        .WithMany("Actors_Movies")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("Cinebook.Models.Cinema_Movie", b =>
                {
                    b.HasOne("Cinebook.Models.Cinema", "Cinema")
                        .WithMany("Cinemas_Movies")
                        .HasForeignKey("CinemaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cinebook.Models.Movie", "Movie")
                        .WithMany("Cinemas_Movies")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cinema");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("Cinebook.Models.Movie", b =>
                {
                    b.HasOne("Cinebook.Models.Producer", "Producer")
                        .WithMany("Movies")
                        .HasForeignKey("ProducerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Producer");
                });

            modelBuilder.Entity("Cinebook.Models.Actor", b =>
                {
                    b.Navigation("Actors_Movies");
                });

            modelBuilder.Entity("Cinebook.Models.Cinema", b =>
                {
                    b.Navigation("Cinemas_Movies");
                });

            modelBuilder.Entity("Cinebook.Models.Movie", b =>
                {
                    b.Navigation("Actors_Movies");

                    b.Navigation("Cinemas_Movies");
                });

            modelBuilder.Entity("Cinebook.Models.Producer", b =>
                {
                    b.Navigation("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}
