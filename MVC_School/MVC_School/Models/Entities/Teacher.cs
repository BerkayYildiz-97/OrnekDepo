using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_School.Models.Entities
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual Lesson Lesson { get; set; }
        public virtual List<StudentTeacher> StudentTeachers { get; set; }

    }
}