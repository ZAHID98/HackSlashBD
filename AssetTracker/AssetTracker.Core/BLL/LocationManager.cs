using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssetTracker.Core.Context;
using AssetTracker.Core.DAL;
using AssetTracker.Core.Models;

namespace AssetTracker.Core.BLL
{
   
    public class LocationManager
    {
        AssetLocationRepository repository=new AssetLocationRepository();
        public bool Add(Location location)
        {
            
            if (location .OrganizationBranch==null)
            {
                return false;
            }
            if (location.Name == null)
            {
                return false;

            }
            if (location.ShortName.Length <= 3)
            {
                return false;

            }
            return repository.Add(location);
        }

        public bool Update(Location location)

        {

            bool isUpdated = repository.Update(location);
            return isUpdated;
            ;
        }

        public Location GetById(int id)
        {
            var location = repository.GetById(id);
            return location;
        }
    }
}
