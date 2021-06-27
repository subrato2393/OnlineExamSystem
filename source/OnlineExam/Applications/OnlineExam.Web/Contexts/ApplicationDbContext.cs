using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineExam.Web.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineExam.Web.Contexts
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
