using Gimnasio.API.Application.Interfaces.Repositories;
using Gimnasio.API.Infrastructure.Mappers;
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
        /// <summary>
        /// Nivel de compatibilidad por defecto (SQL Server 2022).
        /// Se puede sobrescribir por entorno con la clave
        /// Database:CompatibilityLevel (appsettings.local.json o variable de entorno
        /// Database__CompatibilityLevel). Ejemplos:
        ///   100 = SQL Server 2008/R2, 110 = 2012, 120 = 2014, 130 = 2016,
        ///   140 = 2017, 150 = 2019, 160 = 2022.
        /// Con niveles menores a 130 EF genera SQL compatible (evita OPENJSON) y
        /// con niveles menores a 110 usa ROW_NUMBER en paginación en lugar de
        /// OFFSET/FETCH, manteniendo retrocompatibilidad sin cambiar código.
        /// </summary>
        private const int CompatibilidadPorDefecto = 160;

        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var compatibilidad = ResolverCompatibilidad(configuration);

            Console.WriteLine($"[Infrastructure] SQL Server CompatibilityLevel EF: {compatibilidad}");

            services.AddDbContext<GimnasioDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("GimnasioConnection"),
                    sql => sql.UseCompatibilityLevel(compatibilidad)));

            services.AddSingleton<UsuarioMapper>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();

            return services;
        }

        private static int ResolverCompatibilidad(IConfiguration configuration)
        {
            var valor = configuration["Database:CompatibilityLevel"];

            return int.TryParse(valor, out var nivel) && nivel >= 100 && nivel <= 170
                ? nivel
                : CompatibilidadPorDefecto;
        }
    }
}
