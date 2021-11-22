using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProjGroup1.Models;


namespace FinalProjGroup1
{
    public class StudentInfoContext : DbContext
    {
        public StudentInfoContext(DbContextOptions options)
            : base(options)
        {
        }

        
        protected override void OnModelCreating(ModelBuilder model)
        {
            /*model.Entity<StudentInfo>(entity =>
            {
                entity.HasData(new StudentInfo
                {
                    StudentID = 1,
                    FullName = "Test Subject",
                    BirthDate = DateTime.Now,
                    Program = "TestSubject",
                    ProgramYear = 1
                });
            });*/
        }

        public DbSet<StudentInfo> Student { get; set; }



    }
}
