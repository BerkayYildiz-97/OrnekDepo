using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_School.Models.Entities
{
    public class Lesson
    {
        public int LessonId { get; set; }
        public string Issue { get; set; }
        public string Content { get; set; }
        public virtual List<Teacher> Teachers { get; set; }
        public virtual List<StudentLesson> StudentLessons { get; set; }
    }
}