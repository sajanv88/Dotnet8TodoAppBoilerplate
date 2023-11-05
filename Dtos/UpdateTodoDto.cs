namespace Dotnet8TodoAppBoilerplate.Dtos;

public record UpdateTodoDto
{
    public string Title { get; set; } = String.Empty;
    public string Description { get; set; } = String.Empty;
    public bool IsCompleted { get; set; }
}
