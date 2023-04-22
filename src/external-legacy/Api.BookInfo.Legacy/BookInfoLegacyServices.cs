using Application.Shared;
using Application.Shared.Dtos;

namespace Api.BookInfo.Legacy;

internal class BookInfoLegacyServices : IBookInfoServices
{
    public Task<BookInfoDto?> GetAsync(string code, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}