using Api.BookInfo.New.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace Api.BookInfo.New;

public static class BookInfoNewDependencyInjection
{
    public static IServiceCollection AddBookInfoNew(this IServiceCollection services) 
        => services.AddScoped<IBookInfoNewServices, BookInfoNewServices>();
}