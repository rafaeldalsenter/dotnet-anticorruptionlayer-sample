using Application.Shared;
using Microsoft.Extensions.DependencyInjection;

namespace Api.BookInfo.Legacy;

public static class BookInfoLegacyDependencyInjection
{
    public static IServiceCollection AddBookInfoLegacy(IServiceCollection services) 
        => services.AddScoped<IBookInfoServices, BookInfoLegacyServices>();
}