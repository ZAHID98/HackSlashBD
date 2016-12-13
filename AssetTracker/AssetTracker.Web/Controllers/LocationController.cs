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
        LocationManager locationManager=new LocationManager();
        public ActionResult Entry()
        {
            return View();
        }
    [HttpPost]
        public ActionResult Entry(Location location)
    {
        AssetDBContext context = new AssetDBContext();

        context.Locations.Add(location);
        int rowAffected = context.SaveChanges();

        return RedirectToAction("Entry");

        //bool isSaved = locationManager.Add(location);
        //    if (isSaved)
        //    {
        //        ViewBag.SuccessMessage = "Saved Successfully!";
        //    }
        //    else
        //    {
        //        ViewBag.ErrorMessage = "Save Failed!";
        //    }


        //    return View();
        }

	}
}