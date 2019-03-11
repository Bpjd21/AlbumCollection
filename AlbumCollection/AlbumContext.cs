using AlbumCollection.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumCollection
{
    public class AlbumContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Song> Songs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=AlbumCollection;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>().HasData(

                new Album()
                {
                    AlbumId = 1,
                    AlbumName = "Moana Soundtrack",
                    ArtistName = "Various Artists",
                    ImgPath = "/images/Moana_Soundtrack.jpg"

                },
                new Album()
                {
                    AlbumId = 2,
                    AlbumName = "Top Gun Soundtrack",
                    ArtistName = "Various Artists",
                    ImgPath = "/images/top-gun.jpg"
                },
                new Album()
                {
                    AlbumId = 3,
                    AlbumName = "Spider Man Into the Spider Verse Soundtrack",
                    ArtistName = "Various Artisits",
                    ImgPath = "/images/spider-man-into-the-spider-verse-soundtrack.jpg"
                });

            modelBuilder.Entity<Song>().HasData(
                new Song()
                {
                    SongId = 1,
                    Performer = "Auliʻi Cravalho",
                    SongName = "How Far I'll Go",
                    AlbumId = 1
                },

                new Song()
                {
                    SongId = 2,
                    Performer = "Dwyane The Rock Johnson",
                    SongName = "You're Welcome",
                    AlbumId = 1
                },

                 new Song()
                 {
                     SongId = 3,
                     Performer = "Kenny Loggins",
                     SongName = "Danger Zone",
                     AlbumId = 2
                 },

                 new Song()
                 {
                     SongId = 4,
                     Performer = "The Righteous Brothers ",
                     SongName = "You've Lost That Lovin' Feeling",
                     AlbumId = 2
                 },

                 new Song()
                 {
                     SongId = 5,
                     Performer = "Thutmose",
                     SongName = "Memories",
                     AlbumId = 3
                 },
                 
                 new Song()
                 {
                     SongId = 6,
                     Performer = "Amine",
                     SongName = "Invincible",
                     AlbumId = 3
                 });               

           base.OnModelCreating(modelBuilder);
        } 
    }   
}
