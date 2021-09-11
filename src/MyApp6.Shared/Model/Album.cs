using System;
using System.Collections.Generic;

#nullable disable

namespace MyApp6.Shared.Model
{
    public partial class Album
    {
        public Album()
        {
            Track = new HashSet<Track>();
        }

        public long AlbumId { get; set; }
        public string Title { get; set; }
        public long ArtistId { get; set; }

        public virtual Artist Artist { get; set; }
        public virtual ICollection<Track> Track { get; set; }
    }
}
