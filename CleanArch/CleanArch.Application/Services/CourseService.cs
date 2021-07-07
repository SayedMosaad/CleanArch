using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Core.Bus;
using CleanArch.Domains.Commands;
using CleanArch.Domains.Interfaces;


namespace CleanArch.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _Courserepository;
        private readonly IMediatorHandler _mediatorHandler;
        public CourseService(ICourseRepository Courserepository, IMediatorHandler mediatorHandler)
        {
            _Courserepository = Courserepository;
            _mediatorHandler = mediatorHandler;
        }

        public void Create(CourseViewModel courseViewModel)
        {
            var createCourseCommand = new CreateCourseCommand(courseViewModel.Name,courseViewModel.Description,courseViewModel.ImageUrl);

            _mediatorHandler.SendCommand(createCourseCommand);
        }

        public CourseViewModel GetCourses()
        {
            return new CourseViewModel
            {
                Courses = _Courserepository.GetCourses()
            };
        }
    }
}
