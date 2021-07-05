using OnlineExam.DataAccessLayarsLayer;
using OnlineExam.Organization.Contexts;
using OnlineExam.Organization.Entities;
using System;

namespace OnlineExam.Organization.Repositories
{
    public class CourseRepository : Repository<Course, Guid, OrganizationDbContext>, ICourseRepository
    {
        public CourseRepository(OrganizationDbContext context)
            : base(context)
        {

        }
    }
}
