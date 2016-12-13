using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AssetTracker.Core.Models
{
    public class GeneralCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Required ]
        public string Code { get; set; }
       
        public virtual ICollection<Category> Categories { get; set; }
        public virtual ICollection<SubCategory> SubCategories { get; set; }
       // public virtual ICollection<DetailCategory> DetailCategories { get; set; }
        
    }
}
