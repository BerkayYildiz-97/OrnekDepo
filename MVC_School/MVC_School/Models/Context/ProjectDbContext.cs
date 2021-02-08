using MVC_School.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_School.Models.Context
{
    public class ProjectDbContext:DbContext
    {
        public ProjectDbContext()
        {
            Database.Connection.ConnectionString = "Server=(localdb)\\MSSQLLocalDB;Database=SchoolProjectDB;Trusted_Connection=True;";
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<StudentLesson> StudentLessons { get; set; }
        public DbSet<StudentTeacher> StudentTeachers { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<AppUserAndRole> AppUserAndRoles { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentLesson>().HasKey(x => new { x.StudentId, x.LessonId });
            modelBuilder.Entity<StudentTeacher>().HasKey(x => new { x.StudentId, x.TeacherId });
            modelBuilder.Entity<AppUserAndRole>().HasKey(x => new { x.AppUserId, x.RoleId });
            base.OnModelCreating(modelBuilder);
        }

    }
}