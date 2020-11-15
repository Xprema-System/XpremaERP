using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Xprema.ERP.Controllers;

namespace Xprema.ERP.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : ERPControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
