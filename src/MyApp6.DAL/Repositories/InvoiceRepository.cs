using MyApp6.Shared.Model;

namespace MyApp6.DAL
{
   public class InvoiceRepository: GenericRepository<Invoice>, IInvoiceRepository
    {
        public InvoiceRepository(MyApp6Context context) : base(context)
        {
        }
    }
}

