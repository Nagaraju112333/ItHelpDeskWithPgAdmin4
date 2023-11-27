using APLManagement.Common.Repository;
using Ondc.Seller.Api.Extensions;
using Ondc.Seller.DataAccess.Entities;
using Ondc.Seller.DataAccess.EntityConfiguration;
using Ondc.Seller.DataAccess.Interfaces;
using Ondc.Seller.Integration;
using Ondc.Seller.Integration.Interfaces;

using Scrutor;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAppDbContext(
    connectionString: builder.Configuration.GetValue<string>("ItHelpDesk:ConnectionStrings:AppConnectionString"),
    entitiesAssembly: Assembly.GetAssembly(typeof(CompaniesEntityConfiguration)),
    repositoriesAssembly: Assembly.GetAssembly(typeof(IProductRepository)),
    npgsqlOptions: options =>
    {
        options.MigrationsAssembly(typeof(Program).Assembly.GetName().Name);
    });

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped(typeof(IStorageService), typeof(StorageService));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
