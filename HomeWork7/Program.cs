using HomeWork7;
using Autofac;

var builder = new ContainerBuilder();
builder.RegisterType<FindService>().As<IFindService>();
builder.RegisterType<SortBySquareHouseService>().As<ISortBySquareHouseService>();
builder.RegisterType<CountMinSquareForZooService>().As<ICountMinSquareForZooService>();
builder.RegisterType<NotificationService>().As<INotificationService>();
builder.RegisterType<Starter>();

var container = builder.Build();
var starter = container.Resolve<Starter>();

// Starter starter1 = new Starter(new FindService(), new SortBySquareHouseService(), new CountMinSquareForZooService(), new NotificationService());
starter.Start();