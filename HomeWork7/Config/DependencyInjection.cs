using Autofac;

namespace HomeWork7
{
    internal class DependencyInjection
    {
        public void SetDI()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<CatalogAnimals>().As<IGetCatalogAnimals>();
            builder.RegisterType<FindService>().As<IFindService>();
            builder.RegisterType<SortService>().As<ISortService>();
            builder.RegisterType<CountService>().As<ICountService>();
            builder.RegisterType<NotificationService>().As<INotificationService>();
            builder.RegisterType<Starter>();

            var container = builder.Build();
            var starter = container.Resolve<Starter>();

            starter.Start();
        }
    }
}
