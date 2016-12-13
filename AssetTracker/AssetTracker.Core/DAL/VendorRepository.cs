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
 public  class VendorRepository
    {
        public bool Add(Vendor vendor)
        {
            AssetDBContext db =new AssetDBContext();
            db.Vendors.Add(vendor);
            int rowAffected = db.SaveChanges();
            return rowAffected > 0;

        }

        public bool Update(Vendor vendor)
        {
            AssetDBContext db=new AssetDBContext();
            db.Vendors.Attach(vendor);
            db.Entry(vendor).State=EntityState.Modified;
            int rowAffacted = db.SaveChanges();
            return rowAffacted > 0;
        }

        public IList<Vendor> GetAll()
        {
            AssetDBContext db = new AssetDBContext();
            var vendors = db.Vendors.ToList();
            return vendors;
        }

        public Vendor GetById(int id)
        {
            AssetDBContext db=new AssetDBContext();
            var vendors = db.Vendors.FirstOrDefault(c => c.Id == id);
            return vendors;
        }
    }
}
