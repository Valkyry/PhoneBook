namespace SimplePhoneBook.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        bool Commit();
    }
}
