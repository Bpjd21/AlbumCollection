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
                
            base.OnModelCreating(modelBuilder);
        } 
    }   
}
