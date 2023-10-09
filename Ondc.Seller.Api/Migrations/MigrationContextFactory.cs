using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Ondc.Seller.DataAccess.Entities;
using Ondc.Seller.DataAccess.EntityConfiguration;
using Ondc.Seller.Domain.Entities;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace Ondc.Seller.Api.Migrations;

[ExcludeFromCodeCoverage]
public class MigrationContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args)
    {
        var environmentName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Development";
        Console.WriteLine($"Environment: {environmentName}");
        var configurationBuilder = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json");

        if (!"Production".Equals(environmentName))
            configurationBuilder.AddJsonFile($"appsettings.{environmentName}.json", false, true);
        var configuration = configurationBuilder.Build();

        var builder = new DbContextOptionsBuilder<AppDbContext>();
        var connectionString = configuration.GetValue<string>("Ondc:ConnectionStrings:AppConnectionString");
        builder.UseNpgsql(connectionString, optionsBuilder =>
        {
            optionsBuilder.MigrationsAssembly(typeof(Program).Assembly.GetName().Name);
        });

        return new AppDbContext(
            new ApplicationDbContextOptions
            {
                TablePrefix = "ondc",
                EntitiesAssembly = Assembly.GetAssembly(typeof(ProductEntityConfiguration))
            },
            builder.Options
        );
    }
}