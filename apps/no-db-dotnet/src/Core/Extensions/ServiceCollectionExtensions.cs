using NoDbDotnet.APIs;

namespace NoDbDotnet;

public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Add services to the container.
    /// </summary>
    public static void RegisterServices(this IServiceCollection services)
    {
        services.AddScoped<IPackagesService, PackagesService>();
    }
}
