using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CourseEnrollmentSystem.Models
{
	public class Course
	{
		[Key]
		public int CourseId { get; set; }
		[Required]
		public string CourseName { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}