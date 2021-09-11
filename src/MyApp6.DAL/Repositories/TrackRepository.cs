using MyApp6.Shared.Model;

namespace MyApp6.DAL
{
   public class TrackRepository: GenericRepository<Track>, ITrackRepository
    {
        public TrackRepository(MyApp6Context context) : base(context)
        {
        }
    }
}

