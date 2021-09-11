using MyApp6.Shared.Model;
using System;

namespace MyApp6.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MyApp6Context _context;
        public IAlbumRepository Albums { get; private set; }
        public IArtistRepository Artists { get; private set; }
        public ICustomerRepository Customers { get; private set; }
        public IEmployeeRepository Employees { get; private set; }
        public IGenreRepository Genres { get; private set; }
        public IInvoiceRepository Invoices { get; private set; }
        public IInvoiceLineRepository InvoiceLines { get; private set; }
        public IMediaTypeRepository MediaTypes { get; private set; }
        public IPlaylistRepository Playlists { get; private set; }
        public ITrackRepository Tracks { get; private set; }

        public UnitOfWork(MyApp6Context context)
        {
            _context = context;
            Albums = new AlbumRepository(_context);
            Artists = new ArtistRepository(_context);
            Customers = new CustomerRepository(_context);
            Employees = new EmployeeRepository(_context);
            Genres = new GenreRepository(_context);
            Invoices = new InvoiceRepository(_context);
            InvoiceLines = new InvoiceLineRepository(_context);
            MediaTypes = new MediaTypeRepository(_context);
            Playlists = new PlaylistRepository(_context);
            Tracks = new TrackRepository(_context);
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}

