//using FSH.WebApi.Infrastructure.Multitenancy;

namespace FSH.WebApi.PostgreSQL.Initialization;

//internal interface IDatabaseInitializer
public interface IDatabaseInitializer
{
    Task InitializeDatabasesAsync(CancellationToken cancellationToken);
    //Task InitializeApplicationDbForTenantAsync(FSHTenantInfo tenant, CancellationToken cancellationToken);
}