using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_School.Models.Entities
{
    public class Manager
    {
       
        public int ManagerId { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}