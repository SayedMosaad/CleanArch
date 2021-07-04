using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Domains.Interfaces;
using CleanArch.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.IOC
{
    public class DependancyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // for the application layer
            services.AddScoped<ICourseService, CourseService>();

            // for the Infra.Data layer
            services.AddScoped<ICourseRepository, CourseRepository>();
        }
    }
}
