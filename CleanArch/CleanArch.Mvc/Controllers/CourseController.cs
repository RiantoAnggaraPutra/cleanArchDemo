using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CleanArch.Mvc.Controllers
{
    [Authorize]
    public class CourseController : Controller
    {

        private ICourseServise _courseServise;

        public CourseController(ICourseServise courseService)
        {
            _courseServise = courseService;
        }

        public IActionResult Index()
        {
            CourseViewModel model = _courseServise.GetCourses();

            return View(model);
        }
    }
}