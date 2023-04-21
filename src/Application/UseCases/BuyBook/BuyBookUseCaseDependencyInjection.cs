using Application.UseCases.BuyBook.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace Application.UseCases.BuyBook;

public static class BuyBookUseCaseDependencyInjection
{
    public static IServiceCollection AddBuyBookUseCase(IServiceCollection services)
    {
        return services.AddScoped<IBuyBookUseCase, BuyBookUseCase>();
    }
}