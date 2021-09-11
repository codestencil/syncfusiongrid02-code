using MyApp6.Shared.Model;

namespace MyApp6.DAL
{
   public class EmployeeRepository: GenericRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(MyApp6Context context) : base(context)
        {
        }
    }
}

