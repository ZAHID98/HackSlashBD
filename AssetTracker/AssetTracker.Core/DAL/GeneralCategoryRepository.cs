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
    class GeneralCategoryRepository
    {
        public bool Add(GeneralCategory generalCategory)
        {
            AssetDBContext db = new AssetDBContext();
            db.GeneralCategories.Add(generalCategory);
            int rowAffected = db.SaveChanges();
            return rowAffected > 0;
        }

        public bool Update(GeneralCategory generalCategory)
        {
            AssetDBContext db = new AssetDBContext();
            db.GeneralCategories.Attach(generalCategory);
            db.Entry(generalCategory).State = EntityState.Modified;
            int rowAffected = db.SaveChanges();
            return rowAffected > 0;
        }

        public IList<GeneralCategory> GetAll()
        {
            AssetDBContext db = new AssetDBContext();
            var gCategory = db.GeneralCategories.ToList();
            return gCategory;
        }

        public GeneralCategory GetById(int id)
        {
            AssetDBContext db = new AssetDBContext();
            var gCategory = db.GeneralCategories.FirstOrDefault(c => c.Id == id);
            return gCategory;

        }
    }
}

