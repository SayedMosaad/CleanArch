using CleanArch.Domains.Interfaces;
using CleanArch.Domains.Models;
using CleanArch.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Data.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly UniversityDBContext _context;

        public CourseRepository(UniversityDBContext context)
        {
            _context = context;
        }

        public void ADD(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
        }

        public IQueryable<Course> GetCourses()
        {
            return _context.Courses;
        }
    }
}
