using Autofac;
using OnlineExam.Membership;
using OnlineExam.Organization.Services;
using System.Threading.Tasks;
using CourseBO = OnlineExam.Organization.BusinessObjects.Course;
using CourseEO = OnlineExam.Organization.Entities.Course;

namespace OnlineExam.Web.Areas.member.Models
{
    public class CourseModel
    {
        private readonly ICourseService _courseService;
        private readonly UserManager _userManager;
        public CourseModel(ICourseService courseService,
            UserManager userManager)
        {
            _courseService = courseService;
            _userManager = userManager;
        }
        public CourseModel()
        {
            _courseService = Startup.AutofacContainer.Resolve<ICourseService>();
            _userManager = Startup.AutofacContainer.Resolve<UserManager>();
        }
        public string Name { get; set; }
        public string Code { get; set; }
        public double CourseDuration { get; set; }
        public double Credit { get; set; }
        public string Outline { get; set; }

        public async Task AddCourseInformation(string userName)
        {
            var user = await _userManager.FindByNameAsync(userName);
            
            _courseService.AddCourseInfo(new CourseBO()
            {
                Name = Name,
                Code = Code,
                CourseDuration = CourseDuration,
                Credit = Credit,
                Outline = Outline,
                UserId = user.Id,
            });
        }
    }
}
