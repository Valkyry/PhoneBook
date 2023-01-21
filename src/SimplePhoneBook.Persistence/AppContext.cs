using SimplePhoneBook.Domain.Entities;
using SimplePhoneBook.Domain.Interfaces;

namespace SimplePhoneBook.Persistence
{
    public class AppContext<TEntity, Tstruct> : UnitOfWork, IAppContext<TEntity, Tstruct>
        where TEntity : BaseEntity<Tstruct>
        where Tstruct : struct
    {
        public AppContext(IApplicationDbContextFactory contextFactory, IRepository<TEntity, Tstruct> generic) : base(contextFactory)
        {
            Generic = generic;
        }

        public IRepository<TEntity, Tstruct> Generic { get; }
    }
}
