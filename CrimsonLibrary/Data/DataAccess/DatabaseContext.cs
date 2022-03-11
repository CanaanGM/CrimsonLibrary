using CrimsonLibrary.Data.Configuration;
using CrimsonLibrary.Data.Models;
using CrimsonLibrary.Data.Models.Domain;
using CrimsonLibrary.Data.Models.JoinTables;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CrimsonLibrary.Data.DataAccess
{
    public class DatabaseContext : IdentityDbContext<ApiUser>
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Game> Games { get; set; }
        public DbSet<BoughtItem> BoughtItems { get; set; }
        public DbSet<MusicTrack> MusicTracks { get; set; }
        public DbSet<Anime> Animes { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Manga> Mangas { get; set; }
        public DbSet<Workout_BodyBuilding> BodyBuildingWorkouts { get; set; }
        public DbSet<Exercise> Exercises { get; set; }

        public DbSet<Workout_Exercise> Workout_Exercises { get; set; }

        //public DbSet<Artist> Artists { get; set; }
        //public DbSet<Author> Authors { get; set; }
        //public DbSet<Command> Commands { get; set; }
        //public DbSet<Movie> Movies { get; set; }
        //public DbSet<Track> Tracks { get; set; }
        //public DbSet<Wishlist> Whishlists { get; set; }

        //// RELATIONS
        //public DbSet<Anime_Author> anime_Authors { get; set; }
        //public DbSet<Anime_Artist> Anime_Artists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            //modelBuilder.ApplyConfiguration(new AnimeConfiguration());
            //modelBuilder.ApplyConfiguration(new BookConfiguration());
            //modelBuilder.ApplyConfiguration(new BoughtItemConfiguration());
            //modelBuilder.ApplyConfiguration(new ExerciseConfiguration());
            //modelBuilder.ApplyConfiguration(new GameConfiguration());
            //modelBuilder.ApplyConfiguration(new MusicTrackConfiguration());
            //modelBuilder.ApplyConfiguration(new WorkoutConfiguration());
            //modelBuilder.ApplyConfiguration(new MangaConfiguration());


            modelBuilder.Entity<Anime>().ToTable("Anime");
            modelBuilder.Entity<Manga>().ToTable("Manga");
            modelBuilder.Entity<Workout_BodyBuilding>().ToTable("BodyBuilding");

            //modelBuilder.Entity<Workout_Exercise>()
            //    .HasOne(x=>x.Exercise)
            //    .WithMany(w=>w.Workouts)
            //    .HasForeignKey(q=>q.Workout_Id);
            //modelBuilder.Entity<Workout_Exercise>()
            //    .HasOne(q=>q.Workout)
            //    .WithMany(e=>e.Excersises)
            //    .HasForeignKey(w=>w.Excercise_Id);

            //modelBuilder.Entity<Wishlist>().ToTable("Wishlist");
            //modelBuilder.Entity<Game_Series>()
            //    .HasOne(x => x.Game)
            //    .WithMany(q => q.Series)
            //    .HasForeignKey(w => w.Series_Id);
            //modelBuilder.Entity<Game_Series>()
            //    .HasOne(w => w.Series)
            //    .WithMany(e => e.Games)
            //    .HasForeignKey(r => r.Game_Id);

        }
    }
}
