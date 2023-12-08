using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TraininggSystem.Models;

namespace TraininggSystem.Data
{
    public class TraininggSystemContext : DbContext
    {
        public TraininggSystemContext (DbContextOptions<TraininggSystemContext> options)
            : base(options)
        {
        }

        public DbSet<TraininggSystem.Models.Student> Student { get; set; } = default!;

        public DbSet<TraininggSystem.Models.Instructor> Instructor { get; set; } = default!;

        public DbSet<TraininggSystem.Models.Exam> Exam { get; set; } = default!;

        public DbSet<TraininggSystem.Models.Courses> Courses { get; set; } = default!;

        public DbSet<TraininggSystem.Models.Enrolment> Enrolment { get; set; } = default!;

        internal Task CheckPasswordSignInAsync(Student user, string? password, bool v)
        {
            throw new NotImplementedException();
        }
    }
}
