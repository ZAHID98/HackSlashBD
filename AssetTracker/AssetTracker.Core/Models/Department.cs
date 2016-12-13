using System;
using System.Collections.Generic;
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
        public int OrganizationId { get; set; }
        public int OrganizationBranchId { get; set; }
        public virtual ICollection<Employee>  Employee { get; set; }
        public virtual OrganizationBranch OrganizationBranch { get; set; }
        public virtual Organization Organization { get; set; }
    }
}
