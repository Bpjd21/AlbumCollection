﻿// <auto-generated />
using AlbumCollection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AlbumCollection.Migrations
{
    [DbContext(typeof(AlbumContext))]
    partial class AlbumContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AlbumCollection.Models.Album", b =>
                {
                    b.Property<int>("AlbumId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AlbumName");

                    b.Property<string>("ArtistName");

                    b.Property<string>("ImgPath");

                    b.HasKey("AlbumId");

                    b.ToTable("Albums");

                    b.HasData(
                        new { AlbumId = 1, AlbumName = "Moana Soundtrack", ArtistName = "Various Artists", ImgPath = "/images/Moana_Soundtrack.jpg" },
                        new { AlbumId = 2, AlbumName = "Top Gun Soundtrack", ArtistName = "Various Artists", ImgPath = "/images/top-gun.jpg" },
                        new { AlbumId = 3, AlbumName = "Spider Man Into the Spider Verse Soundtrack", ArtistName = "Various Artisits", ImgPath = "/images/spider-man-into-the-spider-verse-soundtrack.jpg" }
                    );
                });

            modelBuilder.Entity("AlbumCollection.Models.Song", b =>
                {
                    b.Property<int>("SongId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AlbumId");

                    b.Property<string>("Performer");

                    b.Property<string>("SongName");

                    b.HasKey("SongId");

                    b.HasIndex("AlbumId");

                    b.ToTable("Songs");

                    b.HasData(
                        new { SongId = 1, AlbumId = 1, Performer = "Auliʻi Cravalho", SongName = "How Far I'll Go" },
                        new { SongId = 2, AlbumId = 1, Performer = "Dwyane The Rock Johnson", SongName = "You're Welcome" },
                        new { SongId = 3, AlbumId = 2, Performer = "Kenny Loggins", SongName = "Danger Zone" },
                        new { SongId = 4, AlbumId = 2, Performer = "The Righteous Brothers ", SongName = "You've Lost That Lovin' Feeling" },
                        new { SongId = 5, AlbumId = 3, Performer = "Thutmose", SongName = "Memories" },
                        new { SongId = 6, AlbumId = 3, Performer = "Amine", SongName = "Invincible" }
                    );
                });

            modelBuilder.Entity("AlbumCollection.Models.Song", b =>
                {
                    b.HasOne("AlbumCollection.Models.Album")
                        .WithMany("Songs")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
