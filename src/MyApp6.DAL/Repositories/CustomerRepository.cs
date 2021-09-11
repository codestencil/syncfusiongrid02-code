using MyApp6.Shared.Model;

namespace MyApp6.DAL
{
   public class CustomerRepository: GenericRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(MyApp6Context context) : base(context)
        {
        }
    }
}

