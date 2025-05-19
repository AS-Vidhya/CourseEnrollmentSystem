using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CourseEnrollmentSystem.Models
{
	public class Student
	{
		[Key]
		public int StudentId { get; set; }
		[Required]
		public string StudentName { get; set; }
		public int CourseId { get; set; }
		public virtual Course EnrolledCourse { get; set; }
	}
}