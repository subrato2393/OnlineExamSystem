using OnlineExam.DataAccessLayarsLayer;
using OnlineExam.Organization.Contexts;
using OnlineExam.Organization.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineExam.Organization.Repositories
{
    public class CourseTagRepository : Repository<CourseTag, Guid, OrganizationDbContext>, ICourseTagRepository
    {
        public CourseTagRepository(OrganizationDbContext context)
            : base(context)
        {
             
        }
    }
}
