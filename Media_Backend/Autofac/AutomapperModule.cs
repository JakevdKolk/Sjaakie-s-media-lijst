using Autofac;
using AutoMapper;

namespace Media_Backend.Autofac
{
    public class AutomapperModule : Module
    {
        //register hier alle automapper profiles
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(typeof(AutomapperModule).Assembly)
                   .Where(t => t.IsSubclassOf(typeof(Profile)))
                   .As<Profile>()
                   .SingleInstance();


        }
    }
}
