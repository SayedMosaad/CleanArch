using CleanArch.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domains.Commands
{
    public class CreateCourseCommand: CourseCommand
    {
        public CreateCourseCommand(string name, string description, string  imageUrl)
        {
            Name = name;
            Description = description;
            ImageUrl = imageUrl;
        }
    }
}
