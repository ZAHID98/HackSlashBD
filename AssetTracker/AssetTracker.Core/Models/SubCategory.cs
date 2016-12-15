using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetTracker.Core.Models
{
   public  class SubCategory
    {
        public int  Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        [DisplayName ("Category")]
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public virtual  Category Category { get; set; }

        public virtual ICollection<DetailCategory> DetailCategory { get; set; }

    }
}
