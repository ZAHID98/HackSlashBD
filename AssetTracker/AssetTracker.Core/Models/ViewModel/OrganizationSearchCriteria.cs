using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetTracker.Core.Models.ViewModel
{
    public class OrganizationSearchCriteria
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Code { get; set; }

        public int BranchId { get; set; }
        public string BranchName{ get; set; }
    }
}
