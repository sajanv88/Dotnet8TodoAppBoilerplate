using AutoMapper;
using Dotnet8TodoAppBoilerplate.Dtos;
using Dotnet8TodoAppBoilerplate.Models;

namespace Dotnet8TodoAppBoilerplate;

public class AutoMapperProfile: Profile
{
    public AutoMapperProfile()
    {
        CreateMap<Todo, GetTodoDto>();
    }
}
