using SimplePhoneBook.Domain.Entities;
using System;

namespace SimplePhoneBook.Domain.Interfaces
{
    public interface IContactRepository : IRepository<Contact, Guid>
    {
    }
}
