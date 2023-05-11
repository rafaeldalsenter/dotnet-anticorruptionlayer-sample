using BookInfo.Code.Abstractions;

namespace BookInfo.Code;

internal class BookInfoParseCodeServices : IBookInfoParseCodeServices
{
    public Task<int> GetCodeAsync(string legacyCode, CancellationToken cancellationToken)
    {
        Console.WriteLine($"ParseCode - Get info by {legacyCode}");
        return Task.FromResult(new Random().Next());
    }
}