using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssetTracker.Core.DAL;
using AssetTracker.Core.Models;

namespace AssetTracker.Core.BLL
{
    
    public class SubCategoryManager
    {
        SubCategoryRepository repository=new SubCategoryRepository();
        public bool Add(SubCategory subCategory)
        {
           
            if (subCategory.Category == null) 
            {
                return false;
            }
            if (subCategory.Code != null && ((subCategory.Code == null) && (subCategory.Code.Length <= 2)))
            {
                return false;
            }
            return repository.Add(subCategory);
        }

        public bool Update(SubCategory subCategory)
        {
            bool isUpdated = repository.Update(subCategory);
            return isUpdated;
            ;
        }

        public SubCategory GetById(int id)
        {
            var subCategory = repository.GetById(id);
            return subCategory;
        }
    }
}
