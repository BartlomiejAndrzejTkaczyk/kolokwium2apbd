﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication5.DataAccess;

#nullable disable

namespace WebApplication5.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20220609073636_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebApplication5.Models.DBModels.AlbumDbModel", b =>
                {
                    b.Property<int>("IdAlbum")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdAlbum"), 1L, 1);

                    b.Property<string>("AlbumName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("IdMusicLabel")
                        .HasColumnType("int");

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("datetime2");

                    b.HasKey("IdAlbum");

                    b.HasIndex("IdMusicLabel");

                    b.ToTable("Albums");
                });

            modelBuilder.Entity("WebApplication5.Models.DBModels.MusicianDbModel", b =>
                {
                    b.Property<int>("IdMusician")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdMusician"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Nickname")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("IdMusician");

                    b.ToTable("Musicians");
                });

            modelBuilder.Entity("WebApplication5.Models.DBModels.MusicianTrackDbModel", b =>
                {
                    b.Property<int>("IdTrack")
                        .HasColumnType("int");

                    b.Property<int>("IdMusician")
                        .HasColumnType("int");

                    b.HasKey("IdTrack", "IdMusician");

                    b.HasIndex("IdMusician");

                    b.ToTable("MusicianTracks");
                });

            modelBuilder.Entity("WebApplication5.Models.DBModels.MusicLabelDbModel", b =>
                {
                    b.Property<int>("IdMusicLabel")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdMusicLabel"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdMusicLabel");

                    b.ToTable("MusicLabels");
                });

            modelBuilder.Entity("WebApplication5.Models.DBModels.TrackDbModel", b =>
                {
                    b.Property<int>("IdTrack")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTrack"), 1L, 1);

                    b.Property<float>("Duration")
                        .HasColumnType("real");

                    b.Property<int?>("IdMusicAlbum")
                        .HasColumnType("int");

                    b.Property<string>("TrackName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("IdTrack");

                    b.HasIndex("IdMusicAlbum");

                    b.ToTable("Tracks");
                });

            modelBuilder.Entity("WebApplication5.Models.DBModels.AlbumDbModel", b =>
                {
                    b.HasOne("WebApplication5.Models.DBModels.MusicLabelDbModel", "TheMusicLabel")
                        .WithMany("Albums")
                        .HasForeignKey("IdMusicLabel")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TheMusicLabel");
                });

            modelBuilder.Entity("WebApplication5.Models.DBModels.MusicianTrackDbModel", b =>
                {
                    b.HasOne("WebApplication5.Models.DBModels.MusicianDbModel", "TheMusician")
                        .WithMany("MusicianTracks")
                        .HasForeignKey("IdMusician")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication5.Models.DBModels.TrackDbModel", "TheTrack")
                        .WithMany("MusicianTracks")
                        .HasForeignKey("IdTrack")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TheMusician");

                    b.Navigation("TheTrack");
                });

            modelBuilder.Entity("WebApplication5.Models.DBModels.TrackDbModel", b =>
                {
                    b.HasOne("WebApplication5.Models.DBModels.AlbumDbModel", "TheAlbum")
                        .WithMany("Tracks")
                        .HasForeignKey("IdMusicAlbum");

                    b.Navigation("TheAlbum");
                });

            modelBuilder.Entity("WebApplication5.Models.DBModels.AlbumDbModel", b =>
                {
                    b.Navigation("Tracks");
                });

            modelBuilder.Entity("WebApplication5.Models.DBModels.MusicianDbModel", b =>
                {
                    b.Navigation("MusicianTracks");
                });

            modelBuilder.Entity("WebApplication5.Models.DBModels.MusicLabelDbModel", b =>
                {
                    b.Navigation("Albums");
                });

            modelBuilder.Entity("WebApplication5.Models.DBModels.TrackDbModel", b =>
                {
                    b.Navigation("MusicianTracks");
                });
#pragma warning restore 612, 618
        }
    }
}
