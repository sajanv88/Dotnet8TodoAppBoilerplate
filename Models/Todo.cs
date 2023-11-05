using System.ComponentModel.DataAnnotations;

namespace Dotnet8TodoAppBoilerplate.Models
{
    public class Todo
    {
        [Required]
        [MinLength(10, ErrorMessage = "Minmum character is 10.")]
        [MaxLength(100, ErrorMessage = "Maximum limit is 100 character.")]
        public string? Title { get; set; }
        public string? Description { get; set; }
        public bool IsCompleted { get; set; } = false;
        public int Id { get; set; }
    }
}
