using eTickets.Data.Static;
using eTickets.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Majestic Cinema",
                            Logo = "https://scontent.fcmb2-2.fna.fbcdn.net/v/t39.30808-6/327181131_1351453118971555_5515142343270586725_n.png?_nc_cat=103&ccb=1-7&_nc_sid=efb6e6&_nc_eui2=AeGW8HnuTH0gzJe0WKLLXJcVL9_qrb-nSFEv3-qtv6dIUWj8J9smUsLZyEV_mnW326qi9WGBYNrClYLBYbkPhFci&_nc_ohc=4ZaZiSFwQm4AX-XmppV&_nc_oc=AQlhqVl_E4xwjhaPuG4ig9bI0kFh0sdbr8LiotjRzNmvkke1UpWGRl7pjXYx1v6xue4&_nc_ht=scontent.fcmb2-2.fna&oh=00_AfDaFTJE7TBPX_0r9-rLc6DBhLn5RLDy2iX4bdOPmPT4cQ&oe=65E744FC",
                            Description = "The premier cineplex of Colombo; a property of Ceylon Theatres"
                        },
                        new Cinema()
                        {
                            Name = "Liberty by Scope Cinemas",
                            Logo = "https://www.scopecinemas.com/img/Og-image-Logo.png",
                            Description = "The Most Surreal Cinematic Experience in Sri Lanka."
                        },
                        new Cinema()
                        {
                            Name = "Savoy 3D Cinema",
                            Logo = "https://images.savoysystems.co.uk/SCG/4959906.jpg",
                            Description = "Savoy Cinema is well equipped with the latest movie technology can accommodate 150 GOLD CLASS, 497ODC and 8 Box seats that can seat two per Box"
                        },
                        new Cinema()
                        {
                            Name = "PVR cinema",
                            Logo = "https://www.independent.lk/wp-content/uploads/2017/12/hqdefault-1.jpg",
                            Description = "PVR CINEMAS is the largest and Most Admired Multiplex Chain in India & is now open at Colombo"
                        },
                        new Cinema()
                        {
                            Name = "Sky Lite 3D Cinema: Matara",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                            Description = "Sky Lite 3D Cinema is the First & Only 3D Cinema in Southern Province"
                        },
                    });
                    context.SaveChanges();
                }
                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Jayalath Manoratne",
                            Bio = "Keselgaspe Manatunga Jayalath Manoratne (Sinhala: කෙසෙල්ගස්පේ මනතුංග ජයලත් මනෝරත්න; 12 June 1948 – 12 January 2020) was an actor in Sri Lankan cinema, stage drama and television.[1] He was a lecturer by profession as well as a director and producer. A highly versatile actor from drama to comedy, Manoratne won awards at OCIC (International Catholic Organization for Cinema and Audiovisual), Presidential, Sarasaviya, Raigam Tele'es, Sumathi and the State Literary and Drama festivals. He was the best actor back to back in 1991 and 1992 for his performance in Socrates and Dvitva.[2] He is considered by critics as one of the five actors who have dominated the Sri Lankan Stage.[3] He died on 12 January 2020 while receiving treatment for cancer at the age of 71.",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/32/Jayalath-manorathna.jpg/330px-Jayalath-manorathna.jpg"

                        },
                        new Actor()
                        {
                            FullName = "Mahendra Perera",
                            Bio = "Mahendra Shrikantha Perera (born 17 August 1956: Sinhala: මහේන්ද්‍ර පෙරේරා), is an actor in Sri Lankan cinema, stage drama and television. One of the most influential actors in Sinhala cinema, Mahendra performed from drama to comedy in many blockbuster films.",
                            ProfilePictureURL = "https://images.mubicdn.net/images/cast_member/92656/cache-234602-1498731533/image-w856.jpg?size=800x"
                        },
                        new Actor()
                        {
                            FullName = "Anarkali Akarsha",
                            Bio = "Anarkali Akarsha (Sinhala: අනර්කලී ආකර්ෂා;born 12 July 1987 as Anarkali Janina Jayatilaka) is a Sri Lankan actress, model, former politician and beauty pageant titleholder. She was crowned Miss Sri Lanka 2004 and represented Sri Lanka at the Miss World 2004 beauty pageant. She has worked as a brand ambassador & a fundraiser. She attended Colombo International School.",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/c/ce/Anarkali_Ak.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Giriraj Kaushalya",
                            Bio = "Silmesthri Giriraj Kaushalya (born November 13, 1964) (Sinhala: ගිරිරාජ් කෞශල්‍ය), popularly known as Giriraj Kaushalya, is a Sri Lankan actor in Sri Lankan cinema, stage drama and television. Highly versatile actor from drama to comedy, Kaushalya also has worked as an assistant director, producer, script writer and a filmmaker",
                            ProfilePictureURL = "https://island.lk/wp-content/uploads/2021/12/giriraj-500x600.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Ranjan Ramanayake",
                            Bio = "Sadda Vidda Rajapakse Palanga Pathira Ambakumarage Ranjan Leo Sylvester Alphonsu (born 11 March 1963) (රන්ජන් රාමනායක), popularly known as Ranjan Ramanayake, is a former Sri Lankan politician, actor, film director, singer and script writer who appeared in a number of Sinhala language films. He is a former Member of the Parliament.",
                            ProfilePictureURL = "https://www.newscutter.lk/wp-content/uploads/2022/10/312493449_666507408170212_3877120769385692260_n.jpg"
                        }
                    });
                    context.SaveChanges();
                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Giriraj Kaushalya",
                            Bio = "Silmesthri Giriraj Kaushalya (born November 13, 1964) (Sinhala: ගිරිරාජ් කෞශල්‍ය), popularly known as Giriraj Kaushalya, is a Sri Lankan actor in Sri Lankan cinema, stage drama and television. Highly versatile actor from drama to comedy, Kaushalya also has worked as an assistant director, producer, script writer and a filmmaker",
                            ProfilePictureURL = "https://island.lk/wp-content/uploads/2021/12/giriraj-500x600.jpg"

                        },
                        new Producer()
                        {
                            FullName = "Soma Edirisinghe",
                            Bio = "Soma Edirisinghe (Sinhala: සෝමා එදිරිසිංහ; 5 July 1939 – 5 November 2015) was a Sri Lankan corporate executive, film producer, philanthropist and social worker. She was born in Meegoda, Sri Lanka ",
                            ProfilePictureURL = "https://img4.bdbphotos.com/images/230x300/i/v/iv07l2jow3mj3omw.jpg?skj2io4l"
                        },
                        new Producer()
                        {
                            FullName = "Sunil Thompson Fernando",
                            Bio = "Sunil T. Fernando was born on 21 December 1960 in Colombo, Sri Lanka. He is a producer and writer, known for Ko Hathuro (1988), Akkayi Nangi (1998) and Kama Sutra (2002).",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-3.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Renuka Balasooriya",
                            Bio = "Renuka Balasooriya is known for Siri Raja Siri (2008), Samanala Thatu (2006) and Wherever (2013).",
                            ProfilePictureURL = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcRjguBJ8uYyYLNjgMRxZ8nmtrDwdoTp3Exq1gRJsbJFNoanjyrM"
                        },
                        new Producer()
                        {
                            FullName = "Susara Dinal Silva",
                            Bio = "Susara Dinal Silva · CEO at MTV Channel (Pvt) Ltd · Works at Attorney at Law · Studied Law at Sri Lanka Law College",
                            ProfilePictureURL = "https://media.licdn.com/dms/image/C5603AQHiSBijJ9MMXw/profile-displayphoto-shrink_800_800/0/1627969971185?e=2147483647&v=beta&t=11rw8qseI_9OKEoiZFLgvYhP3sl_pjCXZOdcjy-xXAk"
                        }
                    });
                    context.SaveChanges();
                }
                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Kathuru Mithuru",
                            Description = "Kathuru Mithuru directed by Giriraj Kaushalya tells the tale of a friendship developed between a tailor and barber over a common tool.",
                            Price = 700,
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BY2Y3YTkxMDEtNDNmMS00MGFlLThlNjItYTFmN2ExYWRmZWUwXkEyXkFqcGdeQXVyNDMwOTc5MDg@._V1_.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId = 1,
                            ProducerId = 1,
                            MovieCategory = MovieCategory.Comedy
                        },
                        new Movie()
                        {
                            Name = "Sooriya Arana",
                            Description = "A secret friendship is developed between the two boys, a young disciple and a son of a hunter in a remote village.",
                            Price = 600,
                            ImageURL = "https://www.peotv.com/static/images/movies/movie-poster/sin_p_SooriyaArana.jpg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            CinemaId = 2,
                            ProducerId = 4,
                            MovieCategory = MovieCategory.Drama
                        },
                        new Movie()
                        {
                            Name = "Ho Gana Pokuna",
                            Description = "One day, a new teacher, Uma, arrives at a primary school in a remote little village in Sri Lanka. With Uma's help, her little pupils learn not to be afraid of dreaming big.",
                            Price = 650,
                            ImageURL = "https://upload.wikimedia.org/wikipedia/en/6/63/Ho_Gana_Pokuna_official_poster.jpg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaId = 3,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.Drama
                        },
                        new Movie()
                        {
                            Name = "Ranja",
                            Description = "Ranja (Sinhala: රන්ජා) is a 2014 Sri Lankan Sinhala action thriller film directed by Sudesh Wasantha Peiris and produced by Sunil T. Fernando",
                            Price = 550,
                            ImageURL = "https://images.hungama.com/c/1/efb/c7a/18227274/18227274_180x255.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(5),
                            CinemaId = 4,
                            ProducerId = 4,
                            MovieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "A Level",
                            Description = "After getting through the O/L Examination with outstanding results, Anuththara with his friends eagerly look forward to experience their final years in school ",
                            Price = 750,
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BZGEwMWNmODktMDcxNy00OTAwLTg4NmMtMDFlMDAxMmU2NjFkXkEyXkFqcGdeQXVyNDMwOTc5MDg@._V1_.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(2),
                            CinemaId = 5,
                            ProducerId = 5,
                            MovieCategory = MovieCategory.Cartoon
                        },
                        new Movie()
                        {
                            Name = "Sikuru Hathe",
                            Description = "A story about a Sri Lankan Matchmaker trying to find a partner for his own daughter.",
                            Price = 700,
                            ImageURL = "https://upload.wikimedia.org/wikipedia/en/e/e7/Sikuru_Hathe_sinhala_film_DVD_poster.jpg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Comedy
                        }
                    });
                    context.SaveChanges();
                }
                //Actors & Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 1
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 1
                        },

                         new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 2
                        },
                         new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 2
                        },

                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 3
                        },


                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 4
                        },


                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 5
                        },


                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 6
                        },
                    });
                    context.SaveChanges();
                }
            }

        }

        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {

                //Roles
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

                //Users
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                string adminUserEmail = "admin@etickets.com";

                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if(adminUser == null)
                {
                    var newAdminUser = new ApplicationUser()
                    {
                        FullName = "Admin User",
                        UserName = "admin-user",
                        Email = adminUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAdminUser, "Vinoo@1234");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }


                string appUserEmail = "vinoo@etickets.com";

                var appUser = await userManager.FindByEmailAsync(appUserEmail);
                if (appUser == null)
                {
                    var newAppUser = new ApplicationUser()
                    {
                        FullName = "Vinodi Nikeshani",
                        UserName = "Vinodi",
                        Email = appUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAppUser, "Vinoo@1234");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                }
            }
        }
    }
}
