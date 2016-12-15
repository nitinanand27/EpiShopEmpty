using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using EPiServer.Shell.Security;
using EpiShopEmpty.Models.Pages;

namespace EpiShopEmpty.Controllers
{
    public abstract class PageControllerBase<T> : PageController<T> where T : SitePageData
    {
        protected EPiServer.ServiceLocation.Injected<UISignInManager> UISignInManager;
        public ActionResult Logout()
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */

            UISignInManager.Service.SignOut();
            return RedirectToAction("Index");
        }
    }
}