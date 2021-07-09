using OnlineExam.DataAccessLayar;
using OnlineExam.Organization.Contexts;
using OnlineExam.Organization.Repositories;

namespace OnlineExam.Organization.UnitOfWorks
{
    public class CourseUnitOfWork : UnitOfWork, ICourseUnitOfWork
    { 
        public ICourseRepository CourseRepository { get; set; }
        public ITagRepository TagRepository { get; set; }
        public ICourseTagRepository CourseTagRepository { get; set; }
        public CourseUnitOfWork(ITagRepository tagRepository,
            ICourseRepository courseRepository,
            ICourseTagRepository courseTagRepository,
            OrganizationDbContext context)
            :base(context)
        {
            CourseRepository = courseRepository;
            TagRepository = tagRepository;
            CourseTagRepository = courseTagRepository;
        }
    }
}
