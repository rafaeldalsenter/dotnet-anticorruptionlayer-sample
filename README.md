# dotnet-anticorruptionlayer-sample

Example of using the anti-corruption layer pattern

Is this project, it's illustrated how to use this pattern to avoid corrupting the Application (or Domain) layer with changes external projects.

## Application context

The Application has a UseCase corresponding to buy a book Operation. The first thing to get is detailed information about this book, through an external project (Api.BookInfo.Legacy). The interface to this external service requires the code used to be a string.

<img src="https://github.com/rafaeldalsenter/dotnet-anticorruptionlayer-sample/assets/10137467/f057ec66-470d-4fdf-a327-403485787655.png" width="300">
<br>
<br>
The Api.BookInfo.Legacy API will be discontinued, a new API called Api.BookInfo.New will have to be used. This API uses integer type code to identify books. So that this change does not affect the Application layer, an intermediate project (BookInfo.AntiCorruptionLayer) was created, responsible for "translating the code" to the new format (integer type):

<br>
<br>
<img src="https://github.com/rafaeldalsenter/dotnet-anticorruptionlayer-sample/assets/10137467/982f9461-d925-4493-858a-79dee0917d6c" width="350">

## Run

To execute the project, a Console application was created where the execution is printed in a terminal. In DI you can choose to use the new API (with the anti-corruption layer) and the old one:

```csharp
var services = new ServiceCollection()
    .AddBuyBookUseCase()
    .AddBuyBookOutputPort()
    .AddBookInfoAcl(); // <- new API (with anti-corruption layer)
//.AddBookInfoLegacy();   <- Legacy API
```

## References

- [Azure Architecture - Anti-corruption Layer pattern](https://learn.microsoft.com/en-us/azure/architecture/patterns/anti-corruption-layer)
- [Clean Architecture (Robert Martin)](https://www.amazon.com.br/Clean-Architecture-Craftsmans-Software-Structure/dp/0134494164)
