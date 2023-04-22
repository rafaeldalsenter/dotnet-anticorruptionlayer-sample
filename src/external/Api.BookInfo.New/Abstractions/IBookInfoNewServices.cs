using Application.Shared.Dtos;

namespace Api.BookInfo.New.Abstractions;

public interface IBookInfoNewServices
{
    Task<BookInfoDto?> GetAsync(int id, CancellationToken cancellationToken);
}