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
            model.Entity<StudentInfo>(entity =>
            {
                entity.HasData(new StudentInfo
                {
                    Id = 1,
                    FullName = "Zach McIntosh",
                    BirthDate = DateTime.Now,
                    Program = "Cyber",
                    ProgramYear = 2
                });
                entity.HasData(new StudentInfo
                {
                    Id = 2,
                    FullName = "Ben Hicks",
                    BirthDate = DateTime.Now,
                    Program = "Software",
                    ProgramYear = 2
                });
                entity.HasData(new StudentInfo
                {
                    Id = 3,
                    FullName = "Colby Nolasco",
                    BirthDate = DateTime.Now,
                    Program = "Software",
                    ProgramYear = 3
                });
            });

            model.Entity<StudentFood>(entity =>
            {
                entity.HasData(new StudentFood
                {
                    Id = 1,
                    FullName = "Colby Nolasco",
                    Breakfast = "Poptarts",
                    Lunch = "Hot Pockets",
                    Dinner = "Chicken"
                });
            });

            model.Entity<StudentGame>(entity =>
            {
                entity.HasData(new StudentGame
                {
                    Id = 1,
                    CreatorName = "NinjaKiwi",
                    Title = "Bloons TD 6",
                    Genre = "Strategy",
                    Version = "28.3"
                });
            });
        }

        public DbSet<StudentInfo> Student { get; set; }

        public DbSet<StudentFood> StudentFood { get; set; }

        public DbSet<StudentGame> StudentGame { get; set; }



    }
}
