using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using AssetTracker.Core.DAL;
using AssetTracker.Core.Models;

namespace AssetTracker.Core.BLL
{
   public  class OrganizationBranchManager
    {
       OrganizationBranchRepository OrganizationBranchRepository=new OrganizationBranchRepository();

        public bool Add(OrganizationBranch organizationBranch)
        {
            if (organizationBranch == null)
            {
                return false;
            }
            if (organizationBranch.ShortName.Length < 2)
            {
                return false;

            }
            return OrganizationBranchRepository.Add(organizationBranch);
        }

        public bool Update(OrganizationBranch organizationBranch)
        {
            bool isUpated = OrganizationBranchRepository.Update(organizationBranch);
            return isUpated;
            ;
        }

        public OrganizationBranch GetById(int id)
        {
            var organizationBranch = OrganizationBranchRepository.GetById(id);

            return organizationBranch;
        }
    }
}
