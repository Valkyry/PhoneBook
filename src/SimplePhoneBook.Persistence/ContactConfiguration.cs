using System.Data.Entity.ModelConfiguration;

namespace SimplePhoneBook.Persistence
{
    internal class ContactConfiguration : EntityTypeConfiguration<SimplePhoneBook.Domain.Entities.Contact>
    {
        public ContactConfiguration()
        {
            HasKey(row => row.ID);
            Property(row => row.CreateDate).IsOptional();
            Property(row => row.LastModifiedDate).IsOptional();
        }
    }
}
