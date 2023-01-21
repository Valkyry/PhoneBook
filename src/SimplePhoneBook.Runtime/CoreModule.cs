using Autofac;
using SimplePhoneBook.Domain.Interfaces;

namespace SimplePhoneBook.Runtime
{
    public class CoreModule : Module
    {
        public static string _connectionString;

        public CoreModule(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterType<SimplePhoneBook.Persistence.UnitOfWork>().As<IUnitOfWork>().InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(SimplePhoneBook.Persistence.AppContext<,>)).As(typeof(IAppContext<,>)).InstancePerLifetimeScope();
            builder.RegisterType<SimplePhoneBook.Persistence.ApplicationDbContextFactory>().As<IApplicationDbContextFactory>().WithParameter("connectionString", _connectionString).InstancePerLifetimeScope();


            builder.RegisterGeneric(typeof(Persistence.Repository<,>)).As(typeof(IRepository<,>)).InstancePerLifetimeScope();
        }
    }
}
