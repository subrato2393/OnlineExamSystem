using OnlineExam.DataAccessLayar;
using OnlineExam.Organization.Contexts;
using OnlineExam.Organization.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineExam.Organization.Repositories
{
    public interface ITagRepository : IRepository<Tag, Guid, OrganizationDbContext>
    {

    }
}
