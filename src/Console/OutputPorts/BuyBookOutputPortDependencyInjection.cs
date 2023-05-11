using Application.UseCases.BuyBook.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace Console.OutputPorts;

internal static class BuyBookOutputPortDependencyInjection
{
    public static IServiceCollection AddBuyBookOutputPort(this IServiceCollection services) =>
        services.AddScoped<IBuyBookOutputPort, BuyBookOutputPort>();
}