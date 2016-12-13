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


        public virtual GeneralCategory GeneralCategory { get; set; }
        public virtual Category Category { get; set; }
        public virtual SubCategory SubCategory { get; set; }
    }
}
