using CleanArch.Domains.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domains.Interfaces
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetCourses();
        void ADD(Course course);
    }
}
