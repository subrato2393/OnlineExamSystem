using Autofac;
using OnlineExam.Membership;
using OnlineExam.Organization.Services;
using System.ComponentModel.DataAnnotations;
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

        [Required]
        [Display(Name ="Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }

        [Required]
        [Display(Name = "Course Duration")]
        public double? CourseDuration { get; set; }

        [Required]
        [Display(Name = "Credit")]
        public double? Credit { get; set; }

        [Required]
        [Display(Name = "Outline")]
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
