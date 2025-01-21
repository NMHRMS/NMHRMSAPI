using Application.Interfaces.Auth;
using Application.Interfaces.Employee;
using Application.Interfaces.Master;
using Application.Services.Auth;
using Application.Services.Employee;
using Application.Services.Master;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc.Infrastructure;
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
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddHttpContextAccessor();
            services.AddScoped<IMasterService, MasterService>();
            //services.AddDbContext<HrmsDatabaseContext>(ServiceLifetime.Transient);
            return services;
        }
    }
}
