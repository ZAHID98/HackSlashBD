using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetTracker.Core.Models
{
    public class Location
    {
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public int BranchId { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public Organization Organization { get; set; }
        public OrganizationBranch OrganizationBranch { get; set; }
    }
}
