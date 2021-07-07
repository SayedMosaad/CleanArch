using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domains.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace CleanArch.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;
        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }
        
        [HttpPost]
        public IActionResult Post([FromBody] Course course)
        {
            var model = new CourseViewModel
            {
                Name=course.Name,
                Description=course.Description,
                ImageUrl=course.ImageUrl
            };
            _courseService.Create(model);
            return Ok(model);
        }

    }
}
