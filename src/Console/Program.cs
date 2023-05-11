using Api.BookInfo.Legacy;
using Application.UseCases.BuyBook;
using Application.UseCases.BuyBook.Abstractions;
using BookInfo.AntiCorruptionLayer;
using Console.OutputPorts;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection()
    .AddBuyBookUseCase()
    .AddBuyBookOutputPort()
    .AddBookInfoAcl();
//.AddBookInfoLegacy();

var buyBookUseCase = services
    .BuildServiceProvider()
    .GetService<IBuyBookUseCase>();

await buyBookUseCase!.ExecuteAsync("AE565", CancellationToken.None);