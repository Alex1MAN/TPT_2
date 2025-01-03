using Finbuckle.MultiTenant.Abstractions;

using FSH.WebApi.Application.Common.Events;
using FSH.WebApi.Application.Common.Interfaces;
//using FSH.WebApi.Domain.Catalog;
using FSH.WebApi.PostgreSQL.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace FSH.WebApi.PostgreSQL.Context;

public class ApplicationDbContext : BaseDbContext
{
    public ApplicationDbContext(ITenantInfo currentTenant, DbContextOptions options, ICurrentUser currentUser, ISerializerService serializer, IOptions<DatabaseSettings> dbSettings, IEventPublisher events)
        : base(currentTenant, options, currentUser, serializer, dbSettings, events)     // need Multitenancy using currentTenant
    {
    }

    /*public DbSet<Product> Products => Set<Product>();
    public DbSet<Brand> Brands => Set<Brand>();*/

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        //modelBuilder.HasDefaultSchema(SchemaNames.Catalog);
    }
}