namespace Application.UseCases.BuyBook.Abstractions;

public interface IBuyBookUseCase
{
    Task ExecuteAsync(string bookCode, CancellationToken cancellationToken);
}