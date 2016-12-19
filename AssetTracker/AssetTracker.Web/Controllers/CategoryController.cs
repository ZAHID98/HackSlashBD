using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AssetTracker.Core.BLL;
using AssetTracker.Core.Models;

namespace AssetTracker.Web.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager _categoryManager=new CategoryManager();
        public ActionResult Entry()
        {
            return View();
        }
       [HttpPost]
        public ActionResult Entry(Category category)
       {
           bool isSaved = _categoryManager.Add(category);
            return View();
        }
	}
}