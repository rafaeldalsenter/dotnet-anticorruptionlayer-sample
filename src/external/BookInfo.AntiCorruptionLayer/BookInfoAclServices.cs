using Api.BookInfo.New.Abstractions;
using Application.Shared;
using Application.Shared.Dtos;
using BookInfo.Code.Abstractions;

namespace BookInfo.AntiCorruptionLayer;

internal class BookInfoAclServices : IBookInfoServices
{
    private readonly IBookInfoNewServices _bookInfoNewServices;
    private readonly IBookInfoParseCodeServices _bookInfoParseCodeServices;

    public BookInfoAclServices(IBookInfoNewServices bookInfoNewServices,
        IBookInfoParseCodeServices bookInfoParseCodeServices)
    {
        _bookInfoNewServices = bookInfoNewServices;
        _bookInfoParseCodeServices = bookInfoParseCodeServices;
    }

    public Task<BookInfoDto?> GetAsync(string code, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}