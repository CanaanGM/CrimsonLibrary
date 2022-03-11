﻿// <auto-generated />
using System;
using CrimsonLibrary.Data.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CrimsonLibrary.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20220311080348_workout")]
    partial class workout
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

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

            modelBuilder.Entity("CrimsonLibrary.Data.Models.Domain.Ecersise", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Reps")
                        .HasColumnType("float");

                    b.Property<int>("TimesDone")
                        .HasColumnType("int");

                    b.Property<double>("WeightKG")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Ecersise");
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

                    b.Property<double>("Duration")
                        .HasColumnType("float");

                    b.Property<Guid?>("ExcersiseAId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ExcersiseBId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ExcersiseCId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ExcersiseDId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ExcersiseEId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ExcersiseFId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ExcersiseGId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Part")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Week")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ExcersiseAId");

                    b.HasIndex("ExcersiseBId");

                    b.HasIndex("ExcersiseCId");

                    b.HasIndex("ExcersiseDId");

                    b.HasIndex("ExcersiseEId");

                    b.HasIndex("ExcersiseFId");

                    b.HasIndex("ExcersiseGId");

                    b.ToTable("BodyBuilding");
                });

            modelBuilder.Entity("CrimsonLibrary.Data.Models.Domain.Workout_BodyBuilding", b =>
                {
                    b.HasOne("CrimsonLibrary.Data.Models.Domain.Ecersise", "ExcersiseA")
                        .WithMany()
                        .HasForeignKey("ExcersiseAId");

                    b.HasOne("CrimsonLibrary.Data.Models.Domain.Ecersise", "ExcersiseB")
                        .WithMany()
                        .HasForeignKey("ExcersiseBId");

                    b.HasOne("CrimsonLibrary.Data.Models.Domain.Ecersise", "ExcersiseC")
                        .WithMany()
                        .HasForeignKey("ExcersiseCId");

                    b.HasOne("CrimsonLibrary.Data.Models.Domain.Ecersise", "ExcersiseD")
                        .WithMany()
                        .HasForeignKey("ExcersiseDId");

                    b.HasOne("CrimsonLibrary.Data.Models.Domain.Ecersise", "ExcersiseE")
                        .WithMany()
                        .HasForeignKey("ExcersiseEId");

                    b.HasOne("CrimsonLibrary.Data.Models.Domain.Ecersise", "ExcersiseF")
                        .WithMany()
                        .HasForeignKey("ExcersiseFId");

                    b.HasOne("CrimsonLibrary.Data.Models.Domain.Ecersise", "ExcersiseG")
                        .WithMany()
                        .HasForeignKey("ExcersiseGId");

                    b.Navigation("ExcersiseA");

                    b.Navigation("ExcersiseB");

                    b.Navigation("ExcersiseC");

                    b.Navigation("ExcersiseD");

                    b.Navigation("ExcersiseE");

                    b.Navigation("ExcersiseF");

                    b.Navigation("ExcersiseG");
                });
#pragma warning restore 612, 618
        }
    }
}
