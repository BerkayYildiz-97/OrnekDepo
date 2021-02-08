using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_School.Models.Entities
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Grade { get; set; }
        public List<StudentTeacher> StudentTeachers { get; set; }
        public virtual List<StudentLesson> StudentLessons { get; set; }
    }
}