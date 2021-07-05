using OnlineExam.DataAccessLayar;
using OnlineExam.Organization.Contexts;
using OnlineExam.Organization.Entities;
using System;

namespace OnlineExam.Organization.Repositories
{
    public interface ICourseRepository : IRepository<Course, Guid, OrganizationDbContext>
    {
    }
}