using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AssetTracker.Core.BLL;
using AssetTracker.Core.Models;

namespace AssetTracker.Web.Controllers
{
    public class OrganizationController : Controller
    {
        OrganizationManager organizationManager = new OrganizationManager();


        public ActionResult Entry()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Entry(Organization organization)
        {
           
                bool isSaved = organizationManager.Add(organization);
                if (isSaved)
                {
                    ViewBag.SuccessMessage = "Saved Successfully!";
                }
                else
                {
                    ViewBag.ErrorMessage = "Save Failed!";
                }
           

            return View();
        }

        public ActionResult ShowAll()
        {
            return View();
        }

        [HttpPost]
        //public ActionResult ShowAll(Organization organization)
       // {
   //        var  = organizationManager.GetAll(organization).ToList();
       // }
        public string Search(int? id)
        {

            if (id == null)
            {
                return "Id must be provided!";
            }
            var organization = organizationManager.GetById((int)id);

            return "Organization Name: " + organization.Name;
        }

        public ActionResult OrganizationInfo(int? id)
        {
            var organization = organizationManager.GetById((int)id);

            return View(organization);
        }

    }
}