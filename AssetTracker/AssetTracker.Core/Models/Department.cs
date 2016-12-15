using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssetTracker.Core.Models.ViewModel;

namespace AssetTracker.Core.Models
{
    public class Department
    {
        public int Id{ get; set; }
        public string Name { get; set; }
       [DisplayName ("Organization Branch")]
       [ForeignKey("OrganizationBranch")]
        public int OrganizationBranchId { get; set; }
       public virtual OrganizationBranch OrganizationBranch { get; set; }

        public virtual ICollection<Employee>  Employees { get; set; }
        
        
    }
}
