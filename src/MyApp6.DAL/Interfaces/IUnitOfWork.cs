using System;

namespace MyApp6.DAL
{
   public interface IUnitOfWork : IDisposable
    {
         IAlbumRepository Albums { get; }
         IArtistRepository Artists { get; }
         ICustomerRepository Customers { get; }
         IEmployeeRepository Employees { get; }
         IGenreRepository Genres { get; }
         IInvoiceRepository Invoices { get; }
         IInvoiceLineRepository InvoiceLines { get; }
         IMediaTypeRepository MediaTypes { get; }
         IPlaylistRepository Playlists { get; }
         ITrackRepository Tracks { get; }
         int Complete();
    }
}

