using AlbumCollection.Models;
using System.Collections.Generic;


namespace AlbumCollection.Repositories
{
    public interface IAlbumRepository
    {
        IEnumerable<Album> GetAll();
        Album GetById(int id);
    }
}
