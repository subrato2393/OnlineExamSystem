using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using OnlineExam.Web.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExam.Web.Services
{
    public class SignInManager : SignInManager<ApplicationUser> 
    {
        public SignInManager(UserManager<ApplicationUser> userManager, IHttpContextAccessor contextAccessor,
            IUserClaimsPrincipalFactory<ApplicationUser> claimsFactory, IOptions<IdentityOptions> optionsAccessor,
            ILogger<SignInManager<ApplicationUser>> logger,IAuthenticationSchemeProvider schemes,
            IUserConfirmation<ApplicationUser> confirmation) 
            
            :base(userManager,contextAccessor,claimsFactory,optionsAccessor,
                 logger,schemes,confirmation)
        {

        }
    }
}
