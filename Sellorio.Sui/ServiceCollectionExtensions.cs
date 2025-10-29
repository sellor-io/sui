using Microsoft.Extensions.DependencyInjection;
using Sellorio.Sui.Services;

namespace Sellorio.Sui;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddAoServices(this IServiceCollection services)
    {
        return services.AddScoped<IResultPopupService, ResultPopupService>();
    }
}
