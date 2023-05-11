using Application.UseCases.BuyBook.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace Application.UseCases.BuyBook;

public static class BuyBookUseCaseDependencyInjection
{
    public static IServiceCollection AddBuyBookUseCase(this IServiceCollection services) =>
        services.AddScoped<IBuyBookUseCase, BuyBookUseCase>();
}