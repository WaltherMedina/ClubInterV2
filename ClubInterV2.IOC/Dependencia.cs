using ClubInterV2.BLL.Servicios;
using ClubInterV2.BLL.Servicios.Contrato;
using ClubInterV2.DAL.DBContext;
using ClubInterV2.DAL.Repositorios;
using ClubInterV2.DAL.Repositorios.Contrato;
using ClubInterV2.Utility;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubInterV2.IOC
{
    public static class Dependencia
    {
        public static void InyectarDependencias(this IServiceCollection services, IConfiguration configuration) {
            services.AddDbContext<ClubinterV2Context>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });

            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            services.AddAutoMapper(typeof(AutoMapperProfile));

            services.AddScoped<IRolService, RolService>();

            services.AddScoped<IUsuarioService, UsuarioService>();

            /*services.AddScoped<IRolService, RolService>();

            services.AddScoped<IRolService, RolService>();

            services.AddScoped<IRolService, RolService>();

            services.AddScoped<IRolService, RolService>();*/



            services.AddScoped<IRolService, RolService>();
            services.AddScoped<IRolService, RolService>();
        }
    }
}
