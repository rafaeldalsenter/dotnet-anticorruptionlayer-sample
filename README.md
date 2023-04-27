# [WIP] dotnet-anticorruptionlayer-sample

Example of using the anti-corruption layer pattern

Is this project, it's illustrated how to use this pattern to avoid corrupting the Application (or Domain) layer with changes external projects.

--

### Application context

The Application has a UseCase corresponding to buy a book Operation. The first thing to get is detailed information about this book, through an external project. The interface to this external service requires the code used to be a string.

The problema is this external service will start using the code pattern, integer type. To avoid changing the Application layer, the solution is to create an Anti-corruption layer that will mediate this communication, converting the string code to the new integer code.

The first structure of the App is connected to the BookInfo API project, where the identifier used is 'code' of type string

<image>

The new structure of the App is connected to the new BookInfo API, where it has the Anti-corruption layer intermediating, converting the codes. So, even with the API change, we managed to keep the Application layer intact

--

### References

- [Azure Architecture - Anti-corruption Layer pattern](https://learn.microsoft.com/en-us/azure/architecture/patterns/anti-corruption-layer)