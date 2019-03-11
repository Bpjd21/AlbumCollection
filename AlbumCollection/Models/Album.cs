using System;
using System.Collections.Generic;

namespace AlbumCollection.Models
{
    public class Album
    {
        public int AlbumId { get; set; }
        public string AlbumName { get; set; }
        public string ArtistName { get; set; }
        public string ImgPath { get; set; }

        public virtual IEnumerable<Song> Songs { get; set; }
    }
}
