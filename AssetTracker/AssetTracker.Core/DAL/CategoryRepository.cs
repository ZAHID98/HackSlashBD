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
    public class CategoryRepository
    {
        public bool Add(Category category)
        {
            AssetDBContext db = new AssetDBContext();
            db.Categories.Add(category);
            int rowAffected = db.SaveChanges();
            return rowAffected > 0;
        }

        public bool Update(Category category)
        {
            AssetDBContext db=new AssetDBContext();
            db.Categories.Attach(category);
            db.Entry( category).State=EntityState.Modified;
            int rowAffacted = db.SaveChanges();
            return rowAffacted > 0;
        }

        public IList<Category> GetAll()
        {
            AssetDBContext  db=new AssetDBContext();
            var category = db.Categories.Include(c => c.GeneralCategory).ToList();
            return category;
        }

        public Category GetbyId(int id)
        {
            AssetDBContext db=new AssetDBContext();
          var category=  db.Categories.Include(c => c.GeneralCategory).FirstOrDefault(c => c.Id == id);
            return category;
        }
    }
}
