using Autofac;

namespace Solid_demo.Utils
{
    public static class AutofacConfiguration
    {
        public static IContainer GetContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Sword>().As<IWeapon>();
            
            return builder.Build();
        }
    }
}
