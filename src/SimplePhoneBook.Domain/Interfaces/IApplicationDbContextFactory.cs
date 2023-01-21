namespace SimplePhoneBook.Domain.Interfaces
{
    public interface IApplicationDbContextFactory
    {
        object GetContext();
    }
}
