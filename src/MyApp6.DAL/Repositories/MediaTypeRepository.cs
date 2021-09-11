using MyApp6.Shared.Model;

namespace MyApp6.DAL
{
   public class MediaTypeRepository: GenericRepository<MediaType>, IMediaTypeRepository
    {
        public MediaTypeRepository(MyApp6Context context) : base(context)
        {
        }
    }
}

