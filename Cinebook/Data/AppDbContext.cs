using Cinebook.Data.Enums;
using Cinebook.Models;
using Microsoft.EntityFrameworkCore;

namespace Cinebook.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Actor Movie One to Many
            modelBuilder.Entity<Actor_Movie>().HasKey(am => new
            {
                am.ActorId,
                am.MovieId
            });
            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Movie).WithMany(am => am.Actors_Movies).HasForeignKey(m => m.MovieId);
            modelBuilder.Entity<Actor_Movie>().HasOne(a => a.Actor).WithMany(am => am.Actors_Movies).HasForeignKey(a => a.ActorId);


            // Seeding
            modelBuilder.Entity<Actor>().HasData(
                    new Actor()
                    {
                        actorId = 1,
                        actorName = "Cillian Murphy",
                        actorPictureURL = "https://m.media-amazon.com/images/M/MV5BMDUxY2M1NTQtNzcwNC00ZDljLTk4YjctYzJjZGNiYTc0YTE1XkEyXkFqcGdeQXVyMTY5MDA5MDc3._V1_.jpg",
                        actorBio = "Cillian Murphy is an Irish Actor famous for his role in Peaky Blinders and Oppenheimer."
                    },
                    new Actor()
                    {
                        actorId = 2,
                        actorName = "Vicky Kaushal",
                        actorPictureURL = "https://m.media-amazon.com/images/M/MV5BNGY3Mjc3YmEtZjgwOS00Y2FkLTgzOTAtOTE3MzFhYWVlODgxXkEyXkFqcGdeQXVyMTUzNjEwNjM2._V1_FMjpg_UX1000_.jpg",
                        actorBio = "Vicky is an Indian Actor famous for his role in Uri: The Surgical Strike and Sam Bahadur."
                    },
                    new Actor()
                    {
                        actorId = 3,
                        actorName = "Allu Arjun",
                        actorPictureURL = "https://m.media-amazon.com/images/M/MV5BZGI4YTQ5ZmEtMzllOC00NjlhLTg2ODMtN2I0MzVkYWQzZDI5L2ltYWdlL2ltYWdlXkEyXkFqcGdeQXVyMTExNDQ2MTI@._V1_.jpg",
                        actorBio = "Allu Arjun is an Indian Actor who works in Telugu cinema famous for his role in Pushpa: The Rise."
                    }
                );

            modelBuilder.Entity<Producer>().HasData(
                    new Producer()
                    {
                        producerId = 1,
                        producerName = "Christopher Nolan",
                        producerPictureURL = "https://m.media-amazon.com/images/M/MV5BNjE3NDQyOTYyMV5BMl5BanBnXkFtZTcwODcyODU2Mw@@._V1_FMjpg_UX1000_.jpg",
                        producerBio = "Christopher is a British and American filmmaker known for his hollywood blockbusters and complex storytelling."
                    },
                    new Producer()
                    {
                        producerId = 2,
                        producerName = "Ronnie Screwvala",
                        producerPictureURL = "https://media.licdn.com/dms/image/C5603AQHadjWvyBiX5g/profile-displayphoto-shrink_800_800/0/1592130902477?e=2147483647&v=beta&t=gtZwZ8XguQLYuQanGqzkJdDh330xW2i1oivtRpF37SM",
                        producerBio = "Ronnie Screwvala is an Indian film producer who is the founder of RSVP production company."
                    },
                    new Producer()
                    {
                        producerId = 3,
                        producerName = "Sukumar",
                        producerPictureURL = "https://m.media-amazon.com/images/M/MV5BMTY5NzZmMmUtMzNlMS00MDdlLTg1ZTYtZjBkMWE1MDAwYjQ1XkEyXkFqcGdeQXVyMTE0MzQwMjgz._V1_QL75_UX500_CR0,0,500,281_.jpg",
                        producerBio = "Sukumar is an Indian film director and producer who works in Telugu cinema famous for Pushpa: The Rise."
                    }
                );

            modelBuilder.Entity<Cinema>().HasData(
                    new Cinema()
                    {
                        cinemaId = 1,
                        cinemaName = "Inox: VR Mall",
                        cinemaPictureURL = "https://mgcs.net.in/wp-content/uploads/2022/12/inox-header-logo-e1671447510797-removebg-preview.png",
                        cinemaAddress = "3rd Floor, VR Mall, Dumas Road, Magdalla, Near Sunglass Hut, Surat, Gujarat 395007, India"
                    },
                    new Cinema()
                    {
                        cinemaId = 2,
                        cinemaName = "Rajhans Flamingo",
                        cinemaPictureURL = "https://media.licdn.com/dms/image/C4E12AQFfOvHNsnX_8Q/article-cover_image-shrink_600_2000/0/1520054403600?e=2147483647&v=beta&t=VVHE6XoMtfIPbzsBUfyTSWuxvMK-jBcVWgNeQ6WWlfM",
                        cinemaAddress = "Rajhans Flamingo Mall, Ambatalavadi, Katargam, Surat, Gujarat 395004, India"
                    },
                    new Cinema()
                    {
                        cinemaId = 3,
                        cinemaName = "PVR: Rahul Raj Mall",
                        cinemaPictureURL = "https://zeevector.com/wp-content/uploads/LOGO/PVR-Cinemas-Logo-PNG-HD.jpg",
                        cinemaAddress = "3rd Floor, RahulRaj Mall, Dumas Road, Surat, Gujarat 395007, India"
                    }
                );

            modelBuilder.Entity<Movie>().HasData(
                    new Movie()
                    {
                        movieId = 1,
                        movieName = "Oppenheimer",
                        movieDescription = "Oppenheimer is a 2023 epic biographical thriller film which follows the life of J. Robert Oppenheimer, the American theoretical physicist who helped develop the first nuclear weapons during World War II.",
                        moviePictureURL = "https://m.media-amazon.com/images/M/MV5BMDBmYTZjNjUtN2M1MS00MTQ2LTk2ODgtNzc2M2QyZGE5NTVjXkEyXkFqcGdeQXVyNzAwMjU2MTY@._V1_FMjpg_UX1000_.jpg",
                        price = 250.00,
                        startDate = DateTime.Now.AddDays(-120),
                        endDate = DateTime.Now.AddDays(30),
                        ProducerId = 1,
                        movieCategory = MovieCategory.Thriller,
                        CinemaId = 2
                    },
                    new Movie()
                    {
                        movieId = 2,
                        movieName = "Sam Bahadur",
                        movieDescription = "Sam Bahadur is a 2023 Indian Hindi-language biographical war drama film based on the life of India's first field marshal, Sam Manekshaw.",
                        moviePictureURL = "https://m.media-amazon.com/images/M/MV5BMDBkMGRkMDQtMDFhZC00OWU5LWExZWMtYjBlZjEyYWMwNjI5XkEyXkFqcGdeQXVyMTU0ODI1NTA2._V1_.jpg",
                        price = 200.00,
                        startDate = DateTime.Now.AddDays(-30),
                        endDate = DateTime.Now.AddDays(30),
                        ProducerId = 2,
                        movieCategory = MovieCategory.Drama,
                        CinemaId = 3
                    },
                    new Movie()
                    {
                        movieId = 3,
                        movieName = "Pushpa: The Rule",
                        movieDescription = "Pushpa 2: The Rule is an upcoming Indian Telugu-language action drama film",
                        moviePictureURL = "https://m.media-amazon.com/images/M/MV5BNGZlNTFlOWMtMzUwNC00ZDdhLTk0MWUtOGZjYzFlOTBmNDdhXkEyXkFqcGdeQXVyMTUyNjIwMDEw._V1_.jpg",
                        price = 300.00,
                        startDate = DateTime.Now.AddDays(30),
                        endDate = DateTime.Now.AddDays(60),
                        ProducerId = 3,
                        movieCategory = MovieCategory.Action,
                        CinemaId = 1
                    },
					new Movie()
					{
						movieId = 4,
						movieName = "Oppenheimer",
						movieDescription = "Oppenheimer is a 2023 epic biographical thriller film which follows the life of J. Robert Oppenheimer, the American theoretical physicist who helped develop the first nuclear weapons during World War II.",
						moviePictureURL = "https://m.media-amazon.com/images/M/MV5BMDBmYTZjNjUtN2M1MS00MTQ2LTk2ODgtNzc2M2QyZGE5NTVjXkEyXkFqcGdeQXVyNzAwMjU2MTY@._V1_FMjpg_UX1000_.jpg",
						price = 250.00,
						startDate = DateTime.Now.AddDays(-120),
						endDate = DateTime.Now.AddDays(30),
						ProducerId = 1,
						movieCategory = MovieCategory.Thriller,
                        CinemaId = 3
					}

				);


            modelBuilder.Entity<Actor_Movie>().HasData(
                    new Actor_Movie()
                    {
                        MovieId = 1,
                        ActorId = 1
                    },
                    new Actor_Movie()
                    {
                        MovieId = 1,
                        ActorId = 2
                    },
                    new Actor_Movie()
                    {
                        MovieId = 1,
                        ActorId = 3
                    },
                    new Actor_Movie()
                    {
                        MovieId = 2,
                        ActorId = 1
                    },
                    new Actor_Movie()
                    {
                        MovieId = 2,
                        ActorId = 2
                    },
                    new Actor_Movie()
                    {
                        MovieId = 2,
                        ActorId = 3
                    },
                    new Actor_Movie()
                    {
                        MovieId = 3,
                        ActorId = 1
                    },
                    new Actor_Movie()
                    {
                        MovieId = 3,
                        ActorId = 2
                    },
                    new Actor_Movie()
                    {
                        MovieId = 3,
                        ActorId = 3
                    }
                );


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor_Movie> Actors_Movies { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Producer> Producers { get; set; }
    }
}
