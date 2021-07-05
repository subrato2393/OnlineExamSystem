using Microsoft.EntityFrameworkCore;
using OnlineExam.Organization.Entities;

namespace OnlineExam.Organization.Contexts
{
    public class OrganizationDbContext : DbContext
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;

        public OrganizationDbContext(string connectionString,string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString,
                optionsBuilder => optionsBuilder.MigrationsAssembly(_migrationAssemblyName));
           
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Batch> Batches { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseAssign> CourseAssigns { get; set; }
        public DbSet<CourseTag> CourseTags { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<ExamSchedule> ExamSchedules { get; set; }
        public DbSet<Participants> Participants { get; set; }
        public DbSet<QusAndAns> QusAndAns { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Trainer> Trainers { get; set; } 
    }
}
