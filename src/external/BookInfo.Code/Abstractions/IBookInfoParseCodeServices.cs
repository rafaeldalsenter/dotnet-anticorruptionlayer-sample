namespace BookInfo.Code.Abstractions;

public interface IBookInfoParseCodeServices
{
    Task<int> GetCodeAsync(string legacyCode, CancellationToken cancellationToken);
}