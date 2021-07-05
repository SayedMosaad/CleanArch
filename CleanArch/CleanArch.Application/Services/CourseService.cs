using AutoMapper;
using AutoMapper.QueryableExtensions;
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
        private IMapper _automaper;
        public CourseService(ICourseRepository Courserepository, IMediatorHandler bus, IMapper automapper)
        {
            _Courserepository = Courserepository;
            _bus = bus;
            _automaper = automapper;
        }

        public void CreateCourse(CourseViewModel model)
        {
            //var createCourseCommand = new CreateCourseCommand(model.Name,model.Description,model.ImageUrl);
            _bus.SendCommand(_automaper.Map<CreateCourseCommand>(model));
        }

        public IEnumerable<CourseViewModel> GetCourses()
        {
            return _Courserepository.GetCourses().ProjectTo<CourseViewModel>(_automaper.ConfigurationProvider);
        }
    }
}
