using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumCollection.Models
{
    public class Song
    {
        public int SongId { get; set; }
        public string Performer { get; set; }
        public string SongName { get; set; }
        public int AlbumId { get; set; }

        public virtual IEnumerable<Song> Songs { get; set; }
    }
}
