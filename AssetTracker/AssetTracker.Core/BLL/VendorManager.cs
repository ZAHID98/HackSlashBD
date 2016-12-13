using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssetTracker.Core.DAL;
using AssetTracker.Core.Models;

namespace AssetTracker.Core.BLL
{
   public class VendorManager
    {
       VendorRepository repository=new VendorRepository();

        public bool Add(Vendor vendor)
        {
            if(vendor.Name ==null)
            {
                return false;
            }
            if (vendor.PhoneNuber == null)
            {
                return false;
            }
            if (vendor.Address == null)
            {
                return false;
            }
            return repository.Add(vendor);
        }

        public bool Update(Vendor vendor)
        {
            bool isUpdated = repository.Update(vendor);
            return isUpdated;
            ;
        }

        public Vendor GetbyId(int id)
        {
            var vendor = repository.GetById(id);
            return vendor;
        }
    }
}
