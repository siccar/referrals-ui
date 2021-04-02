using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenReferralPOV.Identity
{
    public class IdentityService : IIdentityService
    {
        private readonly IHttpContextAccessor _context;

        public IdentityService(IHttpContextAccessor context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public bool IsUserAuthenticated()
        {
            var isUserAuthenticated = _context.HttpContext.User.Identity.IsAuthenticated;
            return isUserAuthenticated;
        }
    }
}
