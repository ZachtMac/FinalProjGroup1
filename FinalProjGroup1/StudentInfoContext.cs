using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace FinalProjGroup1
{
    public class StudentInfoContext : DbContext
    {
        public StudentInfoContext(DbContextOptions<StudentInfoContext> options)
            : base(options)
        {
        }

        public DbSet<StudentInfoContext> TodoItems { get; set; } = null!;

    }
}
