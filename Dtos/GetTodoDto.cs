namespace Dotnet8TodoAppBoilerplate.Dtos
{
    public record GetTodoDto
    {
        public string Title { get; set; } = String.Empty;
        public int Id { get; set; }
        public string Description { get; set; } = String.Empty;
        public bool IsCompleted { get; set; }
    }
}
