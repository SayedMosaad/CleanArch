using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Domain.Core.Bus;
using CleanArch.Domains.CommandHandlers;
using CleanArch.Domains.Commands;
using CleanArch.Domains.Interfaces;
using CleanArch.Infra.Bus;
using CleanArch.Infra.Data.Context;
using CleanArch.Infra.Data.Repositories;
using MediatR;
using Microsoft.Extensions.DependencyInjection;


namespace CleanArch.Infra.IOC
{
    public class DependancyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain InMemory MediatR
            services.AddScoped<IMediatorHandler, InMemoryBus>();

            //Domain Handler
            services.AddScoped<IRequestHandler<CreateCourseCommand, bool>, CourseCommandHandler>();

            // for the application layer
            services.AddScoped<ICourseService, CourseService>();

            // for the Infra.Data layer
            services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<UniversityDBContext>();

        }
    }
}
