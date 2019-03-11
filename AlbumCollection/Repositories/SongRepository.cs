using AlbumCollection.Models;
using System.Collections.Generic;
using System.Linq;

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
            return db.Songs.Single(Song => Song.SongId == id);
        }

        public void Create(Song song)
        {

            db.Songs.Add(song);
            db.SaveChanges();
        }
    }
}
