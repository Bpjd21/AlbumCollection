using AlbumCollection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumCollection.Repositories
{
    public class SongRepository : ISongRepository
    {
        AlbumContext db;
        public SongRepository(AlbumContext db)
        {
            this.db = db;
        }
        public IEnumerable<Song> GetAll()
        {
            return db.Songs.ToList();
        }
        public Song GetById(int id)
        {
            return db.Songs.Single(Song => Song.Id == id);
        }
    }
}
