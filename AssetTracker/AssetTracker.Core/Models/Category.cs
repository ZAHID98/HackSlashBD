
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace AssetTracker.Core.Models
{
    public class Category
    {
        public int Id  { get; set; }
       
        [Required]
        public string Name { get; set; }
        [Required]
        public string Code { get; set; }
        public string Description { get; set; }
        [DisplayName("General Category")]
        [ForeignKey("GeneralCategory")]
        public int GeneralCategoryId { get; set; }
        public virtual GeneralCategory GeneralCategory { get; set; }
        public ICollection<SubCategory> SubCategories { get; set; }
        
    }
}
