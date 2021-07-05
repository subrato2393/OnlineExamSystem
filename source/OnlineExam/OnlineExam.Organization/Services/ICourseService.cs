using OnlineExam.Organization.Entities;
using CourseBO = OnlineExam.Organization.BusinessObjects.Course;
using CourseEO = OnlineExam.Organization.Entities.Course;

namespace OnlineExam.Organization.Services
{
    public interface ICourseService
    {
        void AddCourseInfo(CourseBO courseBo);
    }
}