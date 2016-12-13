using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetTracker.Core.Models
{
    public class PurchaseHeader
    {
        public string Id { get; set; }
        public DateTime PurchaseDate  { get; set; }

        public int VendorId { get; set; }

    }
}
