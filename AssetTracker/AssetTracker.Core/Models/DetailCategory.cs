using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetTracker.Core.Models
{
    public class DetailCategory
    {
        public int Id { get; set; }

        public int GeneralCategoryId { get; set; }

        public int CategoryId { get; set; }

        public int SubCategoryId { get; set; }
        [Required]
        public string Code { get; set; }
        public string Description { get; set; }


        public  GeneralCategory GeneralCategory { get; set; }
        public Category Category { get; set; }
        public SubCategory SubCategory { get; set; }
    }
}
