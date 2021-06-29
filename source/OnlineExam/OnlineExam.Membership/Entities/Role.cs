using Microsoft.AspNetCore.Identity;
using System;


namespace OnlineExam.Membership.Entities
{
    public class Role : IdentityRole<Guid>
    {
        public Role()
        {

        }
        public Role(string roleName):base(roleName)
        {

        }
    }
}
