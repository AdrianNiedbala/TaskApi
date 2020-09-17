using Microsoft.EntityFrameworkCore;

namespace TaskApi.Models
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options) { }

        public DbSet<Task> Tasks { get; set; }
    }
}