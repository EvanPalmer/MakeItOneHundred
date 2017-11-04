using System.Reflection;
using System;
using Autofac;

namespace MakeItOneHundred
{
    class Program
    {
                private static IContainer Container { get; set; }

        static void Main(string[] args)
        {
            SetUpIoc();

            using (var scope = Container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IMakeItOneHundredApp>();
                app.Run();
            }
        }

        private static void SetUpIoc()
        {
            var builder = new ContainerBuilder();
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly()).AsImplementedInterfaces();
            Container = builder.Build();
        }
    }
}
