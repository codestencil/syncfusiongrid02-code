using MyApp6.Shared.Model;

namespace MyApp6.DAL
{
   public class InvoiceLineRepository: GenericRepository<InvoiceLine>, IInvoiceLineRepository
    {
        public InvoiceLineRepository(MyApp6Context context) : base(context)
        {
        }
    }
}

