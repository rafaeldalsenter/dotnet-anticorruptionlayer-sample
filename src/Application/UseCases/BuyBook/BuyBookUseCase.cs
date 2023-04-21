using Application.Shared;
using Application.UseCases.BuyBook.Abstractions;

namespace Application.UseCases.BuyBook;

internal class BuyBookUseCase : IBuyBookUseCase
{
    private readonly IBookInfoServices _bookInfoServices;
    private readonly IBuyBookOutputPort _outputPort;
    
    public BuyBookUseCase(IBookInfoServices bookInfoServices,
        IBuyBookOutputPort outputPort)
    {
        _bookInfoServices = bookInfoServices;
        _outputPort = outputPort;
    }
    
    public async Task ExecuteAsync(string bookCode, CancellationToken cancellationToken)
    {
        var bookInfoDto = await _bookInfoServices.GetAsync(bookCode, cancellationToken);

        if (bookInfoDto is null)
        {
            _outputPort.NotFound();
            return;
        }
        
        // Continue...
        
        _outputPort.Success();
    }
}