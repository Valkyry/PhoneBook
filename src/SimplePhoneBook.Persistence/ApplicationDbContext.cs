using SimplePhoneBook.Domain.Entities;
using System.Data.Entity;

namespace SimplePhoneBook.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        static string _connectionString;

        public ApplicationDbContext() : base(_connectionString)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Migrations>());
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;

        }

        public ApplicationDbContext(string connectionString) : base(connectionString)
        {
            _connectionString = connectionString;
        }

        /// <summary>
        /// مخاطبین
        /// </summary>
        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new ContactConfiguration());
        }

    }

}
