using Application.Shared;
using Application.Shared.Dtos;

namespace Api.BookInfo.Legacy;

internal class BookInfoLegacyServices : IBookInfoServices
{
    public Task<BookInfoDto?> GetAsync(string code, CancellationToken cancellationToken)
    {
        Console.WriteLine($"LegacyAPI - Get info by {code}");
        return Task.FromResult(default(BookInfoDto));
    }
}