using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Domain.Interface;
using CleanArch.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServise (IServiceCollection services)
        {
            //Apllication Layer
            services.AddScoped<ICourseServise, CourseServise>();

            //Infra.Data Layer
            services.AddScoped<ICourseRepository, CourseRepository>();  
        }
    }
}