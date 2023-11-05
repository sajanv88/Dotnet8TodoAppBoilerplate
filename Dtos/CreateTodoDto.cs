namespace Dotnet8TodoAppBoilerplate.Dtos;

public record CreateTodoDto
{
    public string Title { get; set; } = String.Empty;
    public string Description { get; set; } = String.Empty;
}