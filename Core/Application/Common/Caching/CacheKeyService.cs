using FSH.WebApi.Application.Common.Interfaces;

namespace FSH.WebApi.Application.Common.Caching;

public interface ICacheKeyService : IScopedService
{
    public string GetCacheKey(string name, object id, bool includeTenantId = true);
}