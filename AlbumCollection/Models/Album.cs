using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumCollection.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string AlbumName { get; set; }
        public string ArtistName { get; set; }
        public string ImgPath { get; set; }
        public int SongId { get; set; }
        
        public virtual IEnumerable<Song> Songs { get; set; }               
    }
}
