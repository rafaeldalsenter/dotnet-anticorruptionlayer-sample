using BookInfo.Code.Abstractions;

namespace BookInfo.Code;

internal class BookInfoParseCodeServices : IBookInfoParseCodeServices
{
    public Task<int> GetCodeAsync(string legacyCode, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}