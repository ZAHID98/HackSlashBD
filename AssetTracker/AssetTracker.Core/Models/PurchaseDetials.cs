using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetTracker.Core.Models
{
   public class PurchaseDetials
    {
       public int PurchaseHeaderId { get; set; }
       public int GeneralCategoryId { get; set; }
        public int  CategoryId { get; set;}
        public int SubCategoryId { get; set; }
        public int DetailCategoryId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set;}
        public int WarrantyPeriod { get; set; }
        public string SerialNo { get; set; }
        public virtual ICollection<PurchaseHeader> PurchaseHeaders { get; set;}
       public virtual GeneralCategory GeneralCategory { get; set; }
       public virtual Category Category { get; set; }
       public virtual SubCategory SubCategory { get; set;}
       public virtual DetailCategory DetailCategory { get; set; }

    }
}
