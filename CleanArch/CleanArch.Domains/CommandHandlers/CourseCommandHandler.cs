using CleanArch.Domains.Commands;
using CleanArch.Domains.Interfaces;
using CleanArch.Domains.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArch.Domains.CommandHandlers
{
    public class CourseCommandHandler : IRequestHandler<CreateCourseCommand, bool>
    {
        private readonly ICourseRepository _courserepository;
        public CourseCommandHandler(ICourseRepository courseRepository)
        {
            _courserepository = courseRepository;
        }

        public Task<bool> Handle(CreateCourseCommand request, CancellationToken cancellationToken)
        {
            var course = new Course()
            {
                Name = request.Name,
                Description = request.Description,
                ImageUrl = request.ImageUrl
            };
            _courserepository.Add(course);
            return Task.FromResult(true);
        }
    }
}
