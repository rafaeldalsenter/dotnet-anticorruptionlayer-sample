using Application.Shared.Dtos;

namespace Application.Shared;

public interface IBookInfoServices
{
    Task<BookInfoDto?> GetAsync(string code, CancellationToken cancellationToken);
}