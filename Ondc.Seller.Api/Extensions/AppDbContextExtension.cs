using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL.Infrastructure;
using Ondc.Seller.DataAccess.Entities;
using Ondc.Seller.DataAccess.Interfaces;
using Scrutor;
using System.Reflection;

namespace Ondc.Seller.Api.Extensions
{
    public static class AppDbContextExtension
    {
        public static IServiceCollection AddAppDbContext(this IServiceCollection services, string connectionString, Assembly? entitiesAssembly, Assembly? repositoriesAssembly, Action<NpgsqlDbContextOptionsBuilder> npgsqlOptions)
        {
            Assembly repositoriesAssembly2 = repositoriesAssembly;
            string connectionString2 = connectionString;
            Action<NpgsqlDbContextOptionsBuilder> npgsqlOptions2 = npgsqlOptions;
            Assembly entitiesAssembly2 = entitiesAssembly;

            if (repositoriesAssembly2 != null)
            {
                services.Scan(delegate (ITypeSourceSelector scan)
                {
                    scan.FromAssemblies(repositoriesAssembly2).AddClasses(delegate (IImplementationTypeFilter classes)
                    {
                        classes.AssignableTo(typeof(IRepository<>));
                    }).AsImplementedInterfaces()
                        .WithScopedLifetime();
                });
            }

            services.AddDbContext<AppDbContext>(delegate (DbContextOptionsBuilder options)
            {
                options.UseNpgsql(connectionString2, npgsqlOptions2);
            });
            services.AddSingleton((IServiceProvider _) => new ApplicationDbContextOptions
            {
                TablePrefix = "ondc",
                EntitiesAssembly = entitiesAssembly2
            });
            return services;
        }
    }
}
