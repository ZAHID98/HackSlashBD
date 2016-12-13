using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssetTracker.Core.Context;
using AssetTracker.Core.Models;

namespace AssetTracker.Core.DAL
{
    class DetailCategoryRepository
    {
        public bool Add(DetailCategory detailCategory)
        {
            AssetDBContext db = new AssetDBContext();
            db.DetailCategories .Add(detailCategory);
            int rowAffected = db.SaveChanges();
            return rowAffected > 0;
        }

        public bool Update(DetailCategory detailCategory)
        {
            AssetDBContext db = new AssetDBContext();
            db.DetailCategories.Attach(detailCategory);
            db.Entry(detailCategory).State = EntityState.Modified;
            int rowAffacted = db.SaveChanges();
            return rowAffacted > 0;
        }

        public IList<DetailCategory> GetAll()
        {
            AssetDBContext db = new AssetDBContext();
            var detialCategory = db.DetailCategories.Include(c => c.SubCategory).ToList();
            return detialCategory;
        }

        public DetailCategory GetbyId(int id)
        {
            AssetDBContext db = new AssetDBContext();
            var detialCategory = db.DetailCategories.Include(c => c.SubCategory).FirstOrDefault(c => c.Id == id);
            return detialCategory;
        }
    }
}
