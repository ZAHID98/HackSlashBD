using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AssetTracker.Core.BLL;
using AssetTracker.Core.Context;
using AssetTracker.Core.Models;

namespace AssetTracker.Web.Controllers
{
    public class LocationController : Controller

    {
        public  OrganizationManager _organization = new OrganizationManager();
        public OrganizationBranchManager _Branch=new OrganizationBranchManager();

        LocationManager locationManager=new LocationManager();
        public ActionResult Entry()
        {

            var organizations = _organization.GetAll();
            ViewBag.Organizations = organizations;

            return View();
        }
    [HttpPost]
        public ActionResult Entry(Location location)
    {

     

        return View();
        }

	}
}