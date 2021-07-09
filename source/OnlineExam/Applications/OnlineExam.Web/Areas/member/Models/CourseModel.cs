using Autofac;
using Microsoft.AspNetCore.Mvc.Rendering;
using OnlineExam.Membership;
using OnlineExam.Organization.Entities;
using OnlineExam.Organization.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CourseBO = OnlineExam.Organization.BusinessObjects.Course;
using CourseEO = OnlineExam.Organization.Entities.Course;
using CourseTagBO = OnlineExam.Organization.BusinessObjects.CourseTag;

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

        public Guid Id { get; set; }

        [Required]
        [Display(Name = "Name")]
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

        public List<SelectListItem> Tags { get; set; }

        public IList<Guid> TagId { get; set; }

        public async Task AddCourseInformation(string userName)
        {
            var user = await _userManager.FindByNameAsync(userName);

            var courseId = _courseService.AddCourseInfo(new CourseBO()
            
            {
                Name = Name,
                Code = Code,
                CourseDuration = CourseDuration,
                Credit = Credit,
                Outline = Outline,
                TagId = TagId,
                UserId = user.Id,
            });

            foreach (var tagId in TagId)
            {
                _courseService.AddCourseTagInfo(new CourseTagBO()
                {
                    TagId = tagId,
                    CourseId = courseId
                });
            }
        }

        public void GetAllTags()
        {
            var tags = _courseService.GetAllTag();

            var tagList = (from t in tags
                           select new SelectListItem
                           {
                               Value = t.Id.ToString(),
                               Text = t.Name.ToString(),
                           }).ToList();

            Tags = tagList;
        }
    }
}
