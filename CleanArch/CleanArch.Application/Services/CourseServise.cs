using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Commands;
using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Application.Services
{
    public class CourseServise : ICourseServise
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMediatorHandler _bus;
        public CourseServise(ICourseRepository courseRepository, IMediatorHandler bus)
        {
            _courseRepository = courseRepository;
            _bus = bus;
        }

        public void Create(CourseViewModel courseViewModel )
        {
            var CreateCourseModel = new CreateCourseCommand(
                    courseViewModel.Name,
                    courseViewModel.Description,
                    courseViewModel.ImageUrl
                );
            _bus.SendCommand(CreateCourseModel);
        }

        public CourseViewModel GetCourses()
        {
            return new CourseViewModel() { Courses = _courseRepository.GetCourses() };

        }
    }
}
