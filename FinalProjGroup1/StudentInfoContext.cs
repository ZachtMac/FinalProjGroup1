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

        public DbSet<StudentInfo> Student { get; set; } = null!;



    }
}
