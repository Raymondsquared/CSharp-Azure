using System.Configuration;
using Autofac;
using WebApiApplication.Repositories.Abstractions;
using WebApiApplication.Repositories.Implementations;
using WebApiApplication.Services;

namespace WebApiApplication.IoC
{
    public class BindingModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterType<RRSqlRepository>()
                .As<ISqlRepository>()
                .WithParameter("connectionString", ConfigurationManager.ConnectionStrings["RRAzureConnectionString"].ConnectionString);

            builder.RegisterType<RRService>().AsSelf();
        }
    }
}