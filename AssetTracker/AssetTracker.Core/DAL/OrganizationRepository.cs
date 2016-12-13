using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssetTracker.Core.Context;
using AssetTracker.Core.Models;

namespace AssetTracker.Core.DAL
{
    public class OrganizationRepository
    {
        IList<Organization> organizations = new List<Organization>(); 

        public bool Add(Organization organization)
        {
            AssetDBContext db = new AssetDBContext();

            db.Organizations.Add(organization);

            int rowAffected = db.SaveChanges();

            return rowAffected>0;
        }

        public bool Update(Organization organization)
        {
            return true;
        }

        public bool Remove(Organization organization)
        {
            return true;
        }

        public IList<Organization> GetAll()
        {
            AssetDBContext db = new AssetDBContext();
            var organizations = db.Organizations.ToList();

            return organizations.ToList();
        }

        public Organization GetById(int id)
        {
            AssetDBContext db = new AssetDBContext();

            var organization = db.Organizations.FirstOrDefault(c => c.Id == id);

            return organization;
        }
    }
}
