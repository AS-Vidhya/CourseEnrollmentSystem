using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CourseEnrollmentSystem.Models
{
    public class CourseContext : DbContext
	{
        public CourseContext() : base("CourseContext") { }
        public DbSet<Course> Courses { get; set; }
		public DbSet<Student> Students { get; set; }

	}
}