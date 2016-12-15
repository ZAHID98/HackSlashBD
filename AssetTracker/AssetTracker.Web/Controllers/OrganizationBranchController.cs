
using System.Web.Mvc;
using AssetTracker.Core.BLL;
using AssetTracker.Core.Context;
using AssetTracker.Core.Models;

namespace AssetTracker.Web.Controllers
{
    public class OrganizationBranchController : Controller
    {
        OrganizationManager organizationManager = new OrganizationManager();
        public ActionResult Entry(int? id)
        {
            var organizations = organizationManager.GetAll();
            ViewBag.Organizations = organizations;
            return View();
        }

        [HttpPost]
        public ActionResult Entry(OrganizationBranch organizationBranch)
        {
            AssetDBContext context = new AssetDBContext();

            context.OrganizationBranches.Add(organizationBranch);
            int rowAffected = context.SaveChanges();

            return RedirectToAction("Entry");
        }

        public ActionResult Edit()
        {
            return View();
        }
    }
}