using AlbumCollection.Models;
using System.Collections.Generic;

namespace AlbumCollection.Repositories
{
    public interface ISongRepository
    {
        IEnumerable<Song> GetAll();
        Song GetById(int id);
    }
}
