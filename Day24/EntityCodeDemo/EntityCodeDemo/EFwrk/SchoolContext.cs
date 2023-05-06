using EntityCodeDemo.EFwrk;
using System;
using System.Data.Entity;

namespace EntityCodeDemo
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base()
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}