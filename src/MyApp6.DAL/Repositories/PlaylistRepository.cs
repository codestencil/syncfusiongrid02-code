using MyApp6.Shared.Model;

namespace MyApp6.DAL
{
   public class PlaylistRepository: GenericRepository<Playlist>, IPlaylistRepository
    {
        public PlaylistRepository(MyApp6Context context) : base(context)
        {
        }
    }
}

