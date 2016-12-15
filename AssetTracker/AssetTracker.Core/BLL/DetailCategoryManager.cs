using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssetTracker.Core.DAL;
using AssetTracker.Core.Models;

namespace AssetTracker.Core.BLL
{
 public class DetailCategoryManager
    {
        DetailCategoryRepository repository = new DetailCategoryRepository();
        public bool Add(DetailCategory detailCategory)
        {
            
           
            if (detailCategory.SubCategory == null)
            {
                return false;
            }
           

            if (detailCategory.Code.Length != 2)
            {
                return false;
            }
            return repository.Add(detailCategory);
        }
        public bool Update(DetailCategory detailCategory)
        {

            bool isUpdated = repository.Update(detailCategory);
            return isUpdated;
            ;
        }

        public DetailCategory GetById(int id)
        {
            var detailCategory = repository.GetbyId(id);
            return detailCategory;
        }
    }
}
