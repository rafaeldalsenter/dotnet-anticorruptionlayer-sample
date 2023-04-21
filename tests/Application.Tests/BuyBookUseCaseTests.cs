using Application.Shared;
using Application.Shared.Dtos;
using Application.UseCases.BuyBook;
using Application.UseCases.BuyBook.Abstractions;
using AutoFixture;
using Moq;
using Moq.AutoMock;

namespace Application.Tests;

public class BuyBookUseCaseTests
{
    private Mock<IBookInfoServices> _bookInfoServices;
    private Mock<IBuyBookOutputPort> _outputPort;
    private IBuyBookUseCase _useCase;
    private Fixture _fixture;
    
    public BuyBookUseCaseTests()
    {
        var mocker = new AutoMocker();

        _fixture = new Fixture();

        _bookInfoServices = mocker.GetMock<IBookInfoServices>();
        _outputPort = mocker.GetMock<IBuyBookOutputPort>();
        _useCase = mocker.CreateInstance<BuyBookUseCase>();
    }

    [Fact]
    public async Task MustNotFoundWhenBookInfoIsNull()
    {
        // Arrange
        var input = _fixture.Create<string>();
        _bookInfoServices.Setup(x => x.GetAsync(input, It.IsAny<CancellationToken>()))
            .ReturnsAsync(null as BookInfoDto);

        // Act
        await _useCase.ExecuteAsync(input, It.IsAny<CancellationToken>());

        // Assert
        _outputPort.Verify(x => x.NotFound(), Times.Once);
        _outputPort.VerifyNoOtherCalls();
    }
}