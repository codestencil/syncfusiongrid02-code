using MyApp6.Shared.Model;

namespace MyApp6.DAL
{
   public class ArtistRepository: GenericRepository<Artist>, IArtistRepository
    {
        public ArtistRepository(MyApp6Context context) : base(context)
        {
        }
    }
}

