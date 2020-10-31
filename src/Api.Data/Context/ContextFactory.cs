using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Api.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {
            var connectionString = "Server=localhost;Port=5432;Database=DBApi;UID=postgres;PWD=postgres";
            var optionBuilder = new DbContextOptionsBuilder<MyContext>();
            optionBuilder.UseNpgsql(connectionString);
            return new MyContext(optionBuilder.Options);
        }
    }
}
