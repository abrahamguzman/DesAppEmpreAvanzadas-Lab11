using Microsoft.EntityFrameworkCore;

namespace Lab11.Models
{
    public class SchoolContext : DbContext
    {
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        public SchoolContext(DbContextOptions<SchoolContext> options)
                 : base(options)
        {

        }
    }
}
