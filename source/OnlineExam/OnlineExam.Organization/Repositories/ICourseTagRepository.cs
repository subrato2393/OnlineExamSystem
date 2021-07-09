using OnlineExam.DataAccessLayar;
using OnlineExam.Organization.Contexts;
using OnlineExam.Organization.Entities;
using System;

namespace OnlineExam.Organization.Repositories
{
    public interface ICourseTagRepository: IRepository<CourseTag, Guid, OrganizationDbContext>
    {
    }
}