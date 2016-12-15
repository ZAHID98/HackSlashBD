using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssetTracker.Core.Models.ViewModel;

namespace AssetTracker.Core.Models
{
    public class PurchaseHeader
    {
        public string Id { get; set; }
        public DateTime PurchaseDate  { get; set; }

        public int VendorId { get; set; }
        public string AttachFile { get; set;}
        public int PurchaseDetialsId { get; set;}
        public int OrganizationId { get; set; }
        public int EmployeeId { get; set; }
       
        public virtual PurchaseDetials PurchaseDetials { get; set; }
        public virtual Organization Organization { get; set; }
        public virtual Employee Employee {get;set;}
    }
}
