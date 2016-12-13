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
    public class OrganizationBranchRepository
    {
        public bool Add(OrganizationBranch organizationBranch)
        {
            AssetDBContext db = new AssetDBContext();
            db.OrganizationBranches.Add(organizationBranch);
            int rowAffacted = db.SaveChanges();
            return rowAffacted > 0;

        }

        public bool Update(OrganizationBranch organizationBranch)
        {
            AssetDBContext db = new AssetDBContext();
            db.OrganizationBranches.Attach(organizationBranch);
            db.Entry(organizationBranch).State = EntityState.Modified;
            int rowAffacted = db.SaveChanges();
            return rowAffacted > 0;
        }

        public IList<OrganizationBranch> GetAll()
        {
            AssetDBContext db = new AssetDBContext();
            var organizationBranches = db.OrganizationBranches.Include(c => c.Organization).ToList();
            return organizationBranches;
        }

        public OrganizationBranch GetById(int id)
        {
            AssetDBContext db = new AssetDBContext();
            var organizationBranch = db.OrganizationBranches.Include(c => c.Organization)
                .FirstOrDefault(c => c.Id == id);
            return organizationBranch;

        }
    }
}
