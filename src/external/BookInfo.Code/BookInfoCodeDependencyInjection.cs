using BookInfo.Code.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace BookInfo.Code;

public static class BookInfoCodeDependencyInjection
{
    public static IServiceCollection AddBookInfoParseCode(this IServiceCollection services) =>
        services.AddScoped<IBookInfoParseCodeServices, BookInfoParseCodeServices>();
}