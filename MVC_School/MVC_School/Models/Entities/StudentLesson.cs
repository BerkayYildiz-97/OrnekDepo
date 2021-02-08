using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_School.Models.Entities
{
    public class StudentLesson
    {
        public int StudentId { get; set; }
        public int LessonId { get; set; }
        public Student Student { get; set; }
        public Lesson Lesson { get; set; }
    }
}