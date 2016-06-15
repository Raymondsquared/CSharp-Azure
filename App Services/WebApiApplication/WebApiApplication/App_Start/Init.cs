using System.Reflection;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using WebApiApplication.Controllers;
using WebApiApplication.IoC;
using WebApiApplication.Repositories.Abstractions;
using WebApiApplication.Repositories.Implementations;
using WebApiApplication.Services;

namespace WebApiApplication
{
    public static class App
    {
        public static void Init()
        {
            var builder = new ContainerBuilder();
            var config = GlobalConfiguration.Configuration;

            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterWebApiFilterProvider(config);

            builder.RegisterModule<BindingModule>();            

            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}