using Dotnet8TodoAppBoilerplate.Models;
using Microsoft.EntityFrameworkCore;

namespace Dotnet8TodoAppBoilerplate.AppDbContext;

public class Context: DbContext
{
    public Context(DbContextOptions<Context> options):base(options)
    {
        
    }
    
    public DbSet<Todo> Todos => Set<Todo>();
}
