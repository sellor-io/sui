using Microsoft.Extensions.DependencyInjection;
using MudBlazor.Services;
using Sellorio.Sui.Services;

namespace Sellorio.Sui;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddSui(this IServiceCollection services)
    {
        services.AddMudServices();
        return services.AddScoped<IResultPopupService, ResultPopupService>();
    }
}
