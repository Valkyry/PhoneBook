using Autofac;

namespace SimplePhoneBook.Runtime
{
    public class InstanceFactory
    {
        public static T GetInstance<T>(string connectionString)
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(new CoreModule(connectionString));
            IContainer Container = builder.Build();
            using (var scope = Container.BeginLifetimeScope())
            {
                return scope.Resolve<T>();
            }
        }
    }
}
