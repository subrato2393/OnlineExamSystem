using OnlineExam.Organization.Entities;
using System;
using System.Collections.Generic;
using CourseBO = OnlineExam.Organization.BusinessObjects.Course;
using CourseEO = OnlineExam.Organization.Entities.Course;
using CourseTagBO = OnlineExam.Organization.BusinessObjects.CourseTag;

namespace OnlineExam.Organization.Services
{
    public interface ICourseService
    {
        Guid AddCourseInfo(CourseBO courseBo);
         
        IList<Tag> GetAllTag();
        void AddCourseTagInfo(CourseTagBO courseTagBo);
        Guid GetIdentityColumn(CourseEO courseEo); 
    }
}