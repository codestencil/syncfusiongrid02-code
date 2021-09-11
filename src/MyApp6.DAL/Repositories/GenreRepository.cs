using MyApp6.Shared.Model;

namespace MyApp6.DAL
{
   public class GenreRepository: GenericRepository<Genre>, IGenreRepository
    {
        public GenreRepository(MyApp6Context context) : base(context)
        {
        }
    }
}

