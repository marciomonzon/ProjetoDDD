using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigRepository
    {
        public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection)
        {
            // conexao de banco fica como scoped
            serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            serviceCollection.AddScoped<IUserRepository, UserRepository>();

            serviceCollection.AddDbContext<MyContext>(
                options => options.UseSqlServer(@"Server=LAPTOP-N139I33O\SQLEXPRESS;Database=Course;User Id=sa;Password=123456;")
                );
        }
    }
}
