using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssetTracker.Core.DAL;
using AssetTracker.Core.Models;

namespace AssetTracker.Core.BLL
{
   public class CategoryManager
    {
       CategoryRepository repository=new CategoryRepository();
        public bool Add(Category category)
        {
            if (category.GeneralCategory == null)
            {
                return false;
            }
            if (category.Name == null)
            {
                return false;
            }
            if (category.Code.Length <= 2)
            {
                return false;
            }
            return repository.Add(category);
        }
        public bool Update(Category category)
        {

            bool isUpdated = repository.Update(category);
            return isUpdated;
            ;
        }

        public Category GetbyId(int id)
        {
            var generalCategory = repository.GetbyId(id);
            return generalCategory;
        }

    }
}
