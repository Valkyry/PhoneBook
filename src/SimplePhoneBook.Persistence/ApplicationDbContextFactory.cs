using SimplePhoneBook.Domain.Interfaces;

namespace SimplePhoneBook.Persistence
{
    public class ApplicationDbContextFactory : IApplicationDbContextFactory
    {
        private readonly string _connectionString;
        private ApplicationDbContext _context;

        public ApplicationDbContextFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public object GetContext()
        {
            return _context ?? (_context = new ApplicationDbContext(_connectionString));
        }
    }
}
