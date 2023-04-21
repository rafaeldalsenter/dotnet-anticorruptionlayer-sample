namespace Application.UseCases.BuyBook.Abstractions;

public interface IBuyBookOutputPort
{
    void NotFound();

    void Success();
}