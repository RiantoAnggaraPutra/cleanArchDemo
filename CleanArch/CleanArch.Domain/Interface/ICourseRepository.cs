using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Domain.Interface
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetCourses();
    }
}
