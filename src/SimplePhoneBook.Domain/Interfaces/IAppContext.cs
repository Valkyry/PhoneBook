using SimplePhoneBook.Domain.Entities;

namespace SimplePhoneBook.Domain.Interfaces
{
    public interface IAppContext<TEntity, in TStruct> : IUnitOfWork
        where TEntity : BaseEntity<TStruct>
        where TStruct : struct
    {
        IRepository<TEntity, TStruct> Generic { get; }
    }
}
