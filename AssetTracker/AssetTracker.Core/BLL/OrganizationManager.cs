using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using AssetTracker.Core.DAL;
using AssetTracker.Core.Models;

namespace AssetTracker.Core.BLL
{
    public class OrganizationManager
    {
        OrganizationRepository repository = new OrganizationRepository();

        public bool Add(Organization organization)
        {
            using (var ts = new TransactionScope())
            {

                if (organization == null)
                    return false;

                if (organization.Code.Length != 3)
                {
                    return false;
                }

                bool isSaveed =  repository.Add(organization);
                
                    ts.Complete();
                
               

                return isSaveed;

            }

        }

        public Organization GetById(int id)
        {
            return repository.GetById(id);
        }

        public List<Organization> GetAll()
        {
            return repository.GetAll().ToList();
        }
    }
}
