using OnlineExam.DataAccessLayar;
using OnlineExam.Organization.Repositories;

namespace OnlineExam.Organization.UnitOfWorks
{
    public interface ICourseUnitOfWork : IUnitOfWork
    {
        ICourseRepository CourseRepository { get; set; }
    }
}
