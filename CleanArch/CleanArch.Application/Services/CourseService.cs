using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domains.Commands;
using CleanArch.Domains.Core.Bus;
using CleanArch.Domains.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Services
{
    public class CourseService : ICourseService
    {
        private ICourseRepository _Courserepository;
        private IMediatorHandler _bus;
        public CourseService(ICourseRepository Courserepository, IMediatorHandler bus)
        {
            _Courserepository = Courserepository;
            _bus = bus;
        }

        public void CreateCourse(CourseViewModel model)
        {
            var createCourseCommand = new CreateCourseCommand(model.Name,model.Description,model.ImageUrl);
            _bus.SendCommand(createCourseCommand);
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
