
using Just_Project.Data.Entities;
using Just_Project.Data.Repositories;
using Just_Project.Data.Repositories.Interface;
using Just_Project.Domain.Services;
using Just_Project.Domain.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Just_Project.Infrastructure.IoC
{
   
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IRoleServices, RoleServices>();
            services.AddTransient<IGenericRepository<Roles>, GenericRepository<Roles>>();
        }

    }
}
