using Autofac;
using OnlineExam.Organization.Services;
using CourseBO = OnlineExam.Organization.BusinessObjects.Course;
using CourseEO = OnlineExam.Organization.Entities.Course;

namespace OnlineExam.Web.Areas.member.Models
{
    public class CourseModel
    {
        private readonly ICourseService _courseService;
        public CourseModel(ICourseService courseService)
        {
            _courseService = courseService;
        }
        public CourseModel()
        {
            _courseService = Startup.AutofacContainer.Resolve<ICourseService>();
        }
        public string Name { get; set; } 

        public void AddCourseInformation()
        {
            _courseService.AddCourseInfo(new CourseBO()
            {
                Name = Name
            });
        }
    }
}
