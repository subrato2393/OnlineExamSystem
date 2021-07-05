using Microsoft.EntityFrameworkCore;
using OnlineExam.Organization.Entities;

namespace OnlineExam.Organization.Contexts
{
    public interface IOrganizationDbContext
    {
        DbSet<Batch> Batches { get; set; }
        DbSet<CourseAssign> CourseAssigns { get; set; }
        DbSet<Course> Courses { get; set; }
        DbSet<CourseTag> CourseTags { get; set; }
        DbSet<Exam> Exams { get; set; }
        DbSet<ExamSchedule> ExamSchedules { get; set; }
        DbSet<Participants> Participants { get; set; }
        DbSet<QusAndAns> QusAndAns { get; set; }
        DbSet<Tag> Tags { get; set; }
        DbSet<Trainer> Trainers { get; set; }
    }
}