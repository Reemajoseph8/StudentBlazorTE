using Microsoft.EntityFrameworkCore;
using System;

namespace StudentBlazorTE.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
                : base(options)
        {
        }
        public DbSet<Student> Student { get; set; }
    }
}
