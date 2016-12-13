using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using AssetTracker.Core.Context;
using AssetTracker.Core.Models;

namespace AssetTracker.Core.DAL
{
  public class SubCategoryRepository
    {
        public bool Add(SubCategory subCategory)
        {
            AssetDBContext db  =new AssetDBContext();
            db.SubCategories.Add(subCategory);
            int rowAffected = db.SaveChanges();
            return rowAffected > 0;
        }

        public bool Update(SubCategory subCategory)
        {
            AssetDBContext db =new AssetDBContext();
            db.SubCategories.Attach(subCategory);
            db.Entry(subCategory).State=EntityState.Modified;
            int rowAffected = db.SaveChanges();
            return rowAffected > 0;
        }

        public IList<SubCategory> GetAll()
        {
            AssetDBContext  db =new AssetDBContext();
            var subCategory = db.SubCategories.Include(c => c.Category).ToList();
            return subCategory;
        }

        public SubCategory GetById( int id )
        {
            AssetDBContext db =new AssetDBContext();
            var subCategory = db.SubCategories.Include(c => c.Category).FirstOrDefault(c => c.Id == id);
            return subCategory;
        }
    }
}
