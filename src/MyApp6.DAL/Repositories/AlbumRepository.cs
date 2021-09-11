using MyApp6.Shared.Model;

namespace MyApp6.DAL
{
   public class AlbumRepository: GenericRepository<Album>, IAlbumRepository
    {
        public AlbumRepository(MyApp6Context context) : base(context)
        {
        }
    }
}

