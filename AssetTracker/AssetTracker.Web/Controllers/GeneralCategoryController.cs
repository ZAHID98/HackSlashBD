using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using AssetTracker.Core.BLL;
using AssetTracker.Core.Models;

namespace AssetTracker.Web.Controllers
{
    public class GeneralCategoryController : Controller
    {
       GeneralCategoryManager _categoryManager=new GeneralCategoryManager();
        //
        // GET: /GeneralCategory/
        public ActionResult Entry()
        {
            return View();
        }
    [HttpPost]
        public ActionResult Entry(GeneralCategory generalCategory)
    {
        bool isSaved = _categoryManager.Add(generalCategory);
        
            return View();
        }
	}
}