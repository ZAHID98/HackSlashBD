
using System.Linq;
using System.Web.Mvc;
using AssetTracker.Core.BLL;
using AssetTracker.Core.Context;
using AssetTracker.Core.Models;

namespace AssetTracker.Web.Controllers
{
    public class OrganizationBranchController : Controller
    {
        OrganizationManager organizationManager = new OrganizationManager();
        OrganizationBranchManager _branch = new OrganizationBranchManager();

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

        public JsonResult GetByOrganizationId(int? organizationId)
        {

            var branches = _branch.GetByOrganizationId(organizationId).Select(c => new
            {
                c.Id,
                c.Name,
                c.ShortName,
                c.OrganizationId
            });

            return Json(branches, JsonRequestBehavior.AllowGet);
        }
    }
}