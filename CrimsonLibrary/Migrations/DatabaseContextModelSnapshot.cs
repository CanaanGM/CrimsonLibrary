// <auto-generated />
using System;
using CrimsonLibrary.Data.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CrimsonLibrary.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("CrimsonLibrary.Data.Models.ApiUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("CrimsonLibrary.Data.Models.Domain.Anime", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Artists")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Authors")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Consumed")
                        .HasColumnType("datetime2");

                    b.Property<double>("ConsumedTimes")
                        .HasColumnType("float");

                    b.Property<string>("CoverImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatePublished")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FaveCharacter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsFavorite")
                        .HasColumnType("bit");

                    b.Property<bool>("IsWatched")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("OnGoing")
                        .HasColumnType("bit");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.Property<string>("Series")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubGenres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tags")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Anime");
                });

            modelBuilder.Entity("CrimsonLibrary.Data.Models.Domain.Book", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Artists")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Authors")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Consumed")
                        .HasColumnType("datetime2");

                    b.Property<double>("ConsumedTimes")
                        .HasColumnType("float");

                    b.Property<string>("CoverImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatePublished")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsFavorite")
                        .HasColumnType("bit");

                    b.Property<bool>("IsRead")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Pages")
                        .HasColumnType("float");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.Property<string>("Series")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubGenres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tags")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("CrimsonLibrary.Data.Models.Domain.BoughtItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateBought")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price_Dollar")
                        .HasColumnType("float");

                    b.Property<double>("Price_JOD")
                        .HasColumnType("float");

                    b.Property<double>("Quantity")
                        .HasColumnType("float");

                    b.Property<string>("Recipt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StoreBoughtFrom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tags")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BoughtItems");
                });

            modelBuilder.Entity("CrimsonLibrary.Data.Models.Domain.Exercise", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Picture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reps")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Sets")
                        .HasColumnType("float");

                    b.Property<int>("TimesDone")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("WeightKG")
                        .HasColumnType("float");

                    b.Property<Guid?>("Workout_BodyBuildingId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("Workout_BodyBuildingId");

                    b.ToTable("Exercises");
                });

            modelBuilder.Entity("CrimsonLibrary.Data.Models.Domain.Game", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Artists")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Authors")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Consumed")
                        .HasColumnType("datetime2");

                    b.Property<double>("ConsumedTimes")
                        .HasColumnType("float");

                    b.Property<string>("CoverImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatePublished")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("DonePlaying")
                        .HasColumnType("bit");

                    b.Property<string>("FaveCahracter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsFavorite")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPlaying")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.Property<string>("Series")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubGenres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tags")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("CrimsonLibrary.Data.Models.Domain.Manga", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Artists")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Authors")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Chapters")
                        .HasColumnType("float");

                    b.Property<bool>("Completed")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Consumed")
                        .HasColumnType("datetime2");

                    b.Property<double>("ConsumedTimes")
                        .HasColumnType("float");

                    b.Property<string>("CoverImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatePublished")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FaveCharacter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsFavorite")
                        .HasColumnType("bit");

                    b.Property<bool>("IsReading")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.Property<bool>("ReadToFinish")
                        .HasColumnType("bit");

                    b.Property<string>("Series")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubGenres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tags")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Manga");
                });

            modelBuilder.Entity("CrimsonLibrary.Data.Models.Domain.MusicTrack", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Album")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Artists")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Authors")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Band")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Consumed")
                        .HasColumnType("datetime2");

                    b.Property<double>("ConsumedTimes")
                        .HasColumnType("float");

                    b.Property<string>("CoverImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatePublished")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsFavorite")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.Property<string>("Series")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubGenres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tags")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TracksNum")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("MusicTracks");
                });

            modelBuilder.Entity("CrimsonLibrary.Data.Models.Domain.Workout_BodyBuilding", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CycleType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Day")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Duration")
                        .HasColumnType("float");

                    b.Property<string>("Part")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Week")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BodyBuilding");
                });

            modelBuilder.Entity("CrimsonLibrary.Data.Models.JoinTables.Workout_Exercise", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Excercise_Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ExerciseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("WorkoutId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Workout_Id")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ExerciseId");

                    b.HasIndex("WorkoutId");

                    b.ToTable("Workout_Exercises");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "ca24492c-443c-412c-8795-f335877d3c09",
                            ConcurrencyStamp = "fa8cc905-46b6-4b13-8ec6-e90ca10288e3",
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "c5676b88-1d8c-4829-9eb2-a52ddd2849e0",
                            ConcurrencyStamp = "6de2acd0-1d41-48a7-9655-a374c8179587",
                            Name = "Adminstrator",
                            NormalizedName = "ADMINSTRATOR"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("CrimsonLibrary.Data.Models.Domain.Exercise", b =>
                {
                    b.HasOne("CrimsonLibrary.Data.Models.Domain.Workout_BodyBuilding", null)
                        .WithMany("Excersises")
                        .HasForeignKey("Workout_BodyBuildingId");
                });

            modelBuilder.Entity("CrimsonLibrary.Data.Models.JoinTables.Workout_Exercise", b =>
                {
                    b.HasOne("CrimsonLibrary.Data.Models.Domain.Exercise", "Exercise")
                        .WithMany("Workouts")
                        .HasForeignKey("ExerciseId");

                    b.HasOne("CrimsonLibrary.Data.Models.Domain.Workout_BodyBuilding", "Workout")
                        .WithMany()
                        .HasForeignKey("WorkoutId");

                    b.Navigation("Exercise");

                    b.Navigation("Workout");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("CrimsonLibrary.Data.Models.ApiUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("CrimsonLibrary.Data.Models.ApiUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CrimsonLibrary.Data.Models.ApiUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("CrimsonLibrary.Data.Models.ApiUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CrimsonLibrary.Data.Models.Domain.Exercise", b =>
                {
                    b.Navigation("Workouts");
                });

            modelBuilder.Entity("CrimsonLibrary.Data.Models.Domain.Workout_BodyBuilding", b =>
                {
                    b.Navigation("Excersises");
                });
#pragma warning restore 612, 618
        }
    }
}
