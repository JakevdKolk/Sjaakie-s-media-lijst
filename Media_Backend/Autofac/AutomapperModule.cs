using Autofac;
using AutoMapper;
using System.Reflection;
using Module = Autofac.Module;

namespace Media_Backend.Autofac
{
    public class AutomapperModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
                    var asm = Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(asm).Where(t => typeof(Profile).IsAssignableFrom(t)).As<Profile>().SingleInstance();

            //builder.Register(ctx =>
            //{
            //    var profiles = ctx.Resolve<IEnumerable<Profile>>();

            //    var config = new AutoMapper.MapperConfiguration(cfg =>
            //    {
            //        foreach (var profile in profiles)
            //            cfg.AddProfile(profile);
            //    });

            //    return config;
            //})
            //.AsSelf()
            //.SingleInstance();

            builder.Register(ctx =>
            {
                var config = ctx.Resolve<MapperConfiguration>();
                return config.CreateMapper(ctx.Resolve);
            })
            .As<IMapper>()
            .InstancePerLifetimeScope();
        }
    }
}
