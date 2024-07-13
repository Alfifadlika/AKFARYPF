using AkademiFarmasiYPF.Helper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace AkademiFarmasiYPF.Areas.Administrator.Controllers
{
    [Area(nameof(Administrator))]
    [SessionAuthorize]
    public class BaseController<T> : Controller
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var claims = context.HttpContext.User.Identities?.First().Claims.ToList();
            ViewBag.IdUser = Guid.Parse(claims?.FirstOrDefault(x => x.Type.Equals("user_id"))?.Value);
            ViewBag.Username = claims?.FirstOrDefault(x => x.Type.Equals("username"))?.Value;
            ViewBag.Fullname = claims?.FirstOrDefault(x => x.Type.Equals("fullname"))?.Value;
            ViewBag.Page = Request.Path.Value;
        }
    }
}
