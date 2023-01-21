using System.Data.Entity.Migrations;

namespace SimplePhoneBook.Persistence
{
    public class Migrations : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Migrations()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "SimplePhoneBook.Persistence.ApplicationDbContext";
        }

        protected override void Seed(ApplicationDbContext context)
        {
        }
    }

}
