using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata;
using Ondc.Seller.Domain.Entities;
using Ondc.Seller.Domain.Extensions;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Ondc.Seller.DataAccess.Entities
{
    [ExcludeFromCodeCoverage]
    public sealed class AppDbContext : DbContext
    {
        private readonly ApplicationDbContextOptions _appDbOptions;

        public AppDbContext(ApplicationDbContextOptions appDbOptions)
        {
            _appDbOptions = appDbOptions;
            ChangeTracker.LazyLoadingEnabled = false;
        }

        public AppDbContext(ApplicationDbContextOptions appDbOptions, DbContextOptions<AppDbContext> options)
            : base(options)
        {
            _appDbOptions = appDbOptions;
            ChangeTracker.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            if (_appDbOptions.EntitiesAssembly != null)
            {
                modelBuilder.ApplyConfigurationsFromAssembly(_appDbOptions.EntitiesAssembly);
            }

            foreach (IMutableEntityType entityType in modelBuilder.Model.GetEntityTypes())
            {
                entityType.SetTableName((_appDbOptions.TablePrefix + entityType.ClrType.Name).ToSnakeCase());
            }
        }

        public override int SaveChanges()
        {
            OnBeforeSaving();
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            OnBeforeSaving();
            return base.SaveChangesAsync(cancellationToken);
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default(CancellationToken))
        {
            OnBeforeSaving();
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        private void OnBeforeSaving()
        {
            foreach (EntityEntry item in ChangeTracker.Entries())
            {
                EntityBase auditableEntity = item.Entity as EntityBase;
                if (auditableEntity != null)
                {
                    if (item.State == EntityState.Added)
                    {
                        auditableEntity.CreatedAt = DateTime.UtcNow;
                    }

                    if (item.State == EntityState.Modified)
                    {
                        auditableEntity.UpdatedAt = DateTime.UtcNow;
                    }
                }
            }
        }
    }
}
