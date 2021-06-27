﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExam.Web.Entities
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
