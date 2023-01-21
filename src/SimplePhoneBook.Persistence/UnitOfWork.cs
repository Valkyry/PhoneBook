using SimplePhoneBook.Domain.Interfaces;

namespace SimplePhoneBook.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        protected readonly ApplicationDbContext _context;

        public UnitOfWork(IApplicationDbContextFactory contextFactory)
        {
            _context = (ApplicationDbContext)contextFactory.GetContext();
        }

        public bool Commit()
        {
            var rows = _context.SaveChanges();
            return rows > 0;
        }
    }
}
