using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

namespace AkademiFarmasiYPF.Helper
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class SessionAuthorize : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (!context.HttpContext.User.Identity.IsAuthenticated)
                context.Result = new RedirectResult($"~/Administrator/Account/Login");
        }

    }
}
