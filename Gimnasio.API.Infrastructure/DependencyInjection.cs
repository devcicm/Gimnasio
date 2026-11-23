using Gimnasio.API.Application.Interfaces.Repositories;
using Gimnasio.API.Infrastructure.Persistence.Context;
using Gimnasio.API.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio.API.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {            
            services.AddDbContext<GimnasioDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("GimnasioConnection")));

            services.AddScoped<IUsuarioRepository, UsuarioRepository>();

            return services;
        }
    }
}
