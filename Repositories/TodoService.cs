using AutoMapper;
using Dotnet8TodoAppBoilerplate.AppDbContext;
using Dotnet8TodoAppBoilerplate.Dtos;
using Dotnet8TodoAppBoilerplate.Models;
using Microsoft.EntityFrameworkCore;

namespace Dotnet8TodoAppBoilerplate.Repositories
{
    public class TodoService : ITodoService
    {
        private readonly Context _context;
        private readonly IMapper _mapper;
        public TodoService(Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<ServiceResponse<List<GetTodoDto>>> GetAllTodos()
        {
            var todos = await _context
                .Todos
                .Select(
                    c => _mapper.Map<GetTodoDto>(c))
                .ToListAsync();
            var response = new ServiceResponse<List<GetTodoDto>>();
            response.Data = todos;
            response.Message = "Success";
            response.Status = true;
            return response;
        }

        public async Task<ServiceResponse<int>> CreateTodo(CreateTodoDto newTodo)
        {
            var response = new ServiceResponse<int>();

            _context.Todos.Add(new Todo
            {
                Title = newTodo.Title, Description = newTodo.Description, IsCompleted = false
            });
            response.Data = await _context.SaveChangesAsync();
            response.Message = "Created successfully.";
            response.Status = true;
            return response;
        }

        public async Task<ServiceResponse<GetTodoDto>> GetTodoById(int id)
        {
            var response = new ServiceResponse<GetTodoDto>();
            var todo = await _context.Todos.SingleAsync(c => c.Id == id);
            if (todo is null)
            {
                response.Message = $"Todo not found for the id={id}";
                response.Status = false;
                throw new Exception($"Todo not found for the id={id}");
            }

            response.Data = _mapper.Map<GetTodoDto>(todo);
            response.Message = "Success";
            response.Status = true;
            return response;
        }

        public async Task<ServiceResponse<int>> UpdateTodo(UpdateTodoDto updateTodo, int id)
        {
            var response = new ServiceResponse<int>();
            var todo = await _context.Todos.SingleAsync(c => c.Id == id);
            if (todo is null)
            {
                response.Message = $"Todo not found for the id={id}";
                response.Status = false;
                throw new Exception($"Todo not found for the id={id}");
            }

            todo.Title = updateTodo.Title;
            todo.Description = updateTodo.Description;
            todo.IsCompleted = updateTodo.IsCompleted;
           
            response.Data = await _context.SaveChangesAsync();
            response.Message = "Success";
            response.Status = true;
            return response;
        }
    }
}
