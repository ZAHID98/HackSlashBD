using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssetTracker.Core.DAL;
using AssetTracker.Core.Models;

namespace AssetTracker.Core.BLL
{
    class GeneralCategoryManager
    {
        GeneralCategoryRepository repository=new GeneralCategoryRepository();
        public bool Add(GeneralCategory generalCategory)
        {
            if (generalCategory.Name == null)
            {
                return false;
            }
            if (generalCategory.Code.Length != 2)
            {
                return false;
            }
            return repository.Add(generalCategory);
        }
        public bool Update(GeneralCategory generalCategory)
        {

            bool isUpdated = repository.Update(generalCategory);
            return isUpdated;
            ;
        }

        public GeneralCategory GetById(int id)
        {
            var generalCategory = repository.GetById(id);
            return generalCategory;
        }
    }
}
