using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineExam.Membership.Entities;
using System;


namespace OnlineExam.Membership.Contexts
{
    public class ApplicationDbContext : IdentityDbContext
        <ApplicationUser,Role,Guid,UserClaim,UserRole,UserLogin,RoleClaim,UserToken>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
