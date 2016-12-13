using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetTracker.Core.Models
{
    public class Category
    {
        public int Id  { get; set; }
        public int GeneralCategoryId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Code { get; set; }
        public string Description { get; set; }
       
        public virtual  GeneralCategory GeneralCategory { get; set; }
        public virtual ICollection<SubCategory> SubCategories { get; set; }
        public virtual ICollection<DetailCategory> DetailsCategory { get; set; }

    }
}
