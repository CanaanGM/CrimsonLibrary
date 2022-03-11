using CrimsonLibrary.Data.DataAccess;
using CrimsonLibrary.Data.Models.Domain;

using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;
using CrimsonLibrary.Data.Models.JoinTables;

namespace CrimsonLibrary.Data.ModelHelpers
{
    public static class Seed
    {
        public static async Task SeedData(DatabaseContext context)
        {
            if (
               !context.Animes.Any() &&
               !context.Books.Any() &&
               !context.Games.Any() &&
               !context.BoughtItems.Any() &&
               !context.Exercises.Any() &&
               !context.MusicTracks.Any() &&
               !context.BodyBuildingWorkouts.Any() &&
               !context.Mangas.Any()
               )
            {
                var Books = new List<Book>{
                new Book
                {
                    Id = new Guid(),
                    Name = "Horus Rising",
                    Description = "Horus rises",
                    CoverImage = "NONE",
                    Genre = "Science fiction",
                    Authors = "Dan Abbnet",
                    Rating = 8.9F,
                    IsRead = true,
                    Consumed = new DateTime(2013,07,13),
                    DatePublished =new DateTime(2006,04,25),

                },
                    new Book
                    {
                        Id = new Guid(),
                        Name = "Fulgrim",
                        Description = "Fulgrim",
                        CoverImage = "NONE",
                        Genre = "Science fiction",
                        Authors = "Dan Abbnet",
                        Rating = 9.5F,
                        IsRead = true,
                        Consumed = new DateTime(2013, 08, 13),
                        DatePublished = new DateTime(2007, 07, 02),

                    },
                    new Book
                    {
                        Id = new Guid(),
                        Name = "The Lord of the Rings",
                        Description = "epic journey",
                        CoverImage = "NONE",
                        Authors = "J.R.R Tolkin",
                        Genre = "Fiction",
                        Rating = 0F,
                        IsRead = false,
                        DatePublished = new DateTime(1954, 07, 29)

                    },

                };

                await context.Books.AddRangeAsync(Books);

                var Anime = new List<Anime> {

                new Anime{
                    Id = new Guid(),
                    Name ="Canaan",
                    Description =  "Canaan and stuff",
                    CoverImage = "None",
                    Genre ="Action",
                    SubGenres = "Action, Comedy",
                    Rating  = 9,
                    IsWatched  = true,
                    Consumed = new DateTime(2011,09,14),
                    DatePublished = new DateTime(2009,07,04)
                },

                new Anime{
                    Id = new Guid(),
                    Name ="Log Horizon",
                    Description =  "Databse Database oo ooh~!",
                    CoverImage = "None",
                    Genre ="Action",
                    SubGenres = "Action, Comedy",
                    Rating  = 9,
                    IsWatched  = true,
                    Consumed = new DateTime(2013,10,05),
                    DatePublished = new DateTime(2013,10,05)
                },

                new Anime{
                    Id = new Guid(),
                    Name ="Hellsing",
                    Description =  "Canaan and stuff",
                    CoverImage = "空",
                    Genre ="Action",
                    SubGenres = "Action, Comedy",
                    Rating  = 9,
                    IsWatched  = false,
                    Consumed = new DateTime(2014,09,14),
                    DatePublished = new DateTime(2001,10,10)
                }

            };
                await context.Animes.AddRangeAsync(Anime);


                var Manga = new List<Manga>
                {
                    new Manga{
                        Id = new Guid(),
                        Name = "Kengan Omega",
                        CoverImage= "None",
                        Description = "Successor series to Kengan Azura",
                        Authors = "Daromeon",
                        Artists = "Daromeon",
                        Genre = "Martial arts",
                        SubGenres = "Action, Drama",
                        IsReading = true,
                        Completed = false,
                        Rating = 9,
                        DatePublished = new DateTime(2019)
                    },
                        new Manga{
                            Id = new Guid(),
                            Name = "Berserk",
                            CoverImage= "None",
                            Description = "Gats and friends",
                            Authors = "Kintarou miora",
                            Artists = "Kintarou miora",
                            Genre = "Fantasy",
                            SubGenres = "Action, Drama",
                            IsReading = true,
                            Completed = false,
                            Rating = 9,
                            DatePublished = new DateTime(2019)
                    },
                        new Manga{
                            Id = new Guid(),
                            Name = "Shuumatsu no Valkyrie",
                            CoverImage= "None",
                            Description = "Successor series to Kengan Azura",
                            Authors = "Fukui takumi",
                            Artists = "Fukui takumi",
                            Genre = "Martial arts",
                            SubGenres = "Action, Drama",
                            IsReading = true,
                            Completed = false,
                            Rating = 9,
                            DatePublished = new DateTime(2019)
                    },
                };
                await context.Mangas.AddRangeAsync(Manga);

                var Games = new List<Game>
                {
                    new Game
                    {
                        Id = new Guid(),
                        Name = " Monster hunter wolrd",
                        DonePlaying = false,
                        IsPlaying = true,
                        Description = "Most Awesome monster hunter game",
                        Genre="Action",
                        CoverImage = String.Empty,
                        Series = "Monster Hunter",
                        Tags = "monster hunter, hack'n'slash",
                        IsFavorite = true,
                        SubGenres = "Action, Adventure, RPG",
                        Rating = 9,
                        DatePublished = new DateTime(2018, 8, 9),
                        Authors = "Capcom"

                    },
                   new Game
                    {
                        Id = new Guid(),
                        Name = " Devil may cry 4 se",
                        DonePlaying = true,
                        IsPlaying = false,
                        Description = "best styled devil may cry game",
                        Genre="Action",
                        CoverImage = String.Empty,
                        Series = "Devil may cry",
                        Tags = "devil may cry, hack'n'slash",
                        IsFavorite = true,
                        SubGenres = "Action, Adventure, RPG",
                        Rating = 9,
                        DatePublished = new DateTime(2015, 2, 23),
                        Authors = "Capcom"

                    },
                };
                await context.Games.AddRangeAsync(Games);

                var tracks = new List<MusicTrack>
                {
                    new MusicTrack
                    {
                        Id = new Guid(),
                        Name = "Go One's own way",
                        Description="Best track in Ken's Rage 2",
                        Genre = "Metal",
                        Rating = 10,
                        SubGenres= "Melodic Death metal, Instrumental",
                        CoverImage = "None"
                    },
                    new MusicTrack
                    {
                        Id = new Guid(),
                        Name="デスリパ666",
                        Description="Ninja Slayer anime soundtrack",
                        Genre="Metal",
                        SubGenres="Heavy Death Metal, Instrumantal",
                        CoverImage= "None",
                        Rating=10
                    }
                };
                await context.MusicTracks.AddRangeAsync(tracks);


                var exersises = new List<Exercise>
                {
                    new Exercise
                    {
                        Id = new Guid(),
                        Name = "Squatted Calf Raise w/ Dumbbell",
                        Description = "Done till failure",
                        Sets   = 4.0,
                        Reps = "Failure",
                         Type = "Legs"


                    },
                    new Exercise
                    {
                        Id = new Guid(),
                        Name = "Hip Thrusts + Sumo Deadlifts",
                        Sets = 3,
                        Reps= "50 reps / 20 reps",
                         Type = "Legs"

                    },
                    new Exercise
                    {
                        Id = new Guid(),
                        Name ="GIANT SET - Slow High Bar Squat \"feet close\" + Dumbbell Sissy Squat \"lean back on the way up\" + Modified Pistol Squat + Extreme Sissy Squat",
                        Sets = 3,
                        Reps = "30 Reps / 20 Reps / 20 Reps Each / Failure",
                         Type = "Legs"
                    },
                    new Exercise
                    {
                        Id = new Guid(),
                        Name="Century Squats \"100 Reps\"",
                        Sets=2,
                        Reps= "100",
                         Type = "Legs"
                    },
                    new Exercise
                    {
                         Id = new Guid(),
                         Name= "180 Continuous Walking Lunges \"Long Stride / Drag Back Leg\"",
                         Sets= 1,
                         Reps= "180",
                         Type = "Legs"
                    }
                };
                await context.Exercises.AddRangeAsync(exersises);

                var bbWorkouts = new List<Workout_BodyBuilding>
                {
                    new Workout_BodyBuilding
                    {
                        Id = new Guid(),
                        Week = "4: By Any Means Necessary",
                        Day = "5",
                        Part = "Leg",
                        Duration = 2.5,
                        CycleType = "FUCK",
                        Excersises = new List<Exercise>()

                    }
                };
                foreach(var leg in exersises) bbWorkouts[0].Excersises.Add(leg);
                await context.BodyBuildingWorkouts.AddRangeAsync(bbWorkouts);

                await context.SaveChangesAsync();
            }
        }
    }
}
