using Alumni_Project.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Alumni_Project.Data
{
    public class AlumniDbContext : DbContext
    {
        public AlumniDbContext(DbContextOptions<AlumniDbContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Mentor> Mentors { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}