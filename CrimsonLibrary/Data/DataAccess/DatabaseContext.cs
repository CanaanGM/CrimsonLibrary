using CrimsonLibrary.Data.Models.Domain;

using Microsoft.EntityFrameworkCore;

namespace CrimsonLibrary.Data.DataAccess
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Anime> Animes { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Command> Commands { get; set; }
        public DbSet<Manga> Mangas { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<Wishlist> Whishlists { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Anime>().ToTable("Anime");
            modelBuilder.Entity<Manga>().ToTable("Manga");
            modelBuilder.Entity<Wishlist>().ToTable("Wishlist");

        }
    }
}
