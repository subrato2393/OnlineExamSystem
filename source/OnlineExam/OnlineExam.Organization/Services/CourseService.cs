using OnlineExam.Organization.UnitOfWorks;
using CourseBO = OnlineExam.Organization.BusinessObjects.Course;
using CourseEO = OnlineExam.Organization.Entities.Course;

namespace OnlineExam.Organization.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseUnitOfWork _courseUnitOfWork;
        public CourseService(ICourseUnitOfWork courseUnitOfWork)
        {
            _courseUnitOfWork = courseUnitOfWork;
        }

        public void AddCourseInfo(CourseBO courseBO)
        {
            var courseEntity = ConvertCourseBOToCourseEO(courseBO);
            _courseUnitOfWork.CourseRepository.Add(courseEntity);
            _courseUnitOfWork.Save();
        }

        private CourseEO ConvertCourseBOToCourseEO(CourseBO courseBO)
        {
           return new CourseEO()
            {
                Name=courseBO.Name
            };
        }
    }
}
