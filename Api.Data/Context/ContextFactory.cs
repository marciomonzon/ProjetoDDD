using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Api.Data.Context
{
    /// <summary>
    /// serve para criar banco e tabela
    /// em tempo de design, mais dinamico
    /// ele prove uma conexao.
    /// </summary>
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {
            // para as Migrations
            var connectionString = @"Server=LAPTOP-N139I33O\SQLEXPRESS;Database=Course;User Id=sa;Password=123456;";
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new MyContext(optionsBuilder.Options);
        }
    }
}
