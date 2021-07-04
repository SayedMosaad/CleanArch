﻿using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
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
        public CourseService(ICourseRepository Courserepository)
        {
            _Courserepository = Courserepository;
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
