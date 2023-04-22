using Api.BookInfo.New.Abstractions;
using Application.Shared.Dtos;

namespace Api.BookInfo.New;

internal class BookInfoNewServices : IBookInfoNewServices
{
    public Task<BookInfoDto?> GetAsync(int id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}