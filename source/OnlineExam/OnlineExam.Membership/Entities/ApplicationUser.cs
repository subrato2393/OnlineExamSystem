using Microsoft.AspNetCore.Identity;
using System;


namespace OnlineExam.Membership.Entities
{
    public class ApplicationUser : IdentityUser<Guid>
    {

        public ApplicationUser()
        {

        }

        public ApplicationUser(string userName)
            :base(userName)
        {

        }

        public string Name { get; set; }
        public string Code { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string About { get; set; }
        public byte[] Logo { get; set; } 
    }
}
