using OnlineExam.DataAccessLayar;
using OnlineExam.Organization.Contexts;
using OnlineExam.Organization.Repositories;

namespace OnlineExam.Organization.UnitOfWorks
{
    public class CourseUnitOfWork : UnitOfWork, ICourseUnitOfWork
    {
        public ICourseRepository CourseRepository { get; set; }
        public CourseUnitOfWork(ICourseRepository courseRepository,
            OrganizationDbContext context)
            :base(context)
        {
            CourseRepository = courseRepository;
        }
    }
}
