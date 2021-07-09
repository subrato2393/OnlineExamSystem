using OnlineExam.DataAccessLayarsLayer;
using OnlineExam.Organization.Contexts;
using OnlineExam.Organization.Entities;
using System;

namespace OnlineExam.Organization.Repositories
{
    public class TagRepository : Repository<Tag,Guid,OrganizationDbContext>,ITagRepository
    {
        public TagRepository(OrganizationDbContext context)
            :base(context)
        {

        }
    }
}
