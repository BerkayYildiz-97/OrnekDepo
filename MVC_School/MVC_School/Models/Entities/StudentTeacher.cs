using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_School.Models.Entities
{
    public class StudentTeacher
    {
        public int StudentId { get; set; }
        public int TeacherId { get; set; }
        public Student Student { get; set; }
        public Teacher Teacher { get; set; }
       
    }
}