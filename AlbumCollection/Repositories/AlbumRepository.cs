﻿using AlbumCollection.Models;
using System.Collections.Generic;
using System.Linq;

namespace AlbumCollection.Repositories
{
    public class AlbumRepository : IAlbumRepository
    {
        AlbumContext db;

        public AlbumRepository(AlbumContext db)
        {
            this.db = db;
        }

        public IEnumerable<Album> GetAll()
        {
            return db.Albums.ToList();
        }

        public Album GetById(int id)
        {
            return db.Albums.Single(Album => Album.AlbumId == id);
        }              
    }
}
