using Application.Interfaces.Auth;
using Application.Services.Auth;
using Infrastructure.Data;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.AppStart
{
    public static class DIRegistry
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IRepository, Repository>();
            services.AddScoped<IDbFactory, DbFactory>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IPasswordHelper, PasswordHelper>();
            //services.AddDbContext<HrmsDatabaseContext>(ServiceLifetime.Transient);
            return services;
        }
    }
}
