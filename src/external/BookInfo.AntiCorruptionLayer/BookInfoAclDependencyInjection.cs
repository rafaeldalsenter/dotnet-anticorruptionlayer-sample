using Api.BookInfo.New;
using Application.Shared;
using BookInfo.Code;
using Microsoft.Extensions.DependencyInjection;

namespace BookInfo.AntiCorruptionLayer;

public static class BookInfoLegacyDependencyInjection
{
    public static IServiceCollection AddBookInfoLegacy(IServiceCollection services)
        => services.AddBookInfoNew()
            .AddBookInfoParseCode()
            .AddScoped<IBookInfoServices, BookInfoAclServices>();
}