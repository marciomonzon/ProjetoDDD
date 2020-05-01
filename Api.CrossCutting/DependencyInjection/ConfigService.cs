using Api.Domain.Interfaces.Services.User;
using Api.Services.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigService
    {
        public static void ConfigureDependenciesService(IServiceCollection serviceCollection)
        {
            // transient é: cada vez que usa IUserService coloca uma instancia
            serviceCollection.AddTransient<IUserService, UserService>();
            serviceCollection.AddTransient<ILoginService, LoginService>();

            // addScoped - usa a mesma instancia para varios metodos que usam a IUserService .. muda o escopo se apertar f5
            // é por ciclo de vida

            // addSingleton - não muda.. uma vez só... 
        }
    }
}
