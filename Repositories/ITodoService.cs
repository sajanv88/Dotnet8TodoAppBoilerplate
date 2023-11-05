using Dotnet8TodoAppBoilerplate.Dtos;
using Dotnet8TodoAppBoilerplate.Models;

namespace Dotnet8TodoAppBoilerplate.Repositories
{
    public interface ITodoService
    {
        Task<ServiceResponse<List<GetTodoDto>>> GetAllTodos();
        Task<ServiceResponse<int>> CreateTodo(CreateTodoDto newTodo);
        
        Task<ServiceResponse<GetTodoDto>> GetTodoById(int id);
        
        Task<ServiceResponse<int>> UpdateTodo(UpdateTodoDto updateTodo, int id);

        
    }
}
