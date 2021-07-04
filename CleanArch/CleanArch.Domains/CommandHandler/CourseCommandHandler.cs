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

namespace CleanArch.Domains.CommandHandler
{
    public class CourseCommandHandler : IRequestHandler<CreateCourseCommand, bool>
    {
        private ICourseRepository _courseRepository;
        public CourseCommandHandler(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }
        public Task<bool> Handle(CreateCourseCommand request, CancellationToken cancellationToken)
        {
            var course = new Course()
            {
                Name = request.Name,
                Description = request.Description,
                ImageUrl=request.ImageUrl
            };
            _courseRepository.ADD(course);
            return Task.FromResult(true);
        }
    }
}
