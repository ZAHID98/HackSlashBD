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
  public class AssetLocationRepository
    {
        public bool Add(Location location)
        {
            AssetDBContext db=new AssetDBContext();
            db.Locations.Add(location);
            int rowAffected = db.SaveChanges();
            return rowAffected > 0;
        }

        public bool Update(Location location)
        {
            AssetDBContext db=new AssetDBContext();
            db.Locations.Attach(location);
            db.Entry(location).State=EntityState.Modified;
            int rowAffected = db.SaveChanges();
            return rowAffected > 0;
        }

        public IList<Location> GetAll()
        {
            AssetDBContext db=new AssetDBContext();
            var location = db.Locations.Include(c => c.OrganizationBranch).ToList();
            return location;
        }

        public Location GetById(int id)
        {
            AssetDBContext db=new AssetDBContext();
            var location = db.Locations.Include(c => c.OrganizationBranch).FirstOrDefault(c => c.Id == id);
            return location;
        }
    }
}
