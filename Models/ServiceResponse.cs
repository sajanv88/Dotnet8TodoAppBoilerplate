namespace Dotnet8TodoAppBoilerplate.Models
{
    public record ServiceResponse<T>
    {
        public T? Data { get; set; }
        public string Message { get; set; } = String.Empty;
        public bool Status { get; set; }
    }
}
