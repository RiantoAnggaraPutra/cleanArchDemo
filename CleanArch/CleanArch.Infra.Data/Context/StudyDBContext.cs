using CleanArch.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infra.Data.Context
{
    public class StudyDBContext : DbContext
    {
        public StudyDBContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Course> Courses { get; set; }
    }
}

namespace CleanArch.Infra.Data
{
    public class StudyDbContext
    {
    }
}