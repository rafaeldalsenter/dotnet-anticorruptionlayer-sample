namespace Application.Shared.Dtos;

public record BookInfoDto(string Code,
    string Name, 
    string[] Authors,
    string Description,
    decimal Price);